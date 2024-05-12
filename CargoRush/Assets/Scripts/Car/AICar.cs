using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;

public class AICar : MonoBehaviour
{
    public SplineFollower spline;

    [SerializeField] public float currentSpeed;
    [SerializeField] Vector2[] gearSpeed_During;
    int gearLevel;
    bool raceActive = true;
    [SerializeField] Transform carChild;
    [SerializeField] Wheel[] allWheels;
    [SerializeField] AICarWheelEffect[] wheelsEffects;
    CollectProgressManager _collectProgressManager;
    float maxSpeed;
    [SerializeField] float speedFactor = 1f;
    [SerializeField] GameObject fireRight, fireLeft;
    List<Wheel> frontWheelAll = new List<Wheel>();

    private void Start()
    {
        foreach (var whl in allWheels)
        {
            if (whl.frontWheel)
            {
                frontWheelAll.Add(whl);
            }
        }
        maxSpeed = gearSpeed_During[gearSpeed_During.Length - 1].x;
        _collectProgressManager = CollectProgressManager.Instance;
    }
    private void Update()
    {
        if((float)spline.GetPercent() - (float)CarManager.Instance.spline.GetPercent() > 0.0025f)
        {
            speedFactor = 0.65f;
        }
        if ((float)CarManager.Instance.spline.GetPercent() - (float)spline.GetPercent() > 0.0025f)
        {
            speedFactor = 1.25f;
        }
        if ( Mathf.Abs((float)CarManager.Instance.spline.GetPercent() - (float)spline.GetPercent()) < 0.0005f)
        {
            speedFactor = 1f;
        }

    }
    public void StartRace()
    {
        StartCoroutine(Accelerate());
        StartCoroutine(Patinate());
        foreach (AICarWheelEffect whl_effects in wheelsEffects)
        {
            whl_effects.EmitTyreSkid();
            whl_effects.EmitTyreSmoke();
        }
        //StartCoroutine(AIProgress());
    }
    IEnumerator AIProgress()
    {
        while (raceActive)
        {
            float maxRange = (float)spline.GetPercent() * (maxSpeed / currentSpeed);
            if (currentSpeed < 1f)
            {
                maxRange = 1;
            }
            //_collectProgressManager.AIProgressSet((float)spline.GetPercent(), maxRange);
            yield return new WaitForSeconds(0.05f);
        }
    }
    IEnumerator Accelerate()
    {
        float firstSpeed = 0f;
        if (gearLevel > 0)
        {
            firstSpeed = gearSpeed_During[gearLevel - 1].x;
        }
        float counter = 0f;
        while (counter < 1f && raceActive)
        {
            counter += speedFactor * Time.deltaTime / gearSpeed_During[gearLevel].y;
            currentSpeed = Mathf.Lerp(firstSpeed, gearSpeed_During[gearLevel].x, counter);
            spline.followSpeed = currentSpeed;

            foreach (Wheel whl in allWheels)
            {
                whl.rotateSpeed = currentSpeed;
            }

            yield return null;
        }


        if (raceActive)
        {
            if (gearLevel < gearSpeed_During.Length - 1)
            {
                gearLevel++;
                StartCoroutine(Accelerate());
                StartCoroutine(StopAngle(2f, 3f));
                foreach (AICarWheelEffect whl_effects in wheelsEffects)
                {
                    whl_effects.EmitTyreSmoke();
                }
            }
        }
    
    }
    public void StopCar()
    {
        raceActive = false;
        spline.followSpeed = currentSpeed = 0;
        foreach (Wheel whl in allWheels)
        {
            whl.rotateSpeed = currentSpeed;
        }
        foreach (AICarWheelEffect whl_effects in wheelsEffects)
        {
            whl_effects.EmitTyreSmoke();
        }
    }
    public void SmoothStop()
    {
        StartCoroutine(Smooth_Stop());
        foreach (AICarWheelEffect whl_effects in wheelsEffects)
        {
            whl_effects.EmitTyreSmoke();
        }
    }
    IEnumerator Smooth_Stop()
    {
        StartCoroutine(StopAngle(2f, 5f));

        float firstSpd = currentSpeed;

        float counter = 0;
        while (counter < 1f)
        {
            counter += Time.deltaTime;

            currentSpeed = Mathf.Lerp(firstSpd, 0, counter);
            spline.followSpeed = currentSpeed;
            foreach (Wheel whl in allWheels)
            {
                whl.rotateSpeed = currentSpeed;
            }

            yield return null;
        }
        raceActive = false;
        //DnzEvents.TyreSmokeEvent();

    }
    IEnumerator StopAngle(float rotateSpeed, float rotateAngle)
    {
        float firstRotY = carChild.localEulerAngles.x;
        float angle = 0;
        float counter = 0;
        while (counter < 1f)
        {
            counter += rotateSpeed * Time.deltaTime;
            angle = rotateAngle * Mathf.Sin(counter * Mathf.PI);

            carChild.localRotation = Quaternion.Euler(firstRotY - angle, carChild.localEulerAngles.y, carChild.localEulerAngles.z);

            yield return null;
        }
        carChild.localRotation = Quaternion.Euler(firstRotY, carChild.localEulerAngles.y, carChild.localEulerAngles.z);

    }
    IEnumerator Patinate()
    {
        float firstRotYWheel = -90f;
        foreach (var whl in frontWheelAll)
        {
            firstRotYWheel = whl.transform.localEulerAngles.y;
        }

        fireLeft.SetActive(true);
            fireRight.SetActive(true);

        Quaternion firstRot = carChild.localRotation;
        float firstRotY = carChild.localEulerAngles.y;
        float counter = 0f;
        float angle = 0f;
        while (counter < 1f)
        {
            counter += 1.5f * Time.deltaTime;
            angle = 10 * Mathf.Sin(counter * 5);

            carChild.localRotation = Quaternion.Euler(carChild.localEulerAngles.x, firstRotY + angle, carChild.localEulerAngles.z);
            foreach (var whl in frontWheelAll)
            {
                whl.transform.localRotation = Quaternion.Euler(whl.transform.localEulerAngles.x, firstRotYWheel - angle * 3, whl.transform.localEulerAngles.z);

            }
            yield return null;
        }


        counter = 0f;
        float value = 0f;
        while (counter < 1f)
        {
            counter += 1.5f * Time.deltaTime;
            value = Mathf.Lerp(angle, 0, counter);
            carChild.localRotation = Quaternion.Euler(carChild.localEulerAngles.x, firstRotY + value, carChild.localEulerAngles.z);
            foreach (var whl in frontWheelAll)
            {
                whl.transform.localRotation = Quaternion.Euler(whl.transform.localEulerAngles.x, firstRotYWheel - value, whl.transform.localEulerAngles.z);

            }
            yield return null;
        }
        fireLeft.transform.parent = null;
        fireRight.transform.parent = null;
    }
}

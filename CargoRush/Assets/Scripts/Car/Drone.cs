using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    private Vector3 previousVelocity;
    private Vector3 currentVelocity;
    private float acceleration;

    private Vector3 previousPosition;
    private float deltaTime;


    float currentAngle = 0;
    float preAngle = 0;
    float deltaAngle = 0;
    public Transform droneParentTR;
    public List<Wheel> wheels = new List<Wheel>();

    void Start()
    {
        previousPosition = transform.position;
        previousVelocity = Vector3.zero;
    }


    //public void WheelActivator(bool active)
    //{
    //    foreach (var whl in wheels)
    //    {
    //        whl.runActive = active;
    //    }
    //}
    private void Update()
    {
        currentAngle = transform.eulerAngles.y;

        deltaAngle = currentAngle - preAngle;
        if (Mathf.Abs(deltaAngle) < 0.1f)
        {
            deltaAngle = 0;
        }
        DroneDirector(deltaAngle);
        preAngle = currentAngle;
        AcceleratinCalculator();
    }

    void AcceleratinCalculator()
    {
        // Zaman fark�n� hesapla
        deltaTime = Time.deltaTime;

        // Mevcut h�z� hesapla
        currentVelocity = (transform.position - previousPosition) / deltaTime;

        // H�z b�y�kl���ndeki de�i�imi hesapla
        float speedChange = (currentVelocity - previousVelocity).magnitude;

        // �vmenin skaler b�y�kl���n� hesapla
        acceleration = speedChange / deltaTime;

        // �nceki pozisyonu ve h�z� g�ncelle
        previousPosition = transform.position;
        previousVelocity = currentVelocity;
    }
    void DroneDirector(float angle)
    {
        float ang = 0;
        if(acceleration > 0)
        {
            ang = 35;
        }
        if (acceleration < 0)
        {
            ang = -35;
        }
        if (angle < 0)
        {
            droneParentTR.localRotation = Quaternion.Lerp(droneParentTR.localRotation, Quaternion.Euler(ang, 0, 35), 5 * Time.deltaTime);
        }

        if (angle > 0)
        {
            droneParentTR.localRotation = Quaternion.Lerp(droneParentTR.localRotation, Quaternion.Euler(ang, 0, -35), 5 * Time.deltaTime);
        }
        if (angle == 0)
        {
            droneParentTR.localRotation = Quaternion.Lerp(droneParentTR.localRotation, Quaternion.Euler(ang, 0, 0), 5 * Time.deltaTime);
        }

    }
}

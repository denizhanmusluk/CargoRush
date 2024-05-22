using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    float currentAngle = 0;
    float preAngle = 0;
    float deltaAngle = 0;
    public List<Wheel> wheels = new List<Wheel>();
    public Transform direction;
    public void WheelActivator(bool active)
    {
        foreach (var whl in wheels)
        {
            whl.runActive = active;
        }
    }
    private void Update()
    {
        currentAngle = transform.eulerAngles.y;

        deltaAngle = currentAngle - preAngle;
        if (Mathf.Abs(deltaAngle) < 0.1f)
        {
            deltaAngle = 0;
        }
        WheelDirector(deltaAngle);
        preAngle = currentAngle;
    }
    void WheelDirector(float angle)
    {
        foreach (var whl in wheels)
        {
            whl.wheelDirectionY = angle;
        }

        if (direction != null)
        {

            if (angle < 0)
            {
                direction.localRotation = Quaternion.Lerp(direction.localRotation, Quaternion.Euler(0, -35, 0), 5 * Time.deltaTime);
            }

            if (angle > 0)
            {
                direction.localRotation = Quaternion.Lerp(direction.localRotation, Quaternion.Euler(0, 35, 0), 5 * Time.deltaTime);
            }
            if (angle == 0)
            {
                direction.localRotation = Quaternion.Lerp(direction.localRotation, Quaternion.Euler(0, 0, 0), 5 * Time.deltaTime);
            }
        }
    }
}

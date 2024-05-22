using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    public float rotateSpeed = 0f;
    float speedFactor = 50f;
    public bool frontWheel;
    public Transform wheelTR;
    // Update is called once per frame
    public bool runActive = false;
    public float wheelDirectionY = 0f;
    void Update()
    {
        if (runActive)
        {
            wheelTR.Rotate(speedFactor * rotateSpeed * Time.deltaTime, 0, 0);
        }
        if (frontWheel)
        {
            if (wheelDirectionY < 0)
            {
                transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(0, -35, 0), 5 * Time.deltaTime);
            }

            if (wheelDirectionY > 0)
            {
                transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(0, 35, 0), 5 * Time.deltaTime);
            }
            if (wheelDirectionY == 0)
            {
                transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(0, 0, 0), 5 * Time.deltaTime);
            }
            //transform.localRotation = Quaternion.Euler(0, wheelDirectionY, 0);
        }
    }
}

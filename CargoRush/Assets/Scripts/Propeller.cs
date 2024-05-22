using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    public float rotateSpeed = 0f;
    float speedFactor = 50f;
    public Transform propellerTR;
    public bool runActive = false;
    void Update()
    {
        if (runActive)
        {
            propellerTR.Rotate(0, speedFactor * rotateSpeed * Time.deltaTime, 0);
        }
    }
}

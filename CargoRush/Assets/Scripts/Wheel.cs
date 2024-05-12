using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    public float rotateSpeed = 0f;
    float speedFactor = 50f;
    public bool frontWheel;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -speedFactor * rotateSpeed * Time.deltaTime);
    }
}

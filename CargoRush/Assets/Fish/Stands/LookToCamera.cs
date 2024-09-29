using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookToCamera : MonoBehaviour
{
    Transform cameraTR;
    private void Awake()
    {
        cameraTR = Camera.main.transform;
    }
    private void OnEnable()
    {
        transform.rotation = cameraTR.rotation;
    }
}

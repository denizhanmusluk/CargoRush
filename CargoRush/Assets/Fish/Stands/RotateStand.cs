using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStand : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    
    void LateUpdate()
    {
        transform.Rotate(0, rotateSpeed * 6 * Time.deltaTime, 0);
    }
}

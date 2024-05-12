using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBound : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Fish>() != null)
        {
            other.GetComponent<Fish>().humanRotation += 180;
        }
    }
}

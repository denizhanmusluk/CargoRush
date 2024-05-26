using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpaqueToTransparent : MonoBehaviour
{
    public GameObject transGO;
    public GameObject opaqueGO;
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerController>() != null)
        {
            transGO.SetActive(true);
            opaqueGO.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            transGO.SetActive(false);
            opaqueGO.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SushiAreaCameraSet : MonoBehaviour
{
    [SerializeField] float cameraSizeMax, cameraSizeMin;
    [SerializeField] CinemachineVirtualCamera cmCam;
    bool cameraSetActive;
    private void Start()
    {
        cmCam = CameraManager.Instance.vCamPlayer;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerController>() != null)
        {
            StartCoroutine(CameraSizeSet(cameraSizeMax, cameraSizeMin));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            StartCoroutine(CameraSizeSet(cameraSizeMin, cameraSizeMax));
        }
    }
    IEnumerator CameraSizeSet(float first,float last)
    {
        cameraSetActive = false;
        yield return null;
        cameraSetActive = true;

        float sizeValue;
        float counter = 0f;
        while(counter < 1f && cameraSetActive)
        {
            counter += Time.deltaTime;
            sizeValue = Mathf.Lerp(first, last, counter);
            cmCam.m_Lens.OrthographicSize = sizeValue;
            yield return null;
        }
    }
}

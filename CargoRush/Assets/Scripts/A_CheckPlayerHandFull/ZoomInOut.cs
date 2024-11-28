using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class ZoomInOut : MonoBehaviour
{ 
    public CinemachineVirtualCamera camareNormal;
    public float zoomInSize = 19f;
    public float zoomOutSize = 23f;
    public float lerpDuration = 1f; // Duration of the lerp in seconds
    private bool zoomIn = false;
    
    private Coroutine zoomInCoroutine;
    [SerializeField] private Image zoomInOutImage;
    [SerializeField] private Sprite zoomInSprite,zoomOutSprite;
    

    public void ZoomInOUT()
    {
        if (!zoomIn)
        {
            if(zoomInCoroutine != null) 
                StopCoroutine(zoomInCoroutine);
            zoomInCoroutine = StartCoroutine(LerpOrthographicSize(zoomInSize, zoomOutSize, lerpDuration));
            zoomIn = true;
            zoomInOutImage.sprite = zoomInSprite;
        }
        else
        {
            if(zoomInCoroutine != null)
                StopCoroutine(zoomInCoroutine);
            zoomInCoroutine= StartCoroutine(LerpOrthographicSize(zoomOutSize, zoomInSize, lerpDuration));
            zoomIn = false;
            zoomInOutImage.sprite = zoomOutSprite;
        }
    }

    private IEnumerator LerpOrthographicSize(float startSize, float endSize, float duration)
    {
        float time = 0;
        while (time < duration)
        {
            camareNormal.m_Lens.OrthographicSize = Mathf.Lerp(startSize, endSize, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        camareNormal.m_Lens.OrthographicSize= endSize;
    }
}
 

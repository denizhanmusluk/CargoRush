using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlaneGround : MonoBehaviour
{
    [SerializeField] Transform canvasTR;
    [SerializeField] Vector3 firstScaleCanvasTR;
    [SerializeField] Vector3 firstScale;
    private void Start()
    {
        firstScale = transform.localScale;

        if (canvasTR != null)
        {
            firstScaleCanvasTR = canvasTR.localScale;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerController>() != null)
        {
            OpenScale(transform, firstScale, 1f, 1.2f, 0.1f, Ease.InFlash);
            if (canvasTR != null)
            {
                OpenScale(canvasTR, firstScaleCanvasTR, 1f, 1.2f, 0.1f, Ease.InFlash);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            OpenScale(transform, firstScale, 1.2f, 1f, 0.1f, Ease.InFlash);
            if (canvasTR != null)
            {
                OpenScale(canvasTR, firstScaleCanvasTR, 1.2f, 1f, 0.1f, Ease.InFlash);
            }
        }
    }
    public Tween OpenScale(Transform prt, Vector3 firstScl, float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                prt.localScale = firstScl * value;
            }).OnComplete(delegate ()
            {

            });
        return tween;
    }
}

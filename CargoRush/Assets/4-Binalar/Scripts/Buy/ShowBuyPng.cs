using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ShowBuyPng : MonoBehaviour
{
    [SerializeField] GameObject Canvas;
    Vector3 firstSize;
    public bool firstOpenCloseCanvas = false;
    private void Start()
    {
        firstSize = Canvas.transform.localScale;
        //if (firstOpenCloseCanvas)
        {
            Canvas.transform.localScale = Vector3.zero;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerController>() != null)
        {
            StartCoroutine(OpenCanvas());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            StartCoroutine(CloseCanvas());
        }
    }
    IEnumerator OpenCanvas()
    {
        OpenScale(0f, 0.8f, 0.25f, Ease.InFlash);
        yield return new WaitForSeconds(0.25f);
        OpenScale(0.8f, 1f, 0.25f, Ease.OutElastic);
    }
    IEnumerator CloseCanvas()
    {
        CloseScale(1f, 0.8f, 0.1f, Ease.InElastic);
        yield return new WaitForSeconds(0.1f);
        CloseScale(0.8f, 0f, 0.25f, Ease.InFlash);
    }

    public Tween OpenScale( float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                Canvas.transform.localScale = firstSize * value;
            }).OnComplete(delegate ()
            {
            });
        return tween;
    }

    public Tween CloseScale(float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                Canvas.transform.localScale = firstSize * value;
            }).OnComplete(delegate ()
            {
            });
        return tween;
    }
}

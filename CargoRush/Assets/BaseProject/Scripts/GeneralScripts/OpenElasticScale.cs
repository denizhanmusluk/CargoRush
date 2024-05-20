using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class OpenElasticScale : MonoBehaviour
{
    Vector3 firstScale;
    private void Awake()
    {
        //firstScale = transform.localScale;
        //transform.localScale = Vector3.zero;
    }
    void OnEnable()
    {
        //StartCoroutine(EnableDelay());

        firstScale = transform.localScale;
        OpenScale(transform, 0.5f, 1f, 0.5f, Ease.OutElastic);

    }
    IEnumerator EnableDelay()
    {
        yield return null;
        OpenScale(transform, 0.5f, 1f, 0.5f, Ease.OutElastic);
    }
    public Tween OpenScale(Transform prt, float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                prt.localScale = firstScale * value;
            }).OnComplete(delegate ()
            {

            });
        return tween;
    }
}

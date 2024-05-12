using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class OpenElasticScaleDeltaTime : MonoBehaviour
{
    void OnEnable()
    {
        StartCoroutine(DelayOpen());
    }
    IEnumerator DelayOpen()
    {
        float delayTime = Random.Range(0, 2f);
        yield return new WaitForSeconds(delayTime);
        OpenScale(transform, 0.5f, 1f, 0.5f, Ease.OutElastic);
    }
    public Tween OpenScale(Transform prt, float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Vector3 firstScale = prt.localScale;
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

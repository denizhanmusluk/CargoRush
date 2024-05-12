using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class OpenLinearScale : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        OpenScale(transform, 0f, 1f, 1f, Ease.Flash);
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

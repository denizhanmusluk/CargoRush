using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BoingScale : MonoBehaviour
{
    public Tween ScaleEffectTR(Transform prt, float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                prt.localScale = Vector3.one * value;
            }).OnComplete(delegate ()
            {

            });
        return tween;
    }
}

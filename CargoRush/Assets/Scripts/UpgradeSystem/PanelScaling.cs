using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class PanelScaling : MonoBehaviour
{
    private void OnEnable()
    {
        ScaleEffectOpen(transform, 0.4f, 1f, 0.5f, Ease.OutElastic);
    }
    public void PanelClose()
    {
        ScaleEffectClose(transform, 1f, 0f, 0.5f, Ease.InElastic);
    }
    public Tween ScaleEffectOpen(Transform prt, float value, float lastValue, float duration, DG.Tweening.Ease type)
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
    public Tween ScaleEffectClose(Transform prt, float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                prt.localScale = Vector3.one * value;
            }).OnComplete(delegate ()
            {
                gameObject.SetActive(false);
            });
        return tween;
    }
}

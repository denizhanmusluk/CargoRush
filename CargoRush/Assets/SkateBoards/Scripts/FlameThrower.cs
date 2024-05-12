using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FlameThrower : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform burnParticleTR;
    [SerializeField] float minSize;
    [SerializeField] float maxSize;
    float currentSize = 0f;
    bool burnActive = false;
    private void OnEnable()
    {
        burnParticleTR.transform.localScale = Vector3.one * minSize;
    }
    public void BurnActive()
    {
        if (!burnActive)
        {
            burnActive = true;
            Scale(minSize, maxSize, 1f, Ease.OutElastic);
        }
    }
    public void BurnPassive()
    {
        if (burnActive)
        {
            burnActive = false;
            Scale(maxSize, minSize, 1f, Ease.OutElastic);
        }
    }
    public Tween Scale(float value, float lastValue, float duration, DG.Tweening.Ease type)
    {

        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                burnParticleTR.transform.localScale = Vector3.one * value;
            }).OnComplete(delegate ()
            {
                burnParticleTR.transform.localScale = Vector3.one * lastValue;
            });
        return tween;
    }
}

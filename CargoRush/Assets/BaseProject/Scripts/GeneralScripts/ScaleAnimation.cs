using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScaleAnimation : MonoBehaviour
{

    [SerializeField] float animationPeriod;
    [SerializeField] float duration;
    [SerializeField(), Range(0f, 100f)] private float scaleFactor;
    [SerializeField(), Range(0f, 10f)] private float scaleSpeed;
    Vector3 firstSize;
    void Awake()
    {
        firstSize = transform.localScale;
        //StartCoroutine(swipeMove());
    }
    IEnumerator SwipeMove()
    {
        float counter = 0f;
        float value = 0;
        while (counter < duration)
        {
            counter += scaleSpeed * Time.deltaTime;
            value = Mathf.Abs(Mathf.Sin(counter));
            value *= 0.05f * scaleFactor;
            transform.localScale = firstSize + Vector3.one * value;

            yield return null;
        }
        transform.localScale = firstSize;
    }
    private void OnEnable()
    {
        StartCoroutine(AnimationPeriod());
    }
    IEnumerator AnimationPeriod()
    {
        while (true)
        {
            //StartCoroutine(SwipeMove());
            ScaleEffectTR(transform, 14f, 17f, 1f, Ease.OutElastic);

            yield return new WaitForSeconds(animationPeriod);
        }
    }
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

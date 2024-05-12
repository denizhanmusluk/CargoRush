using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CreateMoney : MonoBehaviour
{
    [SerializeField] Transform[] scaleTR;
    [SerializeField] GameObject pointMoney;
    [SerializeField] Transform moneySpawnPosTR;
    public float spawnTime = 0.67f;
    public int banknotValue = 1;
    Vector3[] firstScale;
    private void Awake()
    {
        //banknotValue *= Globals.levelFactor;
    }
    public void _Start()
    {
        StartCoroutine(StartDelay());
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(2f);
        firstScale = new Vector3[scaleTR.Length];
        if (scaleTR.Length > 0)
        {
            for (int i = 0; i < scaleTR.Length; i++)
            {
                firstScale[i] = scaleTR[i].localScale;
            }
        }
        StartCoroutine(SpawnMoney());
    }
    IEnumerator SpawnMoney()
    {
        float delayTime = Random.Range(0f, 2f);
        yield return new WaitForSeconds(delayTime);
        while (true)
        {
            Point pnt = Instantiate(pointMoney, moneySpawnPosTR.position, Quaternion.identity).GetComponent<Point>();
            pnt.pointValue = banknotValue;
            pnt.PointInit(banknotValue);
            GameManager.Instance.MoneyUpdate(banknotValue);
            if (scaleTR.Length > 0)
            {
                for (int i = 0; i < scaleTR.Length; i++)
                {
                    Scale(firstScale[i], scaleTR[i], 0.9f, 1f, 0.5f, Ease.OutElastic);
                    yield return new WaitForSeconds(0.1f);
                }
            }
            yield return new WaitForSeconds(spawnTime);
        }
    }

    public Tween Scale(Vector3 _firstScale, Transform prt, float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                prt.localScale = _firstScale * value;
            }).OnComplete(delegate ()
            {

            });
        return tween;
    }
}

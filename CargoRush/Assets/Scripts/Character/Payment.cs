using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Payment : MonoBehaviour
{
    [SerializeField] GameObject moneyPrefab;
    [SerializeField] Transform moneyCreatePosTR;
    public void Pay(Vector3 targetPos)
    {
       GameObject mny = Instantiate(moneyPrefab, moneyCreatePosTR.position, Quaternion.identity);
        mny.transform.localScale *= 1.5f;
        mny.GetComponent<BanknotMoney>().MoveObj(moneyCreatePosTR.position, targetPos);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLevelFirstOpenBoss : MonoBehaviour
{
    public string bossName;
    public BossCharacterSecond bossCharacterSecond;
    public Transform exitPosTR;
    public GameObject popUp1_GO;
    public MoneyArea moneyArea;
    public int priceValue;

    void Start()
    {
        if (PlayerPrefs.GetInt(bossName + PlayerPrefs.GetInt("level")) == 0)
        {
            BossActive();
        }
    }

    void BossActive()
    {
        bossCharacterSecond.gameObject.SetActive(true);
        StartCoroutine(GoOut());
    }
    IEnumerator GoOut()
    {
        yield return new WaitForSeconds(7f);
        popUp1_GO.SetActive(true);
        yield return new WaitForSeconds(4f);
        popUp1_GO.SetActive(false);
        bossCharacterSecond.GoExit(exitPosTR);
        //yield return new WaitForSeconds(2f);
        DropMoney();
    }

    void DropMoney()
    {
        StartCoroutine(DroppingMoney());
    }
    IEnumerator DroppingMoney()
    {

        int stepNo = 0;
        int banknotValue = 2;


        int moneyListCount = moneyArea.moneyList.Count;
        int totalMoney = priceValue;

        //if (Globals.doubleIncomeActive)
        //{
        //    totalMoney *= 2;
        //}
        totalMoney /= banknotValue;
        //totalMoney = (int)((float)totalMoney);

        for (int i = 0; i < totalMoney; i++)
        {
            float deltaY = 0;
            deltaY = (moneyListCount + i) / moneyArea.dropMoneyPosList.Count;
            Transform targetTR = moneyArea.dropMoneyPosList[(moneyListCount + i) % moneyArea.dropMoneyPosList.Count];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.2f, 0);
            BanknotMoney banknot = Instantiate(moneyArea.moneyPrefab, moneyArea.firstMoneyCreatePosTR.position, Quaternion.identity).GetComponent<BanknotMoney>();
            banknot.MovingMoney(moneyArea.firstMoneyCreatePosTR.position, dropPos, targetTR);
            banknot.banknotValue = banknotValue;
            //banknot.banknotValue = banknotValue + Globals.extraMoneySkin;
            moneyArea.moneyList.Add(banknot);

            stepNo++;
            if (stepNo % 50 == 0)
            {
                yield return null;
            }
        }
    }
}

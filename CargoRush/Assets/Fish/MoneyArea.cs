using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HomaGames.HomaBelly;

public class MoneyArea : MonoBehaviour
{
    public Transform firstMoneyCreatePosTR;
    public GameObject moneyPrefab;
    public List<Transform> dropMoneyPosList;
    public List<BanknotMoney> moneyList = new List<BanknotMoney>();
    bool moneyCollectActive = false;
    public GameObject caseArea;
    public string moneyEarningTag;
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerController>() != null && !moneyCollectActive)
        {
            moneyCollectActive = true;
            MoneyCollect();
            if (caseArea != null && caseArea.GetComponent<IMoneyArea>() != null)
            {
                caseArea.GetComponent<IMoneyArea>().MoneySave();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            moneyCollectActive = false;
        }
    }

    void MoneyCollect()
    {
        StartCoroutine(MoneyCollecting());
    }
    IEnumerator MoneyCollecting()
    {
        int stepNo = 0;
        List<BanknotMoney> tempMoneyList = new List<BanknotMoney>();
        int totalEarn = 0;
        foreach(var mny in moneyList)
        {
            tempMoneyList.Add(mny);
            totalEarn += mny.banknotValue;
        }
        if (totalEarn > 0)
        {
            PlayerController.Instance.CreateMoneyText(totalEarn);
        }
        moneyList.Clear();

        for (int i = tempMoneyList.Count-1; i >= 0; i--)
        {
            VibratoManager.Instance.LightVibration();
            AudioManager.Instance.MoneyCollectSound();

            tempMoneyList[i].MovingMoneyUI(tempMoneyList[i].transform.position, GameManager.Instance.ui.moneyTarget);
            stepNo++;
            if (stepNo % 50 == 0)
            {
                yield return null;
            }
        }

        yield return new WaitForSeconds(0.5f);
        GameManager.Instance.MoneyUpdate(totalEarn);

        Analytics.ResourceFlowEvent(ResourceFlowType.Source, "Money", totalEarn, (float)Globals.moneyAmount, null, moneyEarningTag, ResourceFlowReason.Progression);


    }
}

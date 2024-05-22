using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiCaseManager : MonoBehaviour
{
    private static SushiCaseManager _instance = null;
    public static SushiCaseManager Instance => _instance;

    [SerializeField] MoneyArea moneyArea;
    public Transform paymentPoint;
    public Sprite standSprite;

    private void Awake()
    {
        _instance = this;
    }
    public void PayCustomer(AISushiCustomer aiSushiCustomer)
    {
        DropMoney(aiSushiCustomer);
    }
    void DropMoney(AISushiCustomer aiSushiCustomer)
    {
        StartCoroutine(DroppingMoney(aiSushiCustomer));
    }
    IEnumerator DroppingMoney(AISushiCustomer aiSushiCustomer)
    {
        List<Collectable> droppingCollectionList = aiSushiCustomer.collectableList;

        int moneyListCount = moneyArea.moneyList.Count;
        for (int i = 0; i < droppingCollectionList.Count; i++)
        {
            float deltaY = 0;
            deltaY = (moneyListCount + i) / moneyArea.dropMoneyPosList.Count;
            Transform targetTR = moneyArea.dropMoneyPosList[(moneyListCount + i) % moneyArea.dropMoneyPosList.Count];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.2f, 0);
            BanknotMoney banknot = Instantiate(moneyArea.moneyPrefab, moneyArea.firstMoneyCreatePosTR.position, Quaternion.identity).GetComponent<BanknotMoney>();
            banknot.MovingMoney(moneyArea.firstMoneyCreatePosTR.position, dropPos, targetTR);
            banknot.banknotValue = droppingCollectionList[i].price;
            moneyArea.moneyList.Add(banknot);
            yield return null;
        }
        aiSushiCustomer.GoExit();
    }
    
}

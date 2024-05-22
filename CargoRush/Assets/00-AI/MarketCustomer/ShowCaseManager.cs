using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCaseManager : MonoBehaviour
{
    private static ShowCaseManager _instance = null;
    public static ShowCaseManager Instance => _instance;

    [SerializeField] MoneyArea moneyArea;
    public Transform paymentPoint;
    public Sprite standSprite;

    private void Awake()
    {
        _instance = this;
    }
    public void PayCustomer(ShowCustomer aiSushiCustomer)
    {
        DropMoney(aiSushiCustomer);
    }
    void DropMoney(ShowCustomer aiSushiCustomer)
    {
        StartCoroutine(DroppingMoney(aiSushiCustomer));
    }
    IEnumerator DroppingMoney(ShowCustomer aiSushiCustomer)
    {
        List<Collectable> droppingCollectionList = aiSushiCustomer.collectableList;

        int moneyListCount = moneyArea.moneyList.Count;
        for (int i = 0; i < aiSushiCustomer.banknotCount; i++)
        {
            float deltaY = 0;
            deltaY = (moneyListCount + i) / moneyArea.dropMoneyPosList.Count;
            Transform targetTR = moneyArea.dropMoneyPosList[(moneyListCount + i) % moneyArea.dropMoneyPosList.Count];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.2f, 0);
            BanknotMoney banknot = Instantiate(moneyArea.moneyPrefab, moneyArea.firstMoneyCreatePosTR.position, Quaternion.identity).GetComponent<BanknotMoney>();
            banknot.MovingMoney(moneyArea.firstMoneyCreatePosTR.position, dropPos, targetTR);
            banknot.banknotValue = aiSushiCustomer.moneyValue;
            moneyArea.moneyList.Add(banknot);
            yield return null;
        }
        aiSushiCustomer.GoExit();
    }

}

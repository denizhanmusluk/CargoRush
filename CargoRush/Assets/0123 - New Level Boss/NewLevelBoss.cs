using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLevelBoss : MonoBehaviour
{
    public string bossName;
    public BossCharacter bossCharacter;
    [SerializeField] MoneyArea moneyArea;
    public int priceValue;
    public Transform playerTargetTeleportPosTR;

    public Transform playerTargetPosTR;
    public Transform exitPosTR;

    public GameObject popUp1_GO;
    public GameObject popUp2_GO;


    void Start()
    {
        if(PlayerPrefs.GetInt(bossName) == 0)
        {
            BossActive();
        }
    }
    void BossActive()
    {
        BossTutorialPanel.Instance.newLevelBoss = this;
        PlayerController.Instance.newLevelBoss = this;
        PlayerController.Instance.PlayerRotReset();
        PlayerController.Instance.PlayerControlDeActive();
        PlayerController.Instance.FollowCeo();
        //StartCoroutine(CharacterTeleport());
    }
    IEnumerator CharacterTeleport()
    {
        yield return new WaitForSeconds(1f);
        PlayerController.Instance.transform.position = playerTargetTeleportPosTR.position;
    }
    // Update is called once per frame
    public void CharacterArrivedBoss()
    {
        popUp1_GO.SetActive(true);
        BossTutorialPanel.Instance.tap1ImgGO.SetActive(true);
    }
    public void PopUp2_Open()
    {
        popUp1_GO.SetActive(false);
        popUp2_GO.SetActive(true);

    }
    public void BossFinish()
    {
        popUp2_GO.SetActive(false);
        DropMoney();
        PlayerController.Instance.PlayerControl_ReActive();
        bossCharacter.GoExit(exitPosTR);
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
            if (stepNo % 5 == 0)
            {
                yield return null;
            }
        }
    }
    }

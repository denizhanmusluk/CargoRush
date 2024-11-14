using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class MapRoom : MonoBehaviour, IMoneyArea
{
    public MapSettings mapSettings;
    public int mapID;

    [HideInInspector]
    public int offlineCount;
    public MoneyArea moneyArea;

    float openRatio = 0f;

    public MapRoomUI mapRoomUI;

    public Transform tutorialPosTR;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            MapAreaManager.Instance.mapPanelList[mapID].SetActive(true);
            if (PlayerPrefs.GetInt("maptutorialseq") == 2 && mapID == 1)
            {
                PlayerPrefs.SetInt("maptutorialseq", 3);
                IndicatorManager.Instance.IndicaorDeActive();
                IndicatorManager.Instance.indicatorMesh.enabled = false;
                IndicatorManager.Instance.TutorialStepCompleted();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            MapAreaManager.Instance.mapPanelList[mapID].SetActive(false);
        }
    }
    public void ClickMapSwitchButton()
    {
        MapAreaManager.Instance.New_Level_Select(mapID);
    }

    public void SetRateOpen()
    {
        openRatio = PlayerPrefs.GetFloat("shopprogressfill" + mapID.ToString());
        mapRoomUI.shopRatio.fillAmount = openRatio;
        mapRoomUI.ratioText.text = ((int)(openRatio * 100)).ToString() + "/100";
        mapRoomUI.incomeText.text = "$" + totalIncome.ToString();
        mapRoomUI.incomeText2.text = (mapSettings._pricePerPeriod * 60 / MapAreaManager.Instance.timePeriodMinute).ToString() + "/h";


        if(PlayerPrefs.GetInt("level") == mapID)
        {
            mapRoomUI.youAreHere_GO.SetActive(true);
        }
        else
        {
            mapRoomUI.youAreHere_GO.SetActive(false);
        }
    }


    public void DropMoney(int totalMoney)
    {
        StartCoroutine(DroppingMoney(totalMoney));
    }
    IEnumerator DroppingMoney(int totalMoney)
    {
        int stepNo = 0;

        int moneyListCount = moneyArea.moneyList.Count;
        int newMoneyCount = totalMoney - moneyListCount;
        int maxOfflineCount = mapSettings._maxOfflineEarning / mapSettings._pricePerPeriod;
        if (newMoneyCount > maxOfflineCount)
        {
            newMoneyCount = maxOfflineCount;
        }
        newMoneyCount *= mapSettings._pricePerPeriod;
        
        for (int i = 0; i < newMoneyCount; i++)
        {
            float deltaY = 0;
            deltaY = (moneyListCount + i) / moneyArea.dropMoneyPosList.Count;
            Transform targetTR = moneyArea.dropMoneyPosList[(moneyListCount + i) % moneyArea.dropMoneyPosList.Count];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.2f, 0);
            BanknotMoney banknot = Instantiate(moneyArea.moneyPrefab, moneyArea.firstMoneyCreatePosTR.position, Quaternion.identity).GetComponent<BanknotMoney>();
            banknot.MovingMoney(moneyArea.firstMoneyCreatePosTR.position, dropPos, targetTR);
            banknot.banknotValue = 1;
            moneyArea.moneyList.Add(banknot);
            totalIncome += 1;
            stepNo++;
            if (stepNo % 50 == 0)
            {
                yield return null;
            }
        }
        mapRoomUI.incomeText.text = "$" + totalIncome.ToString();

    }
    int totalIncome = 0;
    public void MoneySave()
    {
        PlayerPrefs.SetInt("offlinecountmap" + mapID.ToString(), 0);
        totalIncome = 0;
        mapRoomUI.incomeText.text = "$" + totalIncome.ToString();
    }
}
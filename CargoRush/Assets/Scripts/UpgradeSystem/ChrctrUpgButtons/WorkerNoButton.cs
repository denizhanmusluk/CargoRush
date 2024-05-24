using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerNoButton : WorkerUpgradeButton
{
    public override void UpgradeValueTextInit(float currentRange, float upRange)
    {
        //upgradeValue.text = ((int)currentRange).ToString() + "s" + " -> " + ((int)upRange).ToString() + "s";
    }
    public override void UpgradeValueFull(float currentRange)
    {
        //upgradeValue.text = "MAX";
        moneyIMG.gameObject.SetActive(false);
    }
    public List<GameObject> barList;
    public List<GameObject> infoList;

    public override void ButtonLevel(int currentLvl)
    {
        levelText.text = currentLvl.ToString();
        //Debug.Log("Globals.machineLevel  " + PlayerPrefs.GetInt("machineLevel") + "  " + currentLvl);
        //for (int i = 0; i < currentLvl; i++)
        //{
        //    barList[i].SetActive(false);
        //    infoList[i].SetActive(false);
        //}
        //barList[currentLvl].SetActive(true);

        //if(currentLvl > PlayerPrefs.GetInt("machineLevel") + 1)
        //{
        //    infoList[currentLvl].SetActive(true);
        //    moneyButton.gameObject.SetActive(false);
        //}
        //else
        //{
        //    infoList[currentLvl].SetActive(false);
        //    moneyButton.gameObject.SetActive(true);
        //}
    }
}

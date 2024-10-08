using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class StackCapacityUpgradeButton : UpgradeButton
{
    public override void UpgradeValueTextInit(float currentRange, float upRange)
    {
        //upgradeValue.text = ((int)currentRange).ToString() + "s" + " -> " + ((int)upRange).ToString() + "s";
        if (PlayerPrefs.GetInt("upgradetutorial") != 0)
        {
            advButton.gameObject.SetActive(true);
        }
    }
    public override void UpgradeValueFull(float currentRange)
    {
        //upgradeValue.text = "MAX";
        moneyIMG.gameObject.SetActive(false);
    }
    public List<GameObject> barList;

    public override void ButtonLevel(int currentLvl , int maxLevel)
    {
        levelText.text = currentLvl.ToString();
        levelMaxText.text = "/" + maxLevel.ToString();

        //if (currentLvl > 0)
        //{
        //    for (int i = 0; i < currentLvl; i++)
        //    {
        //        barList[i].SetActive(true);
        //    }
        //}
    }
}

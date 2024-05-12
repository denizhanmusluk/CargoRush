using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HoleTimeUpgradeButton : UpgradeButton
{
    public override void UpgradeValueTextInit(float currentRange, float upRange)
    {
        upgradeValue.text = ((int)currentRange).ToString() + "s" + " -> " + ((int)upRange).ToString() + "s";
    }
    public override void UpgradeValueFull(float currentRange)
    {
        upgradeValue.text = "";
    }
    public List<GameObject> barList;

    public override void ButtonLevel(int currentLvl)
    {
        levelText.text = "Lv. " + (currentLvl + 1).ToString();
        //if (currentLvl > 0)
        //{
        //    for (int i = 0; i < currentLvl; i++)
        //    {
        //        barList[i].SetActive(true);
        //    }
        //}
    }
}

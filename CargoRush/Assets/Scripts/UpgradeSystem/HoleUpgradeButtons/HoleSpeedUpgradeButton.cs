using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleSpeedUpgradeButton : UpgradeButton
{
    public override void UpgradeValueTextInit(float currentSpeed, float upSpeed)
    {
        currentSpeed = MathF.Round(currentSpeed, 2, MidpointRounding.ToEven);
        upSpeed = MathF.Round(upSpeed, 2, MidpointRounding.ToEven);

        upgradeValue.text = (currentSpeed).ToString() + " -> " + (upSpeed).ToString();
    }
    public override void UpgradeValueFull(float currentSpeed)
    {
        upgradeValue.text = "";
    }
    public List<GameObject> barList;

    public override void ButtonLevel(int currentLvl, int maxLevel)
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

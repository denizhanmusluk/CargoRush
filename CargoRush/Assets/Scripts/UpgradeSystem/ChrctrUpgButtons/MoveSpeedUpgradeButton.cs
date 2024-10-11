using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MoveSpeedUpgradeButton : UpgradeButton
{
    public override void UpgradeValueTextInit(float currentSpeed, float upSpeed)
    {
        currentSpeed = MathF.Round(currentSpeed, 2, MidpointRounding.ToEven);
        upSpeed = MathF.Round(upSpeed, 2, MidpointRounding.ToEven);
  
        //upgradeValue.text = (currentSpeed).ToString() + " -> " + (upSpeed).ToString();
    }
    public override void UpgradeValueFull(float currentSpeed)
    {
        //upgradeValue.text = "MAX";
        moneyIMG.gameObject.SetActive(false);
    }
    public List<GameObject> barList;

    public override void ButtonLevel(int currentLvl , int maxLevel)
    {
        levelText.text = currentLvl.ToString();
        levelMaxText.text = "/" + maxLevel.ToString();
        upgradeSlider.fillAmount = (float)currentLvl / (float)maxLevel;

        //if (currentLvl > 0)
        //{
        //    for (int i = 0; i < currentLvl; i++)
        //    {
        //        barList[i].SetActive(true);
        //    }
        //}
    }
}

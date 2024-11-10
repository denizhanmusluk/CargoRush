using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCapacityUpgradeButton : UpgradeButton
{
    public override void UpgradeValueTextInit(float currentSpeed, float upSpeed)
    {
        currentSpeed = MathF.Round(currentSpeed, 2, MidpointRounding.ToEven);
        upSpeed = MathF.Round(upSpeed, 2, MidpointRounding.ToEven);
    }
    public override void UpgradeValueFull(float currentSpeed)
    {
        moneyIMG.gameObject.SetActive(false);
    }
    public override void ButtonLevel(int currentLvl, int maxLevel)
    {
        levelText.text = currentLvl.ToString();
        levelMaxText.text = "/" + maxLevel.ToString();
        upgradeSlider.fillAmount = (float)currentLvl / (float)maxLevel;
    }
}

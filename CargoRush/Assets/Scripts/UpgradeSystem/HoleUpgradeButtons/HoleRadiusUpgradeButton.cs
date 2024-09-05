using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleRadiusUpgradeButton : UpgradeButton
{
    public override void UpgradeValueTextInit(float currentRadius, float uptRadius)
    {
        currentRadius = MathF.Round(currentRadius, 2, MidpointRounding.ToEven);
        uptRadius = MathF.Round(uptRadius, 2, MidpointRounding.ToEven);

        //string _currentPlayerMoney;
        //string _upPlayerMoney;

        //if (currentPlayerMoney < 1)
        //{
        //    _currentPlayerMoney = ((float)(currentPlayerMoney * 100)).ToString() + "¢";
        //}
        //else
        //{
        //    _currentPlayerMoney = ((int)(currentPlayerMoney)).ToString() + "$";

        //}
        //if (upPlayerMoney < 1)
        //{
        //    _upPlayerMoney = ((int)(upPlayerMoney * 100)).ToString() + "¢";
        //}
        //else
        //{
        //    _upPlayerMoney = ((int)(upPlayerMoney)).ToString() + "$";

        //}
        upgradeValue.text = currentRadius.ToString() + " -> " + uptRadius.ToString();
    }

    public override void UpgradeValueFull(float currentPlayerMoney)
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

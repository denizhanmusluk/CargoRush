using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MagnetRadiusUpgradeButton : UpgradeButton
{
    public override void UpgradeValueTextInit(float currentRadius, float uptRadius)
    {
        currentRadius = MathF.Round(currentRadius, 2, MidpointRounding.ToEven);
        uptRadius = MathF.Round(uptRadius, 2, MidpointRounding.ToEven);
        upgradeValue.text = currentRadius.ToString() + " -> " + uptRadius.ToString();
    }
    public override void UpgradeValueFull(float currentPlayerMoney)
    {
        upgradeValue.text = "";
    }
    public List<GameObject> barList;

    public override void ButtonLevel(int currentLvl , int maxLevel)
    {
        if(currentLvl > 0)
        {
            for(int i = 0; i < currentLvl; i++)
            {
                barList[i].SetActive(true);
            }
        }
    }
}

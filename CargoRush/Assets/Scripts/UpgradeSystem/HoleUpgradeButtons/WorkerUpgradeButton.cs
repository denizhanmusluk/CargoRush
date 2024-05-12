using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public abstract class WorkerUpgradeButton : MonoBehaviour
{
    public Button moneyButton;
    public Image moneyIMG;
    public GameObject tutorialGO;

    public TextMeshProUGUI levelText, costText, upgradeValue;
    public abstract void UpgradeValueTextInit(float currentValue, float upValue);
    public abstract void UpgradeValueFull(float currentValue);
    public abstract void ButtonLevel(int currentLvl);

    public void TextInit(int level, int cost)
    {
        //levelText.text = "Lv. " + (level + 1).ToString();
        costText.text = "$" + CoefficientTransformation.Converter(cost);
        if(cost == 0)
        {
            costText.text = "FREE";
        }
    }
    public void FullLevel()
    {
        //levelText.text = "Max. ";
        //levelText.fontSize = 80;
        //levelText.transform.localPosition = new Vector3(0, -186, 0);
        costText.text = "MAX";
    }
}

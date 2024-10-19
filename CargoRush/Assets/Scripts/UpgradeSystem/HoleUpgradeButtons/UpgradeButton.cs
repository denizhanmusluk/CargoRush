using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public abstract class UpgradeButton : MonoBehaviour
{
    public Button moneyButton;
    public Button advButton;

    public Image moneyIMG;
    public GameObject tutorialGO;

    public TextMeshProUGUI levelText, costText, upgradeValue, levelMaxText;
    public Image upgradeSlider;
    public abstract void UpgradeValueTextInit(float currentValue, float upValue);
    public abstract void UpgradeValueFull(float currentValue);
    public abstract void ButtonLevel(int currentLvl , int maxLevel);

    public void TextInit(int level,int cost)
    {
        //levelText.text = "Lv. " + (level + 1).ToString();
        costText.text = "$" + CoefficientTransformation.Converter(cost);
        if (cost == 0)
        {
            costText.text = "FREE";
        }
        if (cost < 10000)
        {
            costText.fontSize = 55;
        }
        else
        {
            costText.fontSize = 45;
        }
    }
    public void FullLevel()
    {
        //levelText.text = "Max. ";
        //levelText.fontSize = 80;
        //levelText.transform.localPosition = new Vector3(0, -186, 0);
        costText.text = "MAX";
        costText.transform.localPosition = new Vector3(0, costText.transform.localPosition.y, costText.transform.localPosition.z);
        advButton.gameObject.SetActive(false);

    }
    private void OnEnable()
    {
        if (PlayerPrefs.GetInt("upgradetutorial") == 0)
        {
            advButton.gameObject.SetActive(false);
        }
    }

    public void ADVButtonOpen()
    {
        advButton.gameObject.SetActive(true);
    }
}

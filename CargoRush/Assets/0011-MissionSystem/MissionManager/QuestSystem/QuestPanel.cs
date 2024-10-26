using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public abstract class QuestPanel : MonoBehaviour
{
    public QuestType questType;
    public string questTextTitle;
    public string questTextTitle2;
    public string questName;
    public TMP_Text questTitleText;
    public Image questCompleteRatio_Fill;
    public TextMeshProUGUI ratioText;
    public TextMeshProUGUI priceText;
    public Button claimButton;

    public int questPriceMoney;

    public int questTotalCount;
    public int questCurrentCount;

    public abstract void UpdateQuest(int increaseAmount);
    public abstract void QuestInitialize();

    public GameObject tutorialGO;

    void Start()
    {
        questCurrentCount = PlayerPrefs.GetInt(questName + "questCurrentCount" + PlayerPrefs.GetInt("dailyQuestNo", 0), 0);


        if (PlayerPrefs.GetInt(questName + "missionactive" + PlayerPrefs.GetInt("dailyQuestNo", 0)) == 0) // görevi baþlat
        {
            PlayerPrefs.SetInt(questName + "missionactive" + PlayerPrefs.GetInt("dailyQuestNo", 0), 1);
        }


        if (PlayerPrefs.GetInt(questName + "missionactive" + PlayerPrefs.GetInt("dailyQuestNo", 0)) == 2) // görev tamamlanmýþsa
        {
            QuestCompleted();
        }

        if (PlayerPrefs.GetInt(questName + "missionactive" + PlayerPrefs.GetInt("dailyQuestNo", 0)) == 3) // görev tamamlanmýþ ve parasý alýnmýþsa
        {
            QuestCompleteAndDeactive();
        }
        //string coloredText = "<color=#000000>Tape </color><color=#0000FF>5</color><color=#000000> Box</color>";

        // TextMeshPro GUI textini ayarla
        QuestInitialize();
        QuestManager.Instance.QuestInit(questType,this);
    }

  
    public void QuestUpdate(int increaseAmount)
    {
        UpdateQuest(increaseAmount);
    }

    public void QuestCompleted()
    {
        claimButton.interactable = true;
        QuestManager.Instance.TaskCompletePopUp();

        if (PlayerPrefs.GetInt("missiontutorial") == 0)
        {
            PlayerPrefs.SetInt("missiontutorial", 1);
            QuestManager.Instance.OpenPanelButton();
            IndicatorManager.Instance.TutorialStepStart(91);

            if (tutorialGO != null)
            {
                tutorialGO.SetActive(true);
            }
        }
        transform.SetSiblingIndex(0);
    }

    void QuestCompleteAndDeactive()
    {
        claimButton.interactable = false;

        Transform parentTransform = transform.parent;
        transform.SetSiblingIndex(parentTransform.childCount - 1);
        StartCoroutine(SelfClose_Delay());
    }
    IEnumerator SelfClose_Delay()
    {
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
    }
    public void ClickPriceButton()
    {
        PlayerPrefs.SetInt(questName + "missionactive" + PlayerPrefs.GetInt("dailyQuestNo", 0), 3);
        QuestCompleteAndDeactive();
        GameManager.Instance.ui.MoneyCreateQuestReward(questPriceMoney, claimButton.transform.position);
        GameManager.Instance.ui.GemCreate(1);
        if (PlayerPrefs.GetInt("missiontutorial") == 1)
        {
            PlayerPrefs.SetInt("missiontutorial", 2);
            IndicatorManager.Instance.TutorialStepCompleted();
        }

        if (tutorialGO != null)
        {
            tutorialGO.SetActive(false);
        }

        QuestManager.Instance.questParticle_GO.SetActive(false);
        QuestManager.Instance.questTick_GO.SetActive(false);

    }
}

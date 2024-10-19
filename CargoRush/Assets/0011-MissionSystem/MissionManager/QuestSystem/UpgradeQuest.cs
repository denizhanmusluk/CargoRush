using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeQuest : QuestPanel
{
    public override void UpdateQuest(int increaseAmount)
    {
        if (PlayerPrefs.GetInt(questName + "missionactive" + PlayerPrefs.GetInt("dailyQuestNo", 0)) == 1) // görev aktifse
        {
            questCurrentCount += increaseAmount;
            PlayerPrefs.SetInt(questName + "questCurrentCount" + PlayerPrefs.GetInt("dailyQuestNo", 0), questCurrentCount);
            QuestInitialize();
            if (questCurrentCount >= questTotalCount)
            {
                PlayerPrefs.SetInt(questName + "missionactive" + PlayerPrefs.GetInt("dailyQuestNo", 0), 2);
                QuestCompleted();
                if (QuestManager.Instance.questCompleteQuest != null)
                {
                    QuestManager.Instance.questCompleteQuest.QuestUpdate(1);
                }
            }
        }
    }

    public override void QuestInitialize()
    {
        questCompleteRatio_Fill.fillAmount = (float)questCurrentCount / (float)questTotalCount;
        ratioText.text = "%" + ( (int)(  ((float)questCurrentCount / (float)questTotalCount) * 100)  ).ToString();

        string coloredText = $"<color=#000000>{questTextTitle}</color> <color=#0DB3FF>{questTotalCount}</color> <color=#000000>{questTextTitle2}</color>";
        questTitleText.text = coloredText;

        priceText.text = $"${questPriceMoney}";
    }
}

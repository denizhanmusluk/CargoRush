using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using HomaGames.HomaBelly;
public enum QuestType
{
    MoneyEarnQuest,
    UpgradeQuest,
    OrderQuest,
    SpecialOrderQuest,
    BoosterQuest,
    BuyWorkerQuest,
    NewMapQuest,
    CompanySeqUpQuest,
    ShareValueIncreaseQuest,
    TapeBox
}
public class QuestManager : MonoBehaviour
{
    private static QuestManager _instance = null;
    public static QuestManager Instance => _instance;
    public QuestSettings questSettings;
    [SerializeField] int timePeriodHour = 10;
    public TextMeshProUGUI newQuestTime_Text;

    [SerializeField] GameObject questPanel_GO;
    [SerializeField] GameObject questButton;
    [SerializeField] GameObject questCloseButton;
    public Transform questContainer_TR;

    private int dailyQuestLevel = 0;
    public List<QuestPanel> questPanels = new List<QuestPanel>();
    public Animator taskCompleteAnim;
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        StartCoroutine(CheckTime());
        DailyQuestStart();

        if (PlayerPrefs.GetInt("missionbuttonopen") == 1)
        {
            OpenPanelButton();
        }
    }
    public void OpenPanelButton()
    {
        PlayerPrefs.SetInt("missionbuttonopen", 1);
        questButton.gameObject.SetActive(true);
    }
    IEnumerator CheckTime()
    {
        yield return new WaitForSeconds(6);
        while (true)
        {
            CheckAndSaveQuestDateTime();
            yield return new WaitForSeconds(10);
        }
    }

    void CheckAndSaveQuestDateTime()
    {
        System.DateTime currentDateTime = System.DateTime.Now;
        string savedDateTime = PlayerPrefs.GetString("savedQuestTime", string.Empty);

        string newQuestTimeString = $"{timePeriodHour}s 00m";


        if (!string.IsNullOrEmpty(savedDateTime))
        {
            System.DateTime savedDateTimeParsed = System.DateTime.Parse(savedDateTime);
            System.TimeSpan timeDifference = currentDateTime - savedDateTimeParsed;

            if (timeDifference.TotalHours >= timePeriodHour)
            {
                dailyQuestLevel = PlayerPrefs.GetInt("dailyQuestNo", 0);
                dailyQuestLevel++;
                PlayerPrefs.SetInt("dailyQuestNo", dailyQuestLevel);


                PlayerPrefs.SetString("savedQuestTime", currentDateTime.ToString("dd/MM/yyyy HH:mm"));
                PlayerPrefs.Save();

                UpdateDailyQuest();
                string tag = $"DM_Day{dailyQuestLevel}Complated";
                Analytics.DesignEvent(tag);
            }

            int countDownHour = timePeriodHour * 60 - (int)timeDifference.TotalMinutes;
            newQuestTimeString = ConvertSecondToMinSec.ConverterMinAndHour(countDownHour);
        }
        else
        {
            PlayerPrefs.SetString("savedQuestTime", currentDateTime.ToString("dd/MM/yyyy HH:mm"));
            PlayerPrefs.Save();
        }
        newQuestTime_Text.text = newQuestTimeString;
    }
  
    public void ClickPanelOpen()
    {
        questPanel_GO.SetActive(true);
        questButton.SetActive(false);
        questCloseButton.SetActive(true);
        PlayerController.Instance.PlayerControlDeActive();
        StartCoroutine(PanelDown());


        if (PlayerPrefs.GetInt("missiontutorial") == 1)
        {
            IndicatorManager.Instance.TutorialStepCompleted();
            IndicatorManager.Instance.TutorialStepStart(92);
        }
    }
    public void ClickPanelClose()
    {
        //questPanel_GO.SetActive(false);
        questButton.SetActive(true);
        questCloseButton.SetActive(false);
        PlayerController.Instance.PlayerControl_ReActive();
        StartCoroutine(PanelUp());
    }
    IEnumerator PanelDown()
    {
        Vector3 downPos = new Vector3(questPanel_GO.transform.localPosition.x, 0, questPanel_GO.transform.localPosition.z);
        Vector3 upPos = new Vector3(questPanel_GO.transform.localPosition.x, 2000, questPanel_GO.transform.localPosition.z);
        float counter = 0f;
        while(counter < 1f)
        {
            counter += 4 * Time.deltaTime;
            questPanel_GO.transform.localPosition = Vector3.Lerp(upPos, downPos, counter);
            yield return null;
        }
    }

    IEnumerator PanelUp()
    {
        Vector3 downPos = new Vector3(questPanel_GO.transform.localPosition.x, 0, questPanel_GO.transform.localPosition.z);
        Vector3 upPos = new Vector3(questPanel_GO.transform.localPosition.x, 2000, questPanel_GO.transform.localPosition.z);
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 4 * Time.deltaTime;
            questPanel_GO.transform.localPosition = Vector3.Lerp(downPos, upPos, counter);
            yield return null;
        }
    }
    void UpdateDailyQuest()
    {
        DailyQuestStart();
    }
    void DailyQuestStart()
    {
        dailyQuestLevel = PlayerPrefs.GetInt("dailyQuestNo", 0);

        if (questPanels.Count > 0)
        {
            foreach (var qst in questPanels)
            {
                Destroy(qst.gameObject);
            }
            questPanels.Clear();
        }


        for(int i = 0; i < questSettings._quaestData[dailyQuestLevel].questPrefab.Length;i++)
        {
            QuestPanel questPanel = Instantiate(questSettings._quaestData[dailyQuestLevel].questPrefab[i], questContainer_TR).GetComponent<QuestPanel>();
            questPanels.Add(questPanel);
            questPanel.questPriceMoney = questSettings._quaestData[dailyQuestLevel].priceMoney[i];
            questPanel.questTotalCount = questSettings._quaestData[dailyQuestLevel].totalCount[i];

        }
    }
    public QuestPanel moneyEarningQuest;
    public QuestPanel upgradeQuest;
    public QuestPanel orderQuest;
    public QuestPanel orderSpecialQuest;
    public QuestPanel boosterQuest;
    public QuestPanel buyWorkerQuest;
    public QuestPanel newMapQuest;
    public QuestPanel companySeqUpQuest;//
    public QuestPanel shareValueIncreaseQuest;//
    public QuestPanel tapeBoxQuest;
    public void QuestInit(QuestType questType,QuestPanel questPanel)
    {
        switch (questType)
        {
            case QuestType.MoneyEarnQuest:
                {
                    moneyEarningQuest = questPanel;
                }
                break;
            case QuestType.UpgradeQuest:
                {
                    upgradeQuest = questPanel;
                }
                break;
            case QuestType.OrderQuest:
                {
                    orderQuest = questPanel;
                }
                break;
            case QuestType.SpecialOrderQuest:
                {
                    orderSpecialQuest = questPanel;
                }
                break;

            case QuestType.BoosterQuest:
                {
                    boosterQuest = questPanel;
                }
                break;

            case QuestType.BuyWorkerQuest:
                {
                    buyWorkerQuest = questPanel;
                }
                break;
            case QuestType.NewMapQuest:
                {
                    newMapQuest = questPanel;
                }
                break;
            case QuestType.CompanySeqUpQuest:
                {
                    companySeqUpQuest = questPanel;
                }
                break;
            case QuestType.ShareValueIncreaseQuest:
                {
                    shareValueIncreaseQuest = questPanel;
                }
                break;
            case QuestType.TapeBox:
                {
                    tapeBoxQuest = questPanel;
                }
                break;
        }
    }

    public void TaskCompletePopUp()
    {
        StartCoroutine(TaskCompletePopUp_Delay());
    }
    IEnumerator TaskCompletePopUp_Delay()
    {
        taskCompleteAnim.gameObject.SetActive(true);
        taskCompleteAnim.SetBool("openactive", true);
        yield return new WaitForSeconds(2f);
        taskCompleteAnim.SetBool("openactive", false);

        yield return new WaitForSeconds(1f);
        taskCompleteAnim.gameObject.SetActive(false);
    }
}
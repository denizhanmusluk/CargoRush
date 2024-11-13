using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using ObserverSystem;
using HomaGames.HomaBelly;
using GameAnalyticsSDK;

public class GameManager : Observer
{
    private static GameManager _instance = null;
    public static GameManager Instance => _instance;

    public LevelManager lvlManager;
    public UIManager ui;
    float firstTime;
    public int firstLevelPartCount;
    [SerializeField] int createMoney;
    [SerializeField] int createMoney2;
    [SerializeField] int createTicket;

    //public void ItemUpgraded(ItemType itemType, string itemID, int itemLevel, Reason reason, string reference)
    //{

    //}

    public void GameAnalyticsTag(string tagTitle)
    {
        //GameAnalytics.NewDesignEvent(tag);
        Analytics.DesignEvent(tagTitle);
        //Analytics.DesignEvent("start_flying_section", new DesignDimensions($"level_{levelId}", character_name, score: level_playtime));
        Debug.Log(tagTitle);
    }
    public void HomaAnalyticsTag(string tagTitle)
    {
        Analytics.DesignEvent(tagTitle);
    }
    public void HomaAnalyticsTag(string tagTitle,int levelId)
    {
        Analytics.DesignEvent(tagTitle, new DesignDimensions($"level_{levelId}"));
    }
    public void HomaAnalyticsTag(string tagTitle, int levelId,int upgradeLevel)
    {
        Analytics.DesignEvent(tagTitle, new DesignDimensions($"level_{levelId}" , $"upgradeLevel_{upgradeLevel}"));
    }
    public void CourierLevelStartedAnalytic(int lvlId)
    {
        //Analytics.LevelStarted(lvlId);
    }
    public List<int> attemptNumber = new List<int>();
    public List<int> attemptVipNumber = new List<int>();
    public void CourierLevelCompleted(int orderId)
    {
        //Analytics.LevelCompleted();
        int deliveryCompCount = PlayerPrefs.GetInt("deliverycompletedcount");
        int deliveryComp_Rank = PlayerPrefs.GetInt("deliverycompletedrank");

        deliveryCompCount++;
        PlayerPrefs.SetInt("deliverycompletedcount", deliveryCompCount);
        if (deliveryComp_Rank < attemptNumber.Count)
        {
            if (deliveryCompCount == attemptNumber[deliveryComp_Rank])
            {
                deliveryComp_Rank++;
                PlayerPrefs.SetInt("deliverycompletedrank", deliveryComp_Rank);


                int levelId = PlayerPrefs.GetInt("level") + 1;
                Analytics.DesignEvent(orderId.ToString() + "_Order_Complated ", new DesignDimensions($"Zone_{levelId}"));

                Debug.Log(orderId.ToString() + "_Order_Complated");
            }
        }
        else
        {
            int levelId = PlayerPrefs.GetInt("level") + 1;
            Analytics.DesignEvent(orderId.ToString() + "_Order_Complated ", new DesignDimensions($"Zone_{levelId}"));

            Debug.Log(orderId.ToString() + "_Order_Complated");
        }
    }

    public void VipCourierLevelCompleted(int orderId)
    {
        //Analytics.LevelCompleted();
        int deliveryCompCount = PlayerPrefs.GetInt("vipdeliverycompletedcount");
        int deliveryComp_Rank = PlayerPrefs.GetInt("vipdeliverycompletedrank");

        deliveryCompCount++;
        PlayerPrefs.SetInt("vipdeliverycompletedcount", deliveryCompCount);
        if (deliveryComp_Rank < attemptVipNumber.Count)
        {
            if (deliveryCompCount == attemptVipNumber[deliveryComp_Rank])
            {
                deliveryComp_Rank++;
                PlayerPrefs.SetInt("vipdeliverycompletedrank", deliveryComp_Rank);


                int levelId = PlayerPrefs.GetInt("level") + 1;
                Analytics.DesignEvent(orderId.ToString() + "Vip_Order_Complated ", new DesignDimensions($"Zone_{levelId}"));

                Debug.Log(orderId.ToString() + "Vip_Order_Complated");
            }
        }
        else
        {
            int levelId = PlayerPrefs.GetInt("level") + 1;
            Analytics.DesignEvent(orderId.ToString() + "Vip_Order_Complated ", new DesignDimensions($"Zone_{levelId}"));

            Debug.Log(orderId.ToString() + "Vip_Order_Complated");

        }
    }
    void Awake()
    {
        Globals.moneyAmount = PlayerPrefs.GetInt("money");
        Globals.gemAmount = PlayerPrefs.GetInt("gem");

        if (Globals.gemAmount > 0)
        {
            ui.gemPanel.SetActive(true);
        }
        //if (PlayerPrefs.GetInt("money") != 0)
        //{
        //    Globals.moneyAmount = PlayerPrefs.GetInt("money");
        //}
        //else
        //{
        //    PlayerPrefs.SetInt("money", Globals.moneyAmount);
        //}

        firstTime = Time.timeScale;
        InitConnections();

        _instance = this;

        lvlManager.levelInit();

    }
    void InitConnections()
    {
        ui.OnLevelStart += OnLevelStart;
        ui.OnNextLevel += OnNextLevel;
        ui.OnLevelRestart += OnLevelRestart;
        ui.OnGamePaused += onLevelPause;
        ui.OnGameResume += onLevelResume;
    }

    void Start()
    {
        Analytics.GameplayStarted();

        UnityEngine.Rendering.GraphicsSettings.useScriptableRenderPipelineBatching = true;
        //DefaultAnalytics.GameplayStarted();
        Application.targetFrameRate = 60;
        ui.moneyText.text = CoefficientTransformation.Converter(Globals.moneyAmount);
        ui.moneyTextShop.text = CoefficientTransformation.Converter(Globals.moneyAmount);
        ui.moneyTextMap.text = CoefficientTransformation.Converter(Globals.moneyAmount);
        ui.gemText.text = CoefficientTransformation.Converter(Globals.gemAmount);
        ui.gemTextShop.text = CoefficientTransformation.Converter(Globals.gemAmount);

        //ui.startCanvas.SetActive(true);
        //ui.finishCanvas.SetActive(false);
        //ui.failCanvas.SetActive(false);
        //// Observer Register
        ObserverManager.Instance.RegisterObserver(this, SubjectType.GameState);//observer register
                                                                               //StartCoroutine(StartDelayed());

        int levelIndex = PlayerPrefs.GetInt("levelIndex");
        string levelId = levelIndex.ToString();
        //DefaultAnalytics.LevelStarted(levelId);
        StartCoroutine(StartDelayed());
    }
    IEnumerator StartDelayed()
    {
        yield return new WaitForSeconds(10);
        Globals.loadingPanelActive = false;
        Globals.gamePlayStarting = true;
    }
    public void GetMoney(int moneyAmount)
    {
        MoneyUpdate(moneyAmount);
    }
    //public void GetMoney2()
    //{
    //    MoneyUpdate(createMoney2);
    //}
    public void GetTicket()
    {
        GemUpdate(createTicket);
    }
    void OnLevelStart()
    {
        ui.startCanvas.SetActive(false);
        //ui.ingameCanvas.SetActive(true);
        ui.joyStick.GetComponent<FloatingJoystick>().FirstClick();
    }
    void OnNextLevel()
    {
        Globals.currentLevel++;
        PlayerPrefs.SetInt("levelIndex", Globals.currentLevel);

        Globals.currentLevelIndex++;
        if (Globals.LevelCount - 1 < Globals.currentLevelIndex)
        {
            Globals.currentLevelIndex = Random.Range(0, Globals.LevelCount - 1);
            PlayerPrefs.SetInt("level", Globals.currentLevelIndex);
        }
        else
        {
            PlayerPrefs.SetInt("level", Globals.currentLevelIndex);
        }


        int levelIndex = PlayerPrefs.GetInt("levelIndex");
        string levelId = levelIndex.ToString();
        //GameAnalytics.NewDesignEvent("LevelReached" + ":" + levelId + " in " + PlayerPrefs.GetInt("tryingcount") + " attempts");
        Debug.Log("LevelReached" + ":" + levelId + " in " + PlayerPrefs.GetInt("tryingcount") + " attempts");

        PlayerPrefs.SetInt("tryingcount" , 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void OnLevelRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }  
    public void onLevelPause()
    {
        Time.timeScale = 0;
    }
    public void onLevelResume()
    {
        Time.timeScale = firstTime;
    }
    ///////////////////////////////////////////////////

    private void Update()
    {
        //Debug.Log(Globals.gamePlayStarting);

        //if (Input.GetKeyDown(KeyCode.X))
        //{
        //    ObserverManager.Instance.RemoveObserver(this);//observer register
        //}
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    MoneyUpdate(createMoney);
        //}
        //if (Input.GetKeyDown(KeyCode.G))
        //{
        //    GemUpdate(createTicket);
        //}
        //if (Input.GetKeyDown(KeyCode.H))
        //{
        //    PlayerPrefs.SetInt("holeLevel", 0);
        //    PlayerPrefs.SetInt("holeSpeedLevel", 0);
        //    PlayerPrefs.SetInt("holeTimeLevel", 0);
        //}
    }

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.W))
    //    {
    //        Notify_WinObservers();
    //    }

    //    if (Input.GetKeyDown(KeyCode.F))
    //    {
    //        Notify_LoseObservers();
    //    }

    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        MoneyUpdate(1000);
    //    }
    //}
    public void StartState()
    {
    }
    public void FinalState()
    {
    }
    public void failLevelbutton()
    {
        PlayerPrefs.SetInt("levelIndex", Globals.currentLevel);    
        PlayerPrefs.SetInt("level", Globals.currentLevelIndex);
    }
  
    public void FailState()
    {
        //PlayerPrefs.SetInt("tryingcount", PlayerPrefs.GetInt("tryingcount") + 1);
        ui.tachometerPanelGO.SetActive(false);
        //ui.failCanvas.SetActive(true);
        //DefaultAnalytics.LevelFailed();
    }
 
    public void WinState()
    {
        //Globals.tempAttemptCount = PlayerPrefs.GetInt("tryingcount");
        ui.tachometerPanelGO.SetActive(false);
        //ui.finishCanvas.SetActive(true);
        //ui.NextLevelButton();
        PlayerPrefs.DeleteAll();

        PlayerPrefs.SetInt("levelIndex", Globals.currentLevel);
        PlayerPrefs.SetInt("level", Globals.currentLevelIndex);
        PlayerPrefs.SetInt("gameopened", 1);
        PlayerPrefs.SetInt("upgradebg", 1);
        PlayerPrefs.SetInt("upgrade", 1);
        //PlayerPrefs.SetInt("tryingcount", Globals.tempAttemptCount);

        //PlayerPrefs.SetInt("money", Globals.moneyAmount);
        Globals.moneyAmount = 100;
        PlayerPrefs.SetInt("money", Globals.moneyAmount);

        //DefaultAnalytics.LevelCompleted();

      
    }
    public void MoneyUpdate(int miktar)
    {
        ui.MoneyUpdate(miktar);

        if (QuestManager.Instance.moneyEarningQuest != null)
        {
            QuestManager.Instance.moneyEarningQuest.QuestUpdate(miktar);
        }
    }
    public void GemUpdate(int miktar)
    {
        ui.GemUpdate(miktar);
    }

    //// Observer Notify
    public override void OnNotify(NotificationType notificationType) //observer notify
    {
        switch (notificationType)
        {
            case NotificationType.Start:
                {
                    StartState();
                }
                break;
            case NotificationType.End:
                {

                }
                break;
            case NotificationType.Win:
                {
                    Invoke("WinState", 1);
                    Debug.Log("win");
                }
                break;
            case NotificationType.Fail:
                {
                    Invoke("FailState", 2);
                    Debug.Log("fail");
                }
                break;
       
        }
    }
    public Material mat1;
    public Material mat2;
    public Texture normalTexture1;
    public Texture outlineTexture1;

    public Texture normalTextureTaped;
    public Texture outlineTextureTaped;
    bool outline = false;
    public void SwitchTexture()
    {
        if (!outline)
        {
            outline = true;
            mat1.SetTexture("_BaseMap", outlineTexture1);
            mat2.SetTexture("_BaseMap", outlineTextureTaped);
        }
        else
        {
            outline = false;
            mat1.SetTexture("_BaseMap", normalTexture1);
            mat2.SetTexture("_BaseMap", normalTextureTaped);
        }
    }

    public void CheatIS()
    {
        DayCycleManager.Instance.firstInterstialTimeCounter = DayCycleManager.Instance.iSSettings._firstIS_Time;
        DayCycleManager.Instance.dayCycleCount = DayCycleManager.Instance.iSSettings._period_IS;
    }
    public void CheatRewarded()
    {
        SkillManager.Instance.SpeedRewardCreate();
        SkillManager.Instance.CapacityRewardCreate();
        SkillManager.Instance.DoubleRewardCreate();
        SkillManager.Instance.MoneyRewardCreate();
        SkillManager.Instance.WorkerRewardCreate();
        SkillManager.Instance.MachineRewardCreate();
    }

    public VipCustomerSlot vipCustomerSlot;
    public void ResetVipCooldown()
    {
        vipCustomerSlot.firstVipTimeCounter = vipCustomerSlot.firstVipTime;
        vipCustomerSlot.vipCycleCount = vipCustomerSlot.vipCyclePeriod;
    }
    public void NoAds()
    {
        ADVManager.Instance.NoAds();
    }
    public void MachineErroring()
    {
        FishDropArea.Instance.MachineManuelError();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using ObserverSystem;
using UnityEngine.UI;
using DG.Tweening;
using HomaGames.HomaBelly;

public class UIManager : Subject
{
    public event Action OnLevelStart, OnNextLevel, OnLevelRestart, OnGamePaused, OnGameResume;

    [Header("Screens")]
    public GameObject moneyPanel;
    public GameObject gemPanel;
    public GameObject startCanvas;
    public GameObject ingameCanvas;
    //public GameObject panelMission;
    //public GameObject finishCanvas;
    //public GameObject failCanvas;
    public GameObject pauseMenu;
    public GameObject fullCapacityText;
    public GameObject joyStick;
    public GameObject holeTimeGO;
    public Transform moneyTarget;


    //[Header("In Game")]
    //public LevelBarDisplay levelBarDisplay;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI moneyTextShop;
    public TextMeshProUGUI gemText;
    public TextMeshProUGUI gemTextShop;

    public GameObject runnerStarter;
    public GameObject gearShiftTapGO;
    public GameObject tachometerPanelGO;

    public TextMeshProUGUI holeTimer;
    public Image holeTimerBG_Image;
    public Animator[] bigFishAnimator;
    //[Header("Finish Screen")]
    //public ScoreTextManager scoreText;


    //void Start()
    //{
    //    CheckAndDisplayStartScreen();
    //}
    public GameObject plasticOpenTextGO;
    public GameObject yarnOpenTextGO;
    public GameObject woodOpenTextGO;


    public GameObject hrBuyTextGO;
    public GameObject hrUpgradeTextGO;


    //public GameObject biggerPanelGO;
    //public TextMeshProUGUI biggerCounterText;

    //public GameObject fasterPanelGO;
    //public TextMeshProUGUI fasterCounterText;


    //public GameObject hoverboardPanelGO;
    //public TextMeshProUGUI hoverboardCounterText;

    //public GameObject capacityPanelGO;
    //public TextMeshProUGUI capacityCounterText;
    void CheckAndDisplayStartScreen()
    {
        //startCanvas.SetActive(true);
        //int displayStart = PlayerPrefs.GetInt("displayStart");
        //if(displayStart > 0)
        //{
        //    startCanvas.SetActive(true);
        //}
        //else
        //{ 
        //    StartLevel();
        //    Invoke(nameof(StartLevelButton), DEFAULT_START_DELAY);
        //    PlayerPrefs.SetInt("displayStart", 1);
        //}
    }
    private void Awake()
    {
        firstSizeMoney = moneyPanel.transform.localScale;
        firstSizeGem = gemPanel.transform.localScale;

    }

    #region Handler Functions

    public void StartLevelButton()
    {
        OnLevelStart?.Invoke();
        Notify(NotificationType.Start);
        CameraFollower.Instance.FollowStart();
        //DefaultAnalytics.GameplayStarted();
        Debug.Log("DefaultAnalytics.GameplayStarted();");
    }
    public void NextLevel()
    {
        Notify(NotificationType.Win);

    }
    public void NextLevelButton()
    {
        Globals.moneyAmount = 100;
        PlayerPrefs.SetInt("money", Globals.moneyAmount);
        //DefaultAnalytics.LevelCompleted();
        Debug.Log("DefaultAnalytics.LevelCompleted();");
        OnNextLevel?.Invoke();
    }
    public void pauseLevelButton()
    {
        OnGamePaused?.Invoke();
    }
    public void resumeLevelButton()
    {
        OnGameResume?.Invoke();
        pauseMenu.SetActive(false);
        //Globals.isGameActive = true;
    }
    public void RestartLevelButton()
    {
        //DefaultAnalytics.LevelFailed();
        Fade.Instance.Hide();
        StartCoroutine(RestartLevelButtonDelay());
    }
    IEnumerator RestartLevelButtonDelay()
    {
        yield return new WaitForSeconds(0.5f);
        OnLevelRestart?.Invoke();
    }
    #endregion

    public void StartLevel()
    {
        startCanvas.SetActive(false);
        //ingameCanvas.SetActive(true);
    }

    public void FinishLevel()
    {
        ingameCanvas.SetActive(false);
        //finishCanvas.SetActive(true);
    }

    public void FailLevel()
    {
        ingameCanvas.SetActive(false);
        //failCanvas.SetActive(true);
    }
    // Money Update with LeanTween
    //public void MoneyUpdate(int miktar)
    //{
    //    int moneyOld = Globals.moneyAmount;
    //    Globals.moneyAmount = Globals.moneyAmount + miktar;
    //    LeanTween.value(moneyOld, Globals.moneyAmount, 0.2f).setOnUpdate((float val) =>
    //    {
    //        inGameScoreText.text = ((int)val).ToString();
    //    });
    //    PlayerPrefs.SetInt("money", Globals.moneyAmount);
    //}

    // Money Update with Coroutine
    public void MoneyUpdate(int miktar)
    {
        float moneyOld = (float)Globals.moneyAmount;
        Globals.moneyAmount = Globals.moneyAmount + miktar;
        StartCoroutine(SetVal(moneyOld));

        PlayerPrefs.SetInt("money", Globals.moneyAmount);

        CharacterUpgradeManager.Instance.isEnoughMoney();
        HRUpgradeManager.Instance.isEnoughMoney();
        //HoleUpgradeManager.Instance.isEnoughMoney();
        StarPanelManager.Instance.MoneyEnoughCheck();

        //if (miktar > 0)
        //{
        //    StartCoroutine(CreateMoneyText(miktar));
        //}
    }
    IEnumerator CreateMoneyText(int miktar)
    {

        PlayerController.Instance.CreateMoneyText(miktar);
        yield return new WaitForSeconds(1f);
    }
    public void GemUpdate(int miktar)
    {
        float moneyOld = (float)Globals.gemAmount;
        Globals.gemAmount = Globals.gemAmount + miktar;
        StartCoroutine(SetGemVal(moneyOld));

        PlayerPrefs.SetInt("gem", Globals.gemAmount);

        StarPanelManager.Instance.MoneyEnoughCheck();
        gemPanel.SetActive(true);


        foreach(var rwdBtn in ADVManager.Instance.allRewardedButtons)
        {
            rwdBtn.UpdateCheckTicket();
        }
        //if(PlayerPrefs.GetInt("skinactive") == 0)
        //{
        //    //gemPanel.SetActive(true);
        //    StoreManager.Instance.storeButton.SetActive(true);
        //    StoreManager.Instance.storeButtonTapTutorialGO.SetActive(true);
        //    PlayerPrefs.SetInt("skinactive", 1);
        //}
        if(miktar < 0 && PlayerPrefs.GetInt("firstusageticket") == 0)
        {
            PlayerPrefs.SetInt("firstusageticket", 1);
            //PurchaseManager.Instance.SpecialOffer_PopUp_Open();
        }
    }
    bool gemSetActive;

    IEnumerator SetGemVal(float oldAmount)
    {
        gemSetActive = false;
        yield return null;
        yield return null;
        gemSetActive = true;
        float counter = 0f;
        int decimalCounter = 0;

        while (counter < 1f && gemSetActive)
        {
            decimalCounter++;
            counter += Time.deltaTime;
            float money = Mathf.Lerp(oldAmount, (float)Globals.gemAmount, counter);
            gemText.text = CoefficientTransformation.Converter((int)money);
            gemTextShop.text = CoefficientTransformation.Converter((int)money);
            if (decimalCounter % 15 == 0)
            {
                GemScale(0.9f, 1f, 0.25f, Ease.OutElastic);
            }
            yield return null;
        }
        gemText.text = CoefficientTransformation.Converter(Globals.gemAmount);
        gemTextShop.text = CoefficientTransformation.Converter(Globals.gemAmount);

    }
    bool moneySetActive;
    IEnumerator SetVal(float oldAmount)
    {
        moneySetActive = false;
        yield return null;
        yield return null;
        moneySetActive = true;
        float counter = 0f;
        int decimalCounter = 0;
        while (counter < 1f && moneySetActive)
        {
            decimalCounter++;
            counter += Time.deltaTime;
            float money = Mathf.Lerp(oldAmount, (float)Globals.moneyAmount, counter);
            moneyText.text =  CoefficientTransformation.Converter((int)money);
            moneyTextShop.text =  CoefficientTransformation.Converter((int)money);
            if (decimalCounter % 15 == 0 && oldAmount > 0)
            {
                MoneyScale(0.9f, 1f, 0.25f, Ease.OutElastic);
            }
            yield return null;
        }
        moneyText.text = CoefficientTransformation.Converter(Globals.moneyAmount);
        moneyTextShop.text = CoefficientTransformation.Converter(Globals.moneyAmount);

    }
    public void Fail()
    {
        Notify(NotificationType.Fail);
    }



    public GameObject moneyPrefab;
    public GameObject moneyPrefabScaleEffect;
    public Transform moneyFirstPosTR;
    public Transform moneyTargetTR;

    public GameObject ticketPrefab;

    public void MoneyCreateDailyRewarded(int moneyCount, Vector3 moneyCreatePos, bool rewardedActive)
    {
        StartCoroutine(Money_CreateRewDaily(moneyCount, moneyCreatePos, rewardedActive));
    }
    IEnumerator Money_CreateRewDaily(int moneyCount, Vector3 moneyCreatePos, bool rewardedActive)
    {
        for (int i = 0; i < moneyCount / 10; i++)
        {
            GameObject mny = Instantiate(moneyPrefabScaleEffect, moneyFirstPosTR.position, Quaternion.identity, transform);
            StartCoroutine(MoneyMoveUI_ScaleEffect(mny.transform));
            //yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(2f);

        GameManager.Instance.MoneyUpdate(moneyCount);

        if (rewardedActive)
        {
            Analytics.ResourceFlowEvent(ResourceFlowType.Source, "Money", (float)moneyCount, (float)Globals.moneyAmount, null, "DailyBonusRV", ResourceFlowReason.RewardedVideoAd);
        }
        else
        {
            Analytics.ResourceFlowEvent(ResourceFlowType.Source, "Money", (float)moneyCount, (float)Globals.moneyAmount, null, "DailyBonus", ResourceFlowReason.Progression);
        }

    }
    public void TicketCreateDailyRewarded(int moneyCount, Vector3 moneyCreatePos, bool rewardedActive)
    {
        StartCoroutine(Ticket_CreateRewDaily(moneyCount, moneyCreatePos));
    }
    IEnumerator Ticket_CreateRewDaily(int moneyCount, Vector3 moneyCreatePos)
    {
        for (int i = 0; i < moneyCount; i++)
        {
            GameObject mny = Instantiate(ticketPrefab, gemFirstPosTR.position, Quaternion.identity, transform);
            StartCoroutine(GemMoveUI(mny.transform, moneyCount - i - 1, moneyCount));
            //yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(0.4f);

        GameManager.Instance.GemUpdate(moneyCount);
    }
    public void MoneyCreate(int _moneyCount,string itemID, bool rewardedAdvActive)
    {
        StartCoroutine(Money_Create(_moneyCount, itemID, rewardedAdvActive));
    }
    IEnumerator Money_Create(int moneyCount, string itemID, bool rewardedAdvActive)
    {
        for (int i = 0; i < moneyCount; i++)
        {
            GameObject mny = Instantiate(moneyPrefab, moneyFirstPosTR.position, Quaternion.identity, transform);
            StartCoroutine(MoneyMoveUI(mny.transform));
            //yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(0.4f);


        GameManager.Instance.MoneyUpdate(moneyCount);
        if (rewardedAdvActive)
        {
            Analytics.ResourceFlowEvent(ResourceFlowType.Source, "Money", (float)moneyCount, (float)Globals.moneyAmount, null, itemID, ResourceFlowReason.RewardedVideoAd);
        }
        else
        {
            Analytics.ResourceFlowEvent(ResourceFlowType.Source, "Money", (float)moneyCount, (float)Globals.moneyAmount, null, itemID, ResourceFlowReason.Progression);
        }

    }


    IEnumerator MoneyMoveUI(Transform moneyTR)
    {
        Vector3 firstPos = moneyTR.position;
        Vector3 targetPos = moneyTR.position + new Vector3(UnityEngine.Random.Range(-500, 500), UnityEngine.Random.Range(-300, 300), 0);
        float counter = 0;

        while (counter < 1f)
        {
            counter += 3 * Time.deltaTime;
            moneyTR.position = Vector3.Lerp(firstPos, targetPos, counter);

            yield return null;
        }
        yield return new WaitForSeconds(0.2f);
        //yield return new WaitForSeconds(UnityEngine.Random.Range(0.1f, 0.4f));
        firstPos = moneyTR.position;
        counter = 0;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            moneyTR.position = Vector3.Lerp(firstPos, moneyTargetTR.position, counter);

            yield return null;
        }
        Destroy(moneyTR.gameObject);
    }
    IEnumerator MoneyMoveUI_ScaleEffect(Transform moneyTR)
    {
        Vector3 firstPos = moneyTR.position;
        Vector3 targetPos = moneyTR.position + new Vector3(UnityEngine.Random.Range(-500, 500), UnityEngine.Random.Range(-300, 300), 0);
        float counter = 0;

        while (counter < 1f)
        {
            counter += 3 * Time.deltaTime;
            moneyTR.position = Vector3.Lerp(firstPos, targetPos, counter);

            yield return null;
        }
        float randomWaitTime = UnityEngine.Random.Range(0f, 2f);
        yield return new WaitForSeconds(randomWaitTime);
        moneyTR.GetComponent<OpenElasticTrigger>().ScaleEffect();
        yield return new WaitForSeconds(1f);

        //yield return new WaitForSeconds(UnityEngine.Random.Range(0.1f, 0.4f));
        firstPos = moneyTR.position;
        counter = 0;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            moneyTR.position = Vector3.Lerp(firstPos, moneyTargetTR.position, counter);

            yield return null;
        }
        Destroy(moneyTR.gameObject);
    }


    public GameObject gemPrefab;
    public Transform gemFirstPosTR;
    public Transform gemTargetTR;
    public void GemCreate(int _moneyCount )
    {
        StartCoroutine(Gem_Create(_moneyCount));
    }
    IEnumerator Gem_Create(int moneyCount)
    {
        //int _moneyCount = moneyCount;
        //if (_moneyCount < 4)
        //{
        //    _moneyCount = 4;
        //}
        for (int i = 0; i < moneyCount; i++)
        {
            GameObject _gem = Instantiate(gemPrefab, gemFirstPosTR.position, Quaternion.identity, transform);
            StartCoroutine(GemMoveUI(_gem.transform, i, moneyCount));
            //yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(2f);


        GameManager.Instance.GemUpdate(moneyCount);

    }


    IEnumerator GemMoveUI(Transform gemTR , int index, int totalCount)
    {
        float maxAngle = 25f;
        Vector3 firstPos = gemTR.position;
        Vector3 targetPos = gemTR.position;
        Vector3 ticketFirstSize = gemTR.localScale;
        float zRot = 1.5f * maxAngle * (float)index / (float)totalCount;
        float xPos = maxAngle * 3 * (float)index / (float)totalCount;
        float yPos = -5 * maxAngle * (float)index / (float)totalCount;
        targetPos = new Vector3(targetPos.x + xPos, targetPos.y + yPos, targetPos.z);
        Quaternion targetRot = Quaternion.Euler(0, 0, zRot);

        //Vector3 targetPos = gemTR.position + new Vector3(UnityEngine.Random.Range(-200, -500), UnityEngine.Random.Range(-300, 300), 0);
        float counter = 0;

        while (counter < 1f)
        {
            counter += 3 * Time.deltaTime;
            gemTR.position = Vector3.Lerp(firstPos, targetPos, counter);
            gemTR.rotation = Quaternion.Lerp(Quaternion.identity, targetRot, counter);
            yield return null;
        }
        yield return new WaitForSeconds(UnityEngine.Random.Range(1f, 1.5f));
        //yield return new WaitForSeconds(UnityEngine.Random.Range(0.1f, 0.4f));
        firstPos = gemTR.position;
        counter = 0;
        while (counter < 1f)
        {
            counter += 3 * Time.deltaTime;
            gemTR.position = Vector3.Lerp(firstPos, gemTargetTR.position, counter);
            gemTR.localScale = Vector3.Lerp(ticketFirstSize, Vector3.one, counter);

            yield return null;
        }
        // skin tutorial with ticket
        //if (PlayerPrefs.GetInt("tickettutorial") == 1)
        //{
        //    TutorialManager.Instance.click_skin_Tut_GO.SetActive(true);
        //    PlayerPrefs.SetInt("tickettutorial", 2);
        //    StoreManager.Instance.storeButtonTapTutorialGO2.SetActive(true);
        //}
        Destroy(gemTR.gameObject);
    }


    Vector3 firstSizeMoney;
    Vector3 firstSizeGem;

    public Tween MoneyScale(float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        //Vector3 firstScale = prt.localScale;
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                moneyPanel.transform.localScale = firstSizeMoney * value;
            }).OnComplete(delegate ()
            {

            });
        return tween;
    }


    public Tween GemScale(float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        //Vector3 firstScale = prt.localScale;
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                gemPanel.transform.localScale = firstSizeMoney * value;
            }).OnComplete(delegate ()
            {

            });
        return tween;
    }
    //public Transform missionPanelTR;

    public Transform moneyFirstTR;
    public Transform gemFirstTR;
    public Transform misPanFirstTR;

    public Transform moneyTargetPos;
    public Transform gemTarget;
    public Transform misPanTarget;

    public void Panel_Up()
    {
        StartCoroutine(PanelUp());
    }
    public void Panel_Down()
    {
        StartCoroutine(PanelDown());
    }
    IEnumerator PanelUp()
    {
        float counter = 0f;

        while(counter < 1f)
        {
            counter += 4 * Time.deltaTime;
            moneyPanel.transform.position = Vector3.Lerp(moneyPanel.transform.position, moneyFirstTR.position, counter);
            gemPanel.transform.position = Vector3.Lerp(gemPanel.transform.position, gemFirstTR.position, counter);
            //missionPanelTR.transform.position = Vector3.Lerp(missionPanelTR.transform.position, misPanFirstTR.position, counter);
            yield return null;
        }

        moneyPanel.transform.position = Vector3.Lerp( moneyTargetPos.position, moneyFirstTR.position, 1);
        gemPanel.transform.position = Vector3.Lerp( gemTarget.position, gemFirstTR.position, 1);
        //missionPanelTR.transform.position = Vector3.Lerp( misPanTarget.position, misPanFirstTR.position, 1);
    }
    IEnumerator PanelDown()
    {
        float counter = 0f;

        while (counter < 1f)
        {
            counter += 4 * Time.deltaTime;
            moneyPanel.transform.position = Vector3.Lerp(moneyPanel.transform.position, moneyTargetPos.position, counter);
            gemPanel.transform.position = Vector3.Lerp(gemPanel.transform.position, gemTarget.position, counter);
            //missionPanelTR.transform.position = Vector3.Lerp(missionPanelTR.transform.position, misPanTarget.position, counter);
            yield return null;
        }

        moneyPanel.transform.position = Vector3.Lerp(moneyFirstTR.position, moneyTargetPos.position, 1);
        gemPanel.transform.position = Vector3.Lerp(gemFirstTR.position, gemTarget.position, 1);
        //missionPanelTR.transform.position = Vector3.Lerp(misPanFirstTR.position, misPanTarget.position, 1);
    }

    public GameObject acceptButtonGO;
    public GameObject yesButtonGO;





    public void HoverboardSkill_ADV_Click()
    {
        PlayerController.Instance.PlayerControl_ReActive();

        string _tag = "SpeedBoost_RV";
        string adv_name = _tag;

        ADVManager.Instance.RewardedStart(HoverboardSkillClick,adv_name, true);
        //GameManager.Instance.GameAnalyticsTag(tag);

        //GameManager.Instance.HomaAnalyticsTag(tag);

    }
    public void HoverboardSkillClick(bool ticketActive)
    {
        string _tag = "SpeedBoost_RV";
        SkillManager.Instance.HoverboardActive();
        PlayerController.Instance.PlayerControl_ReActive();

        if (ticketActive)
        {
            Analytics.ItemObtained(_tag, 0, ItemFlowReason.Progression);
            Analytics.ItemConsumed(_tag, 0, ItemFlowReason.Progression);
        }
        else
        {
            Analytics.ItemObtained(_tag, 0, ItemFlowReason.RewardedVideoAd);
            Analytics.ItemConsumed(_tag, 0, ItemFlowReason.RewardedVideoAd);
        }

    }
    public void HoverboardSkillClick_Cancel()
    {
        Globals.isSpeedRewardCreated = false;
        PlayerController.Instance.PlayerControl_ReActive();
    }




    public void CapacitySkill_ADV_Click()
    {
        PlayerController.Instance.PlayerControl_ReActive();

        string _tag = "InfiniteCapacity_RV";
        string adv_name = _tag;

        ADVManager.Instance.RewardedStart(CapacitySkillClick,adv_name, true);
        //GameManager.Instance.GameAnalyticsTag(tag);
        //GameManager.Instance.HomaAnalyticsTag(tag);


    }
    public void CapacitySkillClick(bool ticketActive)
    {
        string _tag = "InfiniteCapacity_RV";

        SkillManager.Instance.CapacityActive();
        PlayerController.Instance.PlayerControl_ReActive();

        if (ticketActive)
        {
            Analytics.ItemObtained(_tag, 999, ItemFlowReason.Progression);
            Analytics.ItemConsumed(_tag, 999, ItemFlowReason.Progression);
        }
        else
        {
            Analytics.ItemObtained(_tag, 999, ItemFlowReason.RewardedVideoAd);
            Analytics.ItemConsumed(_tag, 999, ItemFlowReason.RewardedVideoAd);
        }

    }

    public void CapacitySkillClick_Cancel()
    {
        Globals.isCapacityRewardCreated = false;
        PlayerController.Instance.PlayerControl_ReActive();
    }




    public void DoubleIncomeSkill_ADV_Click()
    {
        PlayerController.Instance.PlayerControl_ReActive();

        string _tag = "DoubleIncome_RV";
        string adv_name = _tag;

        ADVManager.Instance.RewardedStart(DoubleIncomeSkillClick,adv_name, true);

        //GameManager.Instance.GameAnalyticsTag(tag);
        //GameManager.Instance.HomaAnalyticsTag(tag);


    }

    public void DoubleIncomeSkillClick(bool ticketActive)
    {
        string _tag = "DoubleIncome_RV";


        SkillManager.Instance.DoubleIncomeActive();
        PlayerController.Instance.PlayerControl_ReActive();

        if (ticketActive)
        {
            Analytics.ItemObtained(_tag, 0, ItemFlowReason.Progression);
            Analytics.ItemConsumed(_tag, 0, ItemFlowReason.Progression);
        }
        else
        {
            Analytics.ItemObtained(_tag, 0, ItemFlowReason.RewardedVideoAd);
            Analytics.ItemConsumed(_tag, 0, ItemFlowReason.RewardedVideoAd);
        }

    }
    public void DoubleIncomeSkillClick_Cancel()
    {
        Globals.isDoubleIncomeRewardCreated = false;
        PlayerController.Instance.PlayerControl_ReActive();

    }








    public void FreeMoneySkill_ADV_Click()
    {
        PlayerController.Instance.PlayerControl_ReActive();

        string _tag = "MoneyBag_RV";
        string adv_name = _tag;

        ADVManager.Instance.RewardedStart(FreeMoneySkill,adv_name , true);

        //GameManager.Instance.GameAnalyticsTag(tag);
        //GameManager.Instance.HomaAnalyticsTag(tag);


    }

    public void FreeMoneySkill(bool ticketActive)
    {
        Globals.isMoneyRewardCreated = false;
        string _tag = "MoneyBag_RV";

        //GameManager.Instance.MoneyUpdate(PopUpManager.Instance.freeMoneyValue);
        MoneyCreate(PopUpManager.Instance.freeMoneyValue, _tag , true);

        if(ticketActive)
        {
            Analytics.ItemObtained(_tag, 0, ItemFlowReason.Progression);
            Analytics.ItemConsumed(_tag, 0, ItemFlowReason.Progression);
        }
        else
        {
            Analytics.ItemObtained(_tag, 0, ItemFlowReason.RewardedVideoAd);
            Analytics.ItemConsumed(_tag, 0, ItemFlowReason.RewardedVideoAd);
        }

    }
   
    public void FreeMoneySkillClickCancel()
    {
        Globals.isMoneyRewardCreated = false;

        PlayerController.Instance.PlayerControl_ReActive();
    }



    public void FreeMoneyPopUp()
    {
        Globals.isMoneyRewardCreated = false;

        //GameManager.Instance.MoneyUpdate(PopUpManager.Instance.freeMoneyValue);
        MoneyCreate((Globals.collectableLevel * 300) + (Globals.openedCarSlotCount * 200) * (PlayerPrefs.GetInt("level") + 1) , "ShareValueBonus" , false);

    }

}


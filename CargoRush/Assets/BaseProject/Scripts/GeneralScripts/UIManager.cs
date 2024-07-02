using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using ObserverSystem;
using UnityEngine.UI;
using DG.Tweening;

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

        if(PlayerPrefs.GetInt("skinactive") == 0)
        {
            //gemPanel.SetActive(true);
            StoreManager.Instance.storeButton.SetActive(true);
            StoreManager.Instance.storeButtonTapTutorialGO.SetActive(true);
            PlayerPrefs.SetInt("skinactive", 1);
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
    public Transform moneyFirstPosTR;
    public Transform moneyTargetTR;
    public void MoneyCreate(int _moneyCount)
    {
        StartCoroutine(Money_Create(_moneyCount));
    }
    IEnumerator Money_Create(int moneyCount)
    {
        for (int i = 0; i < moneyCount; i++)
        {
            GameObject mny = Instantiate(moneyPrefab, moneyFirstPosTR.position, Quaternion.identity, transform);
            StartCoroutine(MoneyMoveUI(mny.transform));
            //yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(0.4f);


        GameManager.Instance.MoneyUpdate(moneyCount);

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
        yield return new WaitForSeconds(0.01f);
        //yield return new WaitForSeconds(UnityEngine.Random.Range(0.1f, 0.4f));
        firstPos = moneyTR.position;
        counter = 0;
        while (counter < 1f)
        {
            counter += 3 * Time.deltaTime;
            moneyTR.position = Vector3.Lerp(firstPos, moneyTargetTR.position, counter);

            yield return null;
        }
        Destroy(moneyTR.gameObject);
    }



    public GameObject gemPrefab;
    public Transform gemFirstPosTR;
    public Transform gemTargetTR;
    public void GemCreate(int _moneyCount,Transform _gemFirstPos)
    {
        StartCoroutine(Gem_Create(_moneyCount, _gemFirstPos));
    }
    IEnumerator Gem_Create(int moneyCount, Transform _gemFirstPos)
    {
        int _moneyCount = moneyCount;
        if (_moneyCount < 4)
        {
            _moneyCount = 4;
        }
        for (int i = 0; i < _moneyCount / 4; i++)
        {
            GameObject _gem = Instantiate(gemPrefab, _gemFirstPos.position, Quaternion.identity, transform);
            StartCoroutine(GemMoveUI(_gem.transform));
            //yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(2f);


        GameManager.Instance.GemUpdate(moneyCount);

    }


    IEnumerator GemMoveUI(Transform gemTR)
    {
        Vector3 firstPos = gemTR.position;
        Vector3 targetPos = gemTR.position + new Vector3(UnityEngine.Random.Range(-200, -500), UnityEngine.Random.Range(-300, 300), 0);
        float counter = 0;

        while (counter < 1f)
        {
            counter += 3 * Time.deltaTime;
            gemTR.position = Vector3.Lerp(firstPos, targetPos, counter);

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

            yield return null;
        }
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
        ADVManager.Instance.RewardedStart(HoverboardSkillClick);
    }
    public void HoverboardSkillClick()
    {
        SkillManager.Instance.HoverboardActive();
        PlayerController.Instance.PlayerControl_ReActive();
    }
    public void HoverboardSkillClick_Cancel()
    {
        Globals.isSpeedRewardCreated = false;
        PlayerController.Instance.PlayerControl_ReActive();
    }




    public void CapacitySkill_ADV_Click()
    {
        PlayerController.Instance.PlayerControl_ReActive();
        ADVManager.Instance.RewardedStart(CapacitySkillClick);
    }
    public void CapacitySkillClick()
    {
        SkillManager.Instance.CapacityActive();
        PlayerController.Instance.PlayerControl_ReActive();
    }

    public void CapacitySkillClick_Cancel()
    {
        Globals.isCapacityRewardCreated = false;
        PlayerController.Instance.PlayerControl_ReActive();
    }




    public void DoubleIncomeSkill_ADV_Click()
    {
        PlayerController.Instance.PlayerControl_ReActive();
        ADVManager.Instance.RewardedStart(DoubleIncomeSkillClick);
    }

    public void DoubleIncomeSkillClick()
    {
        SkillManager.Instance.DoubleIncomeActive();
        PlayerController.Instance.PlayerControl_ReActive();
    }
    public void DoubleIncomeSkillClick_Cancel()
    {
        Globals.isDoubleIncomeRewardCreated = false;
        PlayerController.Instance.PlayerControl_ReActive();

    }








    public void FreeMoneySkill_ADV_Click()
    {
        PlayerController.Instance.PlayerControl_ReActive();
        ADVManager.Instance.RewardedStart(FreeMoneySkill);
    }

    public void FreeMoneySkill()
    {
        Globals.isMoneyRewardCreated = false;

        GameManager.Instance.MoneyUpdate(PopUpManager.Instance.freeMoneyValue);
    }

    public void FreeMoneySkillClickCancel()
    {
        Globals.isMoneyRewardCreated = false;

        PlayerController.Instance.PlayerControl_ReActive();

    }
}


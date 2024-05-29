using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using ObserverSystem;
//using HomaGames.HomaBelly;
//using HomaGames.HomaBelly;
//using GameAnalyticsSDK;

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
    void Awake()
    {
        Globals.moneyAmount = PlayerPrefs.GetInt("money");
        Globals.gemAmount = PlayerPrefs.GetInt("gem");

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
        UnityEngine.Rendering.GraphicsSettings.useScriptableRenderPipelineBatching = true;
        //DefaultAnalytics.GameplayStarted();
        Application.targetFrameRate = 60;
        ui.moneyText.text = CoefficientTransformation.Converter(Globals.moneyAmount);
        ui.moneyTextShop.text = CoefficientTransformation.Converter(Globals.moneyAmount);
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
    }
    IEnumerator StartDelayed()
    {
        yield return new WaitForSeconds(0.2f);
        ui.startCanvas.SetActive(true);
    }
    public void GetMoney()
    {
        MoneyUpdate(createMoney);
    }
    public void GetMoney2()
    {
        MoneyUpdate(createMoney2);
    }
    void OnLevelStart()
    {
        ui.startCanvas.SetActive(false);
        //ui.ingameCanvas.SetActive(true);
        HoleController.Instance.FirstClick();
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


        if (Input.GetKeyDown(KeyCode.X))
        {
            ObserverManager.Instance.RemoveObserver(this);//observer register
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MoneyUpdate(createMoney);
        }
        //if (Input.GetKeyDown(KeyCode.G))
        //{
        //    GemUpdate(createMoney);
        //}
        if (Input.GetKeyDown(KeyCode.H))
        {
            PlayerPrefs.SetInt("holeLevel", 0);
            PlayerPrefs.SetInt("holeSpeedLevel", 0);
            PlayerPrefs.SetInt("holeTimeLevel", 0);
        }
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
    public void RunnerStarter()
    {
        CarManager.Instance.RaceStart();
        //CollectProgressManager.Instance.RaceActive();
    }
    public void GearShiftClick()
    {
        CarManager.Instance.IncreaseGear();
    }
}

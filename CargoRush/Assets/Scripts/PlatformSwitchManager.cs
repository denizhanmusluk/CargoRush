using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlatformSwitchManager : MonoBehaviour
{
    private static PlatformSwitchManager _instance = null;
    public static PlatformSwitchManager Instance => _instance;
    [SerializeField] CinemachineVirtualCamera holeCam, characterCam;
    [SerializeField] GameObject holeUpgradeGO;
    [SerializeField] public GameObject joystickTutorialGO;
    //[SerializeField] public GameObject joystickTutorial2GO;
    [SerializeField] public GameObject dropTheJunksGO;
    [SerializeField] float firstFog, lastFog;
    public GameObject timeUpPanel;
    public GameObject clearPanel;
    //[SerializeField] GameObject holeGroundLight;
    public GameObject bottomLight;
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        //if (PlayerPrefs.GetInt("gameopened") > 0)
        //{
        //    SwitchToBottom();
        //}
        //else
        //{
        //    joystickTutorialGO.SetActive(true);
        //    dropTheJunksGO.SetActive(true);
        //}
    }
    public void SwitchToBottom()
    {
        Globals.holePlatformActive = false;
        //RewardPanel.Instance.biggerPanelGO.SetActive(false);
        //RewardPanel.Instance.fasterPanelGO.SetActive(false);



        if (PlayerPrefs.GetInt("skinactive") == 1)
        {
            StoreManager.Instance.storeButton.SetActive(true);
            GameManager.Instance.ui.gemPanel.SetActive(true);
        }
        //GameManager.Instance.ui.ingameCanvas.SetActive(true);
        GameManager.Instance.ui.panelMission.SetActive(true);
        GameManager.Instance.ui.moneyPanel.SetActive(true);

        bottomLight.SetActive(true);


        if (PlayerPrefs.GetInt("gameopened") == 0)
        {
            //joystickTutorial2GO.SetActive(true);
            //IndicatorManager.Instance.ControlCenterIndActive = true;
            //IndicatorManager.Instance.ShowControlCenter();
            //dropTheJunksGO.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("NextLevelActive") == 0)
        {
            //IndicatorManager.Instance.ControlCenterIndActive = false;
        }

        Globals.stackActive = true;
        //HoleController.Instance.HoleControlDeActive();
        //PlayerController.Instance._FloatingJoystick.pressActive = true;
        //PlayerController.Instance.PlayerSetPos();

        PlayerController.Instance.firstPressPos = Vector2.zero;
        PlayerController.Instance.GameStart();
        PlayerController.Instance._stackCollect.collectActive = true;

        //characterCam.Priority = 1;
        //holeCam.Priority = 0;
        StartCoroutine(CameraSetIdle());
        //HoleManager.Instance.HoleScaleDown();
        //StartCoroutine(FogOpen());
        CollectProgressManager.Instance.HoleEnd();

        //CarManager.Instance.CarOpenParts();
        //GameManager.Instance.ui.joyStick.SetActive(false);
        //CollectProgressManager.Instance.HoleLevelEnd();
        //holeGroundLight.SetActive(false);



        if (PlayerPrefs.GetInt("holetimefree") == 1)
        {
            //IndicatorManager.Instance.IndicatorTargeterActive();
            PlayerPrefs.SetInt("holetimefree", 2);
        }
    }
    IEnumerator CameraSetIdle()
    {
        Fade.Instance.Show();
        var a = Camera.main.GetComponent<CinemachineBrain>().m_DefaultBlend.m_Time;
        Camera.main.GetComponent<CinemachineBrain>().m_DefaultBlend.m_Time = 0;

        characterCam.Priority = 1;
        holeCam.Priority = 0;

        yield return new WaitForSeconds(1f);
        Camera.main.GetComponent<CinemachineBrain>().m_DefaultBlend.m_Time = a;
        //DnzEvents.AIworkerStart();

    }

    IEnumerator AIworkersResetList()
    {
        yield return new WaitForSeconds(4f);
        DnzEvents.AiWorkerResetList();
    }
    IEnumerator CameraSetHole()
    {
        if (PlayerPrefs.GetInt("gameopened") != 0)
        {

            Fade.Instance.Hide();

            yield return new WaitForSeconds(0.5f);
        }
        bottomLight.SetActive(false);
        var a = Camera.main.GetComponent<CinemachineBrain>().m_DefaultBlend.m_Time;
        Camera.main.GetComponent<CinemachineBrain>().m_DefaultBlend.m_Time = 0;

        characterCam.Priority = 0;
        holeCam.Priority = 1;

        Fade.Instance.Show();
        yield return new WaitForSeconds(1f);
        Camera.main.GetComponent<CinemachineBrain>().m_DefaultBlend.m_Time = a;

        //PlayerController.Instance.PlayerSetPos();

        PlayerPrefs.SetInt("switcupcount", PlayerPrefs.GetInt("switcupcount") + 1);

        if (PlayerPrefs.GetInt("switcupcount") == 3)
        {
            PopUpManager.Instance.TipPopUpOpen(2);
            PopUpManager.Instance.TipActionInvoke();
        }
    }
    IEnumerator HoleUpgradeOpenDelayed()
    {
        yield return new WaitForSeconds(1f);
        if (PlayerPrefs.GetInt("gameopened") > 0)
        {
            holeUpgradeGO.SetActive(true);
            GameManager.Instance.ui.moneyPanel.SetActive(true);
        }
        else
        {
            GameManager.Instance.ui.startCanvas.SetActive(true);
        }
        GameManager.Instance.ui.ingameCanvas.SetActive(true);
        //if (PlayerPrefs.GetInt("gameopened") == 0)
        //{
        //    PlayerPrefs.SetInt("gameopened", 1);
        //}
    }
    public void StartHole()
    {
        HoleController.Instance.GameStart();
        HoleManager.Instance._holeTimer.CounterStart();
    }
    public void HoleUpgradeClose()
    {
        holeUpgradeGO.SetActive(false);
        GameManager.Instance.ui.moneyPanel.SetActive(false);
        HoleController.Instance.GameStart();
        HoleManager.Instance._holeTimer.CounterStart();
        //GameManager.Instance.ui.ingameCanvas.SetActive(false);
    }
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.G))
        //{
        //    SwitchToUp();
        //}

        //if (Input.GetKeyDown(KeyCode.B))
        //{
        //    SwitchToBottom();
        //}
    }
    public void JoyStick2Close()
    {
        //joystickTutorial2GO.SetActive(false);
    }
    IEnumerator FogOpen()
    {
        RenderSettings.fog = true;
        float counter = 0f;
        float value = 0f;
        while (counter < 1f)
        {
            counter += 0.75f * Time.deltaTime;
            value = Mathf.Lerp(lastFog, firstFog, counter);
            RenderSettings.fogEndDistance = value;
            RenderSettings.fogStartDistance = value - 8;
            yield return null;
        }
    }

    IEnumerator FogClose()
    {
        float counter = 0f;
        float value = 0f;
        while (counter < 1f)
        {
            counter += 0.5f * Time.deltaTime;
            value = Mathf.Lerp(firstFog, lastFog, counter);
            RenderSettings.fogEndDistance = value;
            RenderSettings.fogStartDistance = value - 8;
            yield return null;
        }
        RenderSettings.fog = false;
    }
}

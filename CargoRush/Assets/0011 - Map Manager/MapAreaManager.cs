using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapAreaManager : MonoBehaviour
{
    private static MapAreaManager _instance = null;
    public static MapAreaManager Instance => _instance;
    public Transform playerPosTR;

    public List<GameObject> lockObjectList = new List<GameObject>();
    public List<GameObject> openObjectList = new List<GameObject>();

    public List<GameObject> map_1_OpenCollectableList = new List<GameObject>();
    public List<GameObject> map_2_OpenCollectableList = new List<GameObject>();
    public List<GameObject> map_3_OpenCollectableList = new List<GameObject>();

    public List<GameObject> map_1_LockCollectableList = new List<GameObject>();
    public List<GameObject> map_2_LockCollectableList = new List<GameObject>();
    public List<GameObject> map_3_LockCollectableList = new List<GameObject>();


    public List<GameObject> mapPanelList = new List<GameObject>();
    public List<MapRoom> mapRoom_List = new List<MapRoom>();

    public List<GameObject> returnButtonImgList = new List<GameObject>();

    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        StartCoroutine(CheckTime());
        StartCoroutine(StartDelay());
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(5f);
        MapAreaSet();
    }
    private void MapAreaSet()
    {
        for (int i = 0; i <= PlayerPrefs.GetInt("mapindexmax"); i++)
        {
            lockObjectList[i].SetActive(false);
            openObjectList[i].SetActive(true);
        }
        CollectablesSet();
        MapsRateSet();

        for (int i = 0; i <= PlayerPrefs.GetInt("mapindexmax"); i++)
        {

            counter = PlayerPrefs.GetInt("offlinecountmap" + i.ToString(), 0);
            
            mapRoom_List[i].offlineCount = counter;
            mapRoom_List[i].DropMoney(counter);
        }



        foreach(var rtrn_btn in returnButtonImgList)
        {
            rtrn_btn.SetActive(false);
        }
        returnButtonImgList[PlayerPrefs.GetInt("level")].SetActive(true);
    }
    private void CollectablesSet()
    {
        for (int i = 0; i <= PlayerPrefs.GetInt("mapindexmax"); i++)
        {
            if (i == 0)
            {
                for(int t = 0; t <= PlayerPrefs.GetInt("collectablelevel" + i); t++)
                {
                    map_1_OpenCollectableList[t].SetActive(true);
                    map_1_LockCollectableList[t].SetActive(false);
                }
            }
            if (i == 1)
            {
                for (int t = 0; t <= PlayerPrefs.GetInt("collectablelevel" + i); t++)
                {
                    map_2_OpenCollectableList[t].SetActive(true);
                    map_2_LockCollectableList[t].SetActive(false);
                }
            }
            if (i == 2)
            {
                for (int t = 0; t <= PlayerPrefs.GetInt("collectablelevel" + i); t++)
                {
                    map_3_OpenCollectableList[t].SetActive(true);
                    map_3_LockCollectableList[t].SetActive(false);
                }
            }
        }
    }
    void MapsRateSet()
    {
        for (int i = 0; i <= PlayerPrefs.GetInt("mapindexmax"); i++)
        {
            mapRoom_List[i].SetRateOpen();
        }
    }
    public void TeleportToMapArea()
    {
        StartCoroutine(TeleportToMapArea_Delay());
        MapAreaSet();

    
    }
    IEnumerator TeleportToMapArea_Delay()
    {

        IndicatorManager.Instance.indicatorMesh.enabled = false;
        GameManager.Instance.ui.mapPanelAnimation.gameObject.SetActive(true);
        GameManager.Instance.ui.mapPanelAnimation.SetBool("closeactive", true);


        PlayerController.Instance.PlayerControlDeActive();
        PlayerController.Instance.navMeshAgent.enabled = false;

        yield return new WaitForSeconds(0.5f);
        PlayerController.Instance._stackCollect.RemoveAll();

        GameManager.Instance.ui.mapUiParentPanel_GO.SetActive(true);
        GameManager.Instance.ui.gameUiParentPanel_GO.SetActive(false);

        PlayerController.Instance.transform.parent.position = playerPosTR.position;

        yield return new WaitForSeconds(0.5f);

        GameManager.Instance.ui.mapPanelAnimation.SetBool("closeactive", false);
        PlayerController.Instance.navMeshAgent.enabled = true;
        PlayerController.Instance.PlayerControl_ReActive();
        if (PlayerPrefs.GetInt("maptutorialseq") == 1)
        {
            PlayerPrefs.SetInt("maptutorialseq", 2);
            IndicatorManager.Instance.indicatorMesh.enabled = true;
            IndicatorManager.Instance.IndicaorActive(mapRoom_List[1].tutorialPosTR);

            IndicatorManager.Instance.TutorialStepCompleted();
            IndicatorManager.Instance.TutorialStepStart(72);
        }
    }
    public void ReturnToFactoryArea()
    {
        StartCoroutine(ReturnToFactoryArea_Delay());
    }
    IEnumerator ReturnToFactoryArea_Delay()
    {
        IndicatorManager.Instance.indicatorMesh.enabled = true;
        GameManager.Instance.ui.mapPanelAnimation.SetBool("closeactive", true);

        PlayerController.Instance.PlayerControlDeActive();
        PlayerController.Instance.navMeshAgent.enabled = false;

        yield return new WaitForSeconds(0.5f);
        GameManager.Instance.ui.mapUiParentPanel_GO.SetActive(false);
        GameManager.Instance.ui.gameUiParentPanel_GO.SetActive(true);

        PlayerController.Instance.transform.parent.position = PlayerController.Instance.posTR.position;
        yield return new WaitForSeconds(0.5f);

        GameManager.Instance.ui.mapPanelAnimation.SetBool("closeactive", false);
        PlayerController.Instance.navMeshAgent.enabled = true;
        PlayerController.Instance.PlayerControl_ReActive();

        yield return new WaitForSeconds(1f);

        GameManager.Instance.ui.mapPanelAnimation.gameObject.SetActive(false);
    }



    public void New_Level_Select(int levelId)
    {
        if(levelId == PlayerPrefs.GetInt("level"))
        {
            ReturnToFactoryArea();
        }
        else
        {
            StartCoroutine(New_Level_Select_Delay(levelId));
        }
    }
    IEnumerator New_Level_Select_Delay(int levelId)
    {


        PlayerController.Instance.PlayerControlDeActive();
        yield return new WaitForSeconds(0.5f);
        GameManager.Instance.ui.mapPanelAnimation.SetBool("closeactive", true);

        yield return new WaitForSeconds(0.5f);

        //yield return new WaitForSeconds(0.5f);

        PlayerPrefs.SetInt("level", levelId);
        Globals.currentLevelIndex = PlayerPrefs.GetInt("level");

        //PlayerPrefs.DeleteAll();

        Globals.collectableLevel = 0;
        Globals.isSpeedRewardCreated = false;
        Globals.isCapacityRewardCreated = false;
        Globals.isDoubleIncomeRewardCreated = false;
        Globals.isMoneyRewardCreated = false;

        Globals.machineErrorActive = false;
        Globals.machineErrorActivator = false;

        Globals.productType1 = false;
        Globals.productType2 = false;
        Globals.productType3 = false;
        Globals.productType4 = false;

        Globals.carSlotCount = 0;


        Globals.openedCarSlotCount = 0;
        ADVManager.Instance.HideBanner();
        GameManager.Instance.OnLevelRestart();
    }



    public int timePeriodMinute = 10;
    private int counter = 0; // Sayaç
    IEnumerator CheckTime()
    {
        yield return new WaitForSeconds(6);
        while (true)
        {
            CheckAndSaveDateTime();
            yield return new WaitForSeconds(10);
        }
    }
    void CheckAndSaveDateTime()
    {
        System.DateTime currentDateTime = System.DateTime.Now;
        string savedDateTime = PlayerPrefs.GetString("savedDateTime", string.Empty);

        if (!string.IsNullOrEmpty(savedDateTime))
        {
            System.DateTime savedDateTimeParsed = System.DateTime.Parse(savedDateTime);
            System.TimeSpan timeDifference = currentDateTime - savedDateTimeParsed;

            if (timeDifference.TotalMinutes >= timePeriodMinute)
            {
                int periodsPassed = (int)(timeDifference.TotalMinutes / timePeriodMinute);
                for (int i = 0; i <= PlayerPrefs.GetInt("mapindexmax"); i++)
                {
                    if (i != PlayerPrefs.GetInt("level"))
                    {
                        counter = PlayerPrefs.GetInt("offlinecountmap" + i.ToString(), 0) + periodsPassed;
                        PlayerPrefs.SetInt("offlinecountmap" + i.ToString(), counter);
                    }
                    else
                    {
                        counter = PlayerPrefs.GetInt("offlinecountmap" + i.ToString(), 0);
                    }
                    mapRoom_List[i].offlineCount = counter;
                    mapRoom_List[i].DropMoney(counter);             
                }
           
            }
        }

        PlayerPrefs.SetString("savedDateTime", currentDateTime.ToString("dd/MM/yyyy HH:mm"));
        PlayerPrefs.Save();
    }
   
}

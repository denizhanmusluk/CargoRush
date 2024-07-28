using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class MissionManager : MonoBehaviour
{
    private static MissionManager _instance = null;
    public static MissionManager Instance => _instance;
    public event Action buttonClick;
    public GameObject tapTutorialGO;
    public bool missionOpenPanelActive = false;
    public Animator missionAnimator;
    public MissionSettings missionSettings;
    public ShopSettings shopSettings;



    public MissionPanel dateMission;




    public Transform missionListTR;
    public int activeMissionCount = 0;
    public GameObject startParticleGO;
    public Button panelOpenButton;
    public GameObject moneyPrefab;
    public GameObject completeMission;
    public int maxMissionCount;

    public GameObject clickPanel;

    public List<GameObject> tapList = new List<GameObject>();



    //public List<MissionPanel> standMissionList = new List<MissionPanel>();
    //public int activeStandMissionCount = 0;
    //[SerializeField] List<int> preStandIdList = new List<int>();


    /////////////////////////////////////////////////////////////////


    public MissionPanel orderMission;
    public MissionPanel specialOrderMission;
    public MissionPanel tapeBoxMission;
    public MissionPanel shippingBuyMission;
    public MissionPanel specialShippingBuyMission;
    public MissionPanel tapingLineBuyMission;
    public MissionPanel newMapMission;



    private void Start()
    {
        missionSettings = LevelManager.Instance.currentMissionSettings;
        if (PlayerPrefs.GetInt(orderMission.missionName + "missionactive" + PlayerPrefs.GetInt("level")) == 1)
        {
            orderMission.gameObject.SetActive(true);
            orderMission.MissionStart(PlayerPrefs.GetInt(orderMission.missionName + "count" + PlayerPrefs.GetInt("level")), PlayerPrefs.GetInt(orderMission.missionName + "maxcount" + PlayerPrefs.GetInt("level")), PlayerPrefs.GetInt(orderMission.missionName + "missionprice" + PlayerPrefs.GetInt("level")), missionSettings._orderName[PlayerPrefs.GetInt(orderMission.missionName + PlayerPrefs.GetInt("level"))]   );

            orderMission.missionRateText.text = PlayerPrefs.GetInt(orderMission.missionName + "maxcount" + PlayerPrefs.GetInt("level")).ToString();
            //orderMission.missionRateText.text = missionSettings._orderName[PlayerPrefs.GetInt(orderMission.missionName + PlayerPrefs.GetInt("level"))].ToString();
        }
        if (PlayerPrefs.GetInt(specialOrderMission.missionName + "missionactive" + PlayerPrefs.GetInt("level")) == 1)
        {
            specialOrderMission.gameObject.SetActive(true);
            specialOrderMission.MissionStart(PlayerPrefs.GetInt(specialOrderMission.missionName + "count" + PlayerPrefs.GetInt("level")), PlayerPrefs.GetInt(specialOrderMission.missionName + "maxcount" + PlayerPrefs.GetInt("level")), PlayerPrefs.GetInt(specialOrderMission.missionName + "missionprice" + PlayerPrefs.GetInt("level")), missionSettings._specialOrderName[PlayerPrefs.GetInt(specialOrderMission.missionName + PlayerPrefs.GetInt("level"))]   );

            specialOrderMission.missionRateText.text = PlayerPrefs.GetInt(specialOrderMission.missionName + "maxcount" + PlayerPrefs.GetInt("level")).ToString();
            //orderMission.missionRateText.text = missionSettings._orderName[PlayerPrefs.GetInt(orderMission.missionName + PlayerPrefs.GetInt("level"))].ToString();
        }
        if (PlayerPrefs.GetInt(tapeBoxMission.missionName + "missionactive" + PlayerPrefs.GetInt("level")) == 1)
        {
            tapeBoxMission.gameObject.SetActive(true);
            tapeBoxMission.MissionStart(PlayerPrefs.GetInt(tapeBoxMission.missionName + "count" + PlayerPrefs.GetInt("level")), PlayerPrefs.GetInt(tapeBoxMission.missionName + "maxcount" + PlayerPrefs.GetInt("level")), PlayerPrefs.GetInt(tapeBoxMission.missionName + "missionprice" + PlayerPrefs.GetInt("level")) , missionSettings._tapeBoxName[PlayerPrefs.GetInt(tapeBoxMission.missionName + PlayerPrefs.GetInt("level"))]);

            tapeBoxMission.missionRateText.text = PlayerPrefs.GetInt(tapeBoxMission.missionName + "maxcount" + PlayerPrefs.GetInt("level")).ToString();
            //orderMission.missionRateText.text = missionSettings._orderName[PlayerPrefs.GetInt(orderMission.missionName + PlayerPrefs.GetInt("level"))].ToString();
        }

        if (PlayerPrefs.GetInt(shippingBuyMission.missionName + "missionactive" + PlayerPrefs.GetInt("level")) == 1)
        {
            shippingBuyMission.gameObject.SetActive(true);
            shippingBuyMission.MissionStart(PlayerPrefs.GetInt(shippingBuyMission.missionName + "count" + PlayerPrefs.GetInt("level")), PlayerPrefs.GetInt(shippingBuyMission.missionName + "maxcount" + PlayerPrefs.GetInt("level")), PlayerPrefs.GetInt(shippingBuyMission.missionName + "missionprice" + PlayerPrefs.GetInt("level")), missionSettings._shippingNameTut[PlayerPrefs.GetInt(shippingBuyMission.missionName + PlayerPrefs.GetInt("level"))]  );

            shippingBuyMission.missionRateText.text = missionSettings._shippingName[PlayerPrefs.GetInt(shippingBuyMission.missionName + PlayerPrefs.GetInt("level"))].ToString();
            //orderMission.missionRateText.text = missionSettings._orderName[PlayerPrefs.GetInt(orderMission.missionName + PlayerPrefs.GetInt("level"))].ToString();
        }

        if (PlayerPrefs.GetInt(specialShippingBuyMission.missionName + "missionactive" + PlayerPrefs.GetInt("level")) == 1)
        {
            specialShippingBuyMission.gameObject.SetActive(true);
            specialShippingBuyMission.MissionStart(PlayerPrefs.GetInt(specialShippingBuyMission.missionName + "count" + PlayerPrefs.GetInt("level")), PlayerPrefs.GetInt(specialShippingBuyMission.missionName + "maxcount" + PlayerPrefs.GetInt("level")), PlayerPrefs.GetInt(specialShippingBuyMission.missionName + "missionprice" + PlayerPrefs.GetInt("level")), missionSettings._specialShippingNameTut[PlayerPrefs.GetInt(specialShippingBuyMission.missionName + PlayerPrefs.GetInt("level"))]);

            specialShippingBuyMission.missionRateText.text = missionSettings._specialShippingName[PlayerPrefs.GetInt(specialShippingBuyMission.missionName + PlayerPrefs.GetInt("level"))].ToString();
            //orderMission.missionRateText.text = missionSettings._orderName[PlayerPrefs.GetInt(orderMission.missionName + PlayerPrefs.GetInt("level"))].ToString();
        }

        if (PlayerPrefs.GetInt(tapingLineBuyMission.missionName + "missionactive" + PlayerPrefs.GetInt("level")) == 1)
        {
            tapingLineBuyMission.gameObject.SetActive(true);
            tapingLineBuyMission.MissionStart(PlayerPrefs.GetInt(tapingLineBuyMission.missionName + "count" + PlayerPrefs.GetInt("level")), PlayerPrefs.GetInt(tapingLineBuyMission.missionName + "maxcount" + PlayerPrefs.GetInt("level")), PlayerPrefs.GetInt(tapingLineBuyMission.missionName + "missionprice" + PlayerPrefs.GetInt("level")), missionSettings._tapingLineNameTut[PlayerPrefs.GetInt(tapingLineBuyMission.missionName + PlayerPrefs.GetInt("level"))]  );

            tapingLineBuyMission.missionRateText.text = missionSettings._tapingLineName[PlayerPrefs.GetInt(tapingLineBuyMission.missionName + PlayerPrefs.GetInt("level"))].ToString();
            //orderMission.missionRateText.text = missionSettings._orderName[PlayerPrefs.GetInt(orderMission.missionName + PlayerPrefs.GetInt("level"))].ToString();
        }

        if (PlayerPrefs.GetInt(newMapMission.missionName + "missionactive" + PlayerPrefs.GetInt("level")) == 1)
        {
            newMapMission.gameObject.SetActive(true);
            newMapMission.MissionStart(PlayerPrefs.GetInt(newMapMission.missionName + "count" + PlayerPrefs.GetInt("level")), PlayerPrefs.GetInt(newMapMission.missionName + "maxcount" + PlayerPrefs.GetInt("level")), PlayerPrefs.GetInt(newMapMission.missionName + "missionprice" + PlayerPrefs.GetInt("level")) , missionSettings._newMapNameTut[PlayerPrefs.GetInt(newMapMission.missionName + PlayerPrefs.GetInt("level"))].ToString());

            newMapMission.missionRateText.text = missionSettings._newMapName[PlayerPrefs.GetInt(newMapMission.missionName + PlayerPrefs.GetInt("level"))].ToString();
        }
    }
    public void OrderMissionStart()
    {
        if (PlayerPrefs.GetInt("missionactivator" + PlayerPrefs.GetInt("level")) == 1 && PlayerPrefs.GetInt(orderMission.missionName + PlayerPrefs.GetInt("level")) < missionSettings._orderCountMission.Length && !orderMission.mission_Active && activeMissionCount < maxMissionCount)
        {
            orderMission.gameObject.SetActive(true);
            orderMission.MissionStart(0, missionSettings._orderCountMission[PlayerPrefs.GetInt(orderMission.missionName + PlayerPrefs.GetInt("level"))],
                missionSettings._orderMissionPrice[PlayerPrefs.GetInt(orderMission.missionName + PlayerPrefs.GetInt("level"))]  ,
                missionSettings._orderName[PlayerPrefs.GetInt(orderMission.missionName + PlayerPrefs.GetInt("level"))]   );


            orderMission.missionRateText.text = missionSettings._orderCountMission[PlayerPrefs.GetInt(orderMission.missionName + PlayerPrefs.GetInt("level"))].ToString();
        }
    }
    public void SpecialOrderMissionStart()
    {
        if (PlayerPrefs.GetInt("missionactivator" + PlayerPrefs.GetInt("level")) == 1 && PlayerPrefs.GetInt(specialOrderMission.missionName + PlayerPrefs.GetInt("level")) < missionSettings._specialOrderCountMission.Length && !specialOrderMission.mission_Active && activeMissionCount < maxMissionCount)
        {
            specialOrderMission.gameObject.SetActive(true);
            specialOrderMission.MissionStart(0, missionSettings._specialOrderCountMission[PlayerPrefs.GetInt(specialOrderMission.missionName + PlayerPrefs.GetInt("level"))],
                missionSettings._specialOrderMissionPrice[PlayerPrefs.GetInt(specialOrderMission.missionName + PlayerPrefs.GetInt("level"))],
                  missionSettings._specialOrderName[PlayerPrefs.GetInt(specialOrderMission.missionName + PlayerPrefs.GetInt("level"))]);


            specialOrderMission.missionRateText.text = missionSettings._specialOrderCountMission[PlayerPrefs.GetInt(specialOrderMission.missionName + PlayerPrefs.GetInt("level"))].ToString();
        }
    }

    public void TapeBoxMissionStart()
    {
        if (PlayerPrefs.GetInt("missionactivator" + PlayerPrefs.GetInt("level")) == 1 && PlayerPrefs.GetInt(tapeBoxMission.missionName + PlayerPrefs.GetInt("level")) < missionSettings._tapeBoxCountMission.Length && !tapeBoxMission.mission_Active && activeMissionCount < maxMissionCount)
        {
            tapeBoxMission.gameObject.SetActive(true);
            tapeBoxMission.MissionStart(0, missionSettings._tapeBoxCountMission[PlayerPrefs.GetInt(tapeBoxMission.missionName + PlayerPrefs.GetInt("level"))],
                missionSettings._tapeBoxMissionPrice[PlayerPrefs.GetInt(tapeBoxMission.missionName + PlayerPrefs.GetInt("level"))],
                missionSettings._tapeBoxName[PlayerPrefs.GetInt(tapeBoxMission.missionName + PlayerPrefs.GetInt("level"))]);


            tapeBoxMission.missionRateText.text = missionSettings._tapeBoxCountMission[PlayerPrefs.GetInt(tapeBoxMission.missionName + PlayerPrefs.GetInt("level"))].ToString();
        }
    }


    public void ShippingLineMissionStart()
    {
        if (PlayerPrefs.GetInt("missionactivator" + PlayerPrefs.GetInt("level")) == 1 && PlayerPrefs.GetInt(shippingBuyMission.missionName + PlayerPrefs.GetInt("level")) < missionSettings._shippingCountMission.Length && !shippingBuyMission.mission_Active && activeMissionCount < maxMissionCount)
        {
            shippingBuyMission.gameObject.SetActive(true);
            shippingBuyMission.MissionStart(0, missionSettings._shippingCountMission[PlayerPrefs.GetInt(shippingBuyMission.missionName + PlayerPrefs.GetInt("level"))],
                missionSettings._shippingMissionPrice[PlayerPrefs.GetInt(shippingBuyMission.missionName + PlayerPrefs.GetInt("level"))],
                  missionSettings._shippingNameTut[PlayerPrefs.GetInt(shippingBuyMission.missionName + PlayerPrefs.GetInt("level"))]);


            //shippingBuyMission.missionRateText.text = missionSettings._shippingCountMission[PlayerPrefs.GetInt(shippingBuyMission.missionName + PlayerPrefs.GetInt("level"))].ToString();
  
            shippingBuyMission.missionRateText.text = missionSettings._shippingName[PlayerPrefs.GetInt(shippingBuyMission.missionName + PlayerPrefs.GetInt("level"))].ToString();
        }
    }
    public void SpecialShippingLineMissionStart()
    {
        if (PlayerPrefs.GetInt("missionactivator" + PlayerPrefs.GetInt("level")) == 1 && PlayerPrefs.GetInt(specialShippingBuyMission.missionName + PlayerPrefs.GetInt("level")) < missionSettings._specialShippingCountMission.Length && !specialShippingBuyMission.mission_Active && activeMissionCount < maxMissionCount)
        {
            specialShippingBuyMission.gameObject.SetActive(true);
            specialShippingBuyMission.MissionStart(0, missionSettings._specialShippingCountMission[PlayerPrefs.GetInt(specialShippingBuyMission.missionName + PlayerPrefs.GetInt("level"))],
                missionSettings._specialShippingMissionPrice[PlayerPrefs.GetInt(specialShippingBuyMission.missionName + PlayerPrefs.GetInt("level"))],
                  missionSettings._specialShippingNameTut[PlayerPrefs.GetInt(specialShippingBuyMission.missionName + PlayerPrefs.GetInt("level"))]);


            //shippingBuyMission.missionRateText.text = missionSettings._shippingCountMission[PlayerPrefs.GetInt(shippingBuyMission.missionName + PlayerPrefs.GetInt("level"))].ToString();

            specialShippingBuyMission.missionRateText.text = missionSettings._specialShippingName[PlayerPrefs.GetInt(specialShippingBuyMission.missionName + PlayerPrefs.GetInt("level"))].ToString();
        }
    }

    public void TapingLineMissionStart()
    {
        if (PlayerPrefs.GetInt("missionactivator" + PlayerPrefs.GetInt("level")) == 1 && PlayerPrefs.GetInt(tapingLineBuyMission.missionName + PlayerPrefs.GetInt("level")) < missionSettings._tapingLineCountMission.Length && !tapingLineBuyMission.mission_Active && activeMissionCount < maxMissionCount)
        {
            tapingLineBuyMission.gameObject.SetActive(true);
            tapingLineBuyMission.MissionStart(0, missionSettings._tapingLineCountMission[PlayerPrefs.GetInt(tapingLineBuyMission.missionName + PlayerPrefs.GetInt("level"))],
                missionSettings._tapingLineMissionPrice[PlayerPrefs.GetInt(tapingLineBuyMission.missionName + PlayerPrefs.GetInt("level"))],
                   missionSettings._tapingLineNameTut[PlayerPrefs.GetInt(tapingLineBuyMission.missionName + PlayerPrefs.GetInt("level"))]);


            //shippingBuyMission.missionRateText.text = missionSettings._shippingCountMission[PlayerPrefs.GetInt(shippingBuyMission.missionName + PlayerPrefs.GetInt("level"))].ToString();

            tapingLineBuyMission.missionRateText.text = missionSettings._tapingLineName[PlayerPrefs.GetInt(tapingLineBuyMission.missionName + PlayerPrefs.GetInt("level"))].ToString();
        }
    }

    public void NewMapMissionStart()
    {
        if (PlayerPrefs.GetInt("missionactivator" + PlayerPrefs.GetInt("level")) == 1 && PlayerPrefs.GetInt(newMapMission.missionName + PlayerPrefs.GetInt("level")) < missionSettings._newMapCountMission.Length && !newMapMission.mission_Active && activeMissionCount < maxMissionCount)
        {
            newMapMission.gameObject.SetActive(true);
            newMapMission.MissionStart(0, missionSettings._newMapCountMission[PlayerPrefs.GetInt(newMapMission.missionName + PlayerPrefs.GetInt("level"))],
                           missionSettings._newMapMissionPrice[PlayerPrefs.GetInt(newMapMission.missionName + PlayerPrefs.GetInt("level"))],
                                missionSettings._newMapNameTut[PlayerPrefs.GetInt(newMapMission.missionName + PlayerPrefs.GetInt("level"))]);
            newMapMission.missionRateText.text = missionSettings._newMapName[PlayerPrefs.GetInt(newMapMission.missionName + PlayerPrefs.GetInt("level"))].ToString();

        }
    }
    /////////////////////////////////////////////////////////////////




    private void Awake()
    {
        _instance = this;
    }
    void SaveDate()
    {
        DateMissionStart();
        System.DateTime date = System.DateTime.Now;
        string tarih = date.ToString("dd/MM/yyyy");

        Debug.Log("kayitliTarih " + PlayerPrefs.GetString("kayitliTarih") + "  " + tarih);

        if (PlayerPrefs.GetString("kayitliTarih") != null && PlayerPrefs.GetString("kayitliTarih") != tarih)
        {
            dateMission.MissionUpdate();
        }

        PlayerPrefs.SetString("kayitliTarih", tarih);

        PlayerPrefs.Save();
    }
    private void Start2()
    {


      

        //if (PlayerPrefs.GetInt(dateMission.missionName + "missionactive") == 1)
        //{
        //    dateMission.gameObject.SetActive(true);
        //    dateMission.MissionStart(0, 1, 10);
        //}
        //SaveDate();
    }
    
    public void MissionOpen()
    {
        tapTutorialGO.SetActive(false);
        missionOpenPanelActive = true;
        startParticleGO.SetActive(false);
        missionAnimator.SetBool("openactive", true);
        clickPanel.SetActive(true);

        if (PlayerPrefs.GetInt("firstmissioncomplete") == 1)
        {
            PlayerPrefs.SetInt("firstmissioncomplete", 2);
            tapList[0].SetActive(false);
            //tapList[1].SetActive(true);
        }

        buttonClick?.Invoke();
        AudioManager.Instance.ButtonSound();

    }
    private void OnDisable()
    {
        buttonClick?.Invoke();
    }
    public void MissionClose()
    {
        missionOpenPanelActive = false;

        missionAnimator.SetBool("openactive", false);
        clickPanel.SetActive(false);
    }
    public void ShopOpenMission()
    {

    }
    public void ProductMissionStart(int productID)
    {

    }
    public void DateMissionStart()
    {
        //if (PlayerPrefs.GetInt("missionactivator") == 1 && !dateMission.mission_Active && activeMissionCount < maxMissionCount)
        //{
        //    dateMission.gameObject.SetActive(true);
        //    dateMission.MissionStart(0, 1, 10);

        //    //dateMission.missionRateText.text = "";

        //}
    }




  

    public Transform moneyTargetTR;
    public void MoneyCreate(int _moneyCount, Transform moneyCreatePosTR)
    {
        StartCoroutine(Money_Create(_moneyCount, moneyCreatePosTR));
    }
    IEnumerator Money_Create(int moneyCount, Transform moneyCreatePosTR)
    {
        int _moneyCount = moneyCount;
        if(_moneyCount < 10)
        {
            _moneyCount = 10;
        }
        for (int i = 0; i < _moneyCount / 10; i++)
        {
            GameObject mny = Instantiate(moneyPrefab, moneyCreatePosTR.position, Quaternion.identity, transform);
            StartCoroutine(MoneyMoveUI(mny.transform));
            //yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(2f);

        GameManager.Instance.MoneyUpdate(moneyCount);
    }
    IEnumerator MoneyMoveUI(Transform moneyTR)
    {
        Vector3 firstPos = moneyTR.position;
        Vector3 targetPos = moneyTR.position + new Vector3(UnityEngine.Random.Range(-200, -500), UnityEngine.Random.Range(-300, 300), 0);
        float counter = 0;

        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            moneyTR.position = Vector3.Lerp(firstPos, targetPos, counter);

            yield return null;
        }
        yield return new WaitForSeconds(UnityEngine.Random.Range(1f, 1.5f));
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
    IEnumerator Money_MoveUI(Transform moneyTR)
    {
        Vector3 firstPos = moneyTR.position;
        float counter = 0;

        while(counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            moneyTR.position = Vector3.Lerp(firstPos, moneyTargetTR.position, counter);

            yield return null;
        }
        Destroy(moneyTR.gameObject);
    }

  

    /*
    public void PickUpPassengerMission(int currentCount)
    {
        total_Take_Customer_Current = currentCount;

        passengerPickUpText.gameObject.SetActive(true);

        passengerPickUpText.text = "Get the passengers on the train: " + currentCount.ToString() + "/" + MarketCustomerManager.Instance.total_Take_Customer_Count.ToString();
        if(currentCount >= MarketCustomerManager.Instance.total_Take_Customer_Count)
        {

            passengerPickUpText.gameObject.SetActive(false);
        }
        else
        {
            passengerPickUpText.gameObject.SetActive(true);

            passengerPickUpText.fontStyle = FontStyles.Normal;
            passengerPickUpText.color = Color.white;

        }
        AllMissionCompleteCheck();
    }

    public void CleanSeatMission(int currentCount)
    {
        dirtyDeskCountCurrent = currentCount;

        cleanDeskText.gameObject.SetActive(true);

        cleanDeskText.text = "Clean the passenger seat: " + currentCount.ToString() + "/" + MarketCustomerManager.Instance.dirtyDeskCountTotal.ToString();
        if (currentCount >= MarketCustomerManager.Instance.dirtyDeskCountTotal)
        {

            cleanDeskText.gameObject.SetActive(false);
        }
        else
        {
            cleanDeskText.gameObject.SetActive(true);
            cleanDeskText.fontStyle = FontStyles.Normal;
            cleanDeskText.color = Color.white;

        }
        AllMissionCompleteCheck();
    }

    public void CollectTicketMission(int currentCount)
    {
        ticketCountCurrent = currentCount;
        ticketText.gameObject.SetActive(true);
        ticketText.text = "Collect the passengers' tickets: " + currentCount.ToString() + "/" + MarketCustomerManager.Instance.ticketCountTotal.ToString();
        if (currentCount >= MarketCustomerManager.Instance.ticketCountTotal)
        {

            ticketText.gameObject.SetActive(false);
        }
        else
        {
            ticketText.gameObject.SetActive(true);
            ticketText.fontStyle = FontStyles.Normal;
            ticketText.color = Color.white;

        }
        AllMissionCompleteCheck();
    }
    public bool checkList_openActive = false;
    void AllMissionCompleteCheck()
    {
        if(ticketText.gameObject.activeInHierarchy && cleanDeskText.gameObject.activeInHierarchy && passengerPickUpText.gameObject.activeInHierarchy && checkList_openActive)
        {
            missionAnimator2.SetBool("openactive", true);
            checkList_openActive = false;
        }

        if (!ticketText.gameObject.activeInHierarchy && !cleanDeskText.gameObject.activeInHierarchy && !passengerPickUpText.gameObject.activeInHierarchy && !checkList_openActive)
        {
            missionAnimator2.SetBool("openactive", false);
            checkList_openActive = true;
        }
    }
    IEnumerator FontColorSetSmooth(Color firstColor , Color targetColor, TextMeshProUGUI textTR)
    {
        float counter = 0f; 
        while(counter < 1f)
        {
            counter += Time.deltaTime;

            textTR.color = Color.Lerp(firstColor, targetColor, counter);
            yield return null;
        }

        textTR.color = targetColor;

    }
    int ticketCountCurrent;
    int dirtyDeskCountCurrent;
    int total_Take_Customer_Current;

    public void MissionCompleteCheck()
    {
        if (total_Take_Customer_Current != MarketCustomerManager.Instance.total_Take_Customer_Count) 
        {
            StartCoroutine(FontColorSetSmooth2(Color.white , Color.red , ticketText));
        }
        if (dirtyDeskCountCurrent != MarketCustomerManager.Instance.dirtyDeskCountTotal)
        {
            StartCoroutine(FontColorSetSmooth2(Color.white, Color.red, cleanDeskText));
        }
        if (ticketCountCurrent != MarketCustomerManager.Instance.ticketCountTotal) 
        {
            StartCoroutine(FontColorSetSmooth2(Color.white, Color.red, passengerPickUpText));
        }
    }
    IEnumerator FontColorSetSmooth2(Color firstColor, Color targetColor, TextMeshProUGUI textTR)
    {
        float counter = 0f;
        float angle = 0f;
        while (counter < 3f)
        {
            counter += 2 * Time.deltaTime;
            angle = Mathf.Abs(Mathf.Sin(counter * Mathf.PI));
            textTR.color = Color.Lerp(firstColor, targetColor, angle);
            yield return null;
        }

        textTR.color = firstColor;

    }
    */



    public void OpenPanelButton()
    {
        panelOpenButton.gameObject.SetActive(true);
    }

    public void MissionCompPopUpOpen(string txt)
    {
        StartCoroutine(MissionCompPopUpOpen_Delay(txt));
    }
    IEnumerator MissionCompPopUpOpen_Delay(string txt)
    {
        missionCompletePopUpGO.SetActive(true);
        missionCompleteText.text = txt + " Quest Complated";
        yield return new WaitForSeconds(2f);
        missionCompletePopUpGO.SetActive(false);
    }
    public GameObject missionCompletePopUpGO;
    public TextMeshProUGUI missionCompleteText;
}
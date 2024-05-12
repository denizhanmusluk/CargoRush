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
    public Animator missionAnimator2;
    public MissionSettings missionSettings;
    public ShopSettings shopSettings;


    public MissionPanel technoShopMission;
    public MissionPanel sportShopMission;
    public MissionPanel toysShopMission;

    public MissionPanel technoShopFullMission;
    public MissionPanel sportShopFullMission;
    public MissionPanel toysShopFullMission;

    public MissionPanel machineMission;
    public MissionPanel standMission;
    public MissionPanel skinMission;
    public MissionPanel newMapMission;
    public MissionPanel dateMission;

    //public MissionPanel phoneProductMission;
    //public MissionPanel chairCleanMission;
    //public MissionPanel customerTakeMission;
    //public MissionPanel ticketTakeMission;
    //public MissionPanel toiletCleanMission;
    //public MissionPanel toiletPaperMission;
    //public MissionPanel waterMission;
    //public MissionPanel hotDogMission;
    //public MissionPanel colaMission;
    //public MissionPanel coffeeMission;
    //public MissionPanel soapMission;
    //public MissionPanel bedroomCleanMission;
    //public MissionPanel vipCustomerTakeMission;



    public Transform missionListTR;
    public int activeMissionCount = 0;
    public GameObject startParticleGO;
    public Button panelOpenButton;
    public GameObject moneyPrefab;
    public GameObject completeMission;
    public int maxMissionCount;

    public List<MissionPanel> missionPanels = new List<MissionPanel>();
    public GameObject clickPanel;

    public List<GameObject> tapList = new List<GameObject>();


    public List<MissionPanel> productMissionList = new List<MissionPanel>();
    public int activeProductMissionCount = 0;
    [SerializeField] List<int> preProductIdList = new List<int>();

    public List<MissionPanel> saleMissionList = new List<MissionPanel>();
    public int activeSaleMissionCount = 0;
    [SerializeField] List<int> preSaleIdList = new List<int>();

    public List<Stand> allStandList = new List<Stand>();
    //public List<MissionPanel> standMissionList = new List<MissionPanel>();
    //public int activeStandMissionCount = 0;
    //[SerializeField] List<int> preStandIdList = new List<int>();
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
    private void Start()
    {
        for (int i = 0; i < missionPanels.Count; i++)
        {
            if (PlayerPrefs.GetInt(missionPanels[i].missionName + "missionactive") == 1)
            {
                panelOpenButton.gameObject.SetActive(true);
                missionPanels[i].gameObject.SetActive(true);
                missionPanels[i].MissionStart(PlayerPrefs.GetInt(missionPanels[i].missionName + "count"), PlayerPrefs.GetInt(missionPanels[i].missionName + "maxcount"), PlayerPrefs.GetInt(missionPanels[i].missionName + "missionprice"));
                missionPanels[i].missionRateText.text = PlayerPrefs.GetInt(missionPanels[i].missionName + "maxcount").ToString();

            }
        }

        for (int i = 0; i < productMissionList.Count; i++)
        {
            if (PlayerPrefs.GetInt(productMissionList[i].missionName + i.ToString() + "missionactive") == 1)
            {
                panelOpenButton.gameObject.SetActive(true);
                productMissionList[i].gameObject.SetActive(true);
                productMissionList[i].MissionStartProduce(PlayerPrefs.GetInt(productMissionList[i].missionName + i.ToString() + "count"), PlayerPrefs.GetInt(productMissionList[i].missionName + i.ToString() + "maxcount"), PlayerPrefs.GetInt(productMissionList[i].missionName + i.ToString() + "missionprice"), PlayerPrefs.GetInt(productMissionList[i].missionName));
                productMissionList[i].missionRateText.text = PlayerPrefs.GetInt(productMissionList[i].missionName + i.ToString() + "maxcount").ToString();

            }
        }


        for (int i = 0; i < saleMissionList.Count; i++)
        {
            if (PlayerPrefs.GetInt(saleMissionList[i].missionName + i.ToString() + "missionactive") == 1)
            {
                panelOpenButton.gameObject.SetActive(true);
                saleMissionList[i].gameObject.SetActive(true);
                saleMissionList[i].MissionStartSale(PlayerPrefs.GetInt(saleMissionList[i].missionName + i.ToString() + "count"), PlayerPrefs.GetInt(saleMissionList[i].missionName + i.ToString() + "maxcount"), PlayerPrefs.GetInt(saleMissionList[i].missionName + i.ToString() + "missionprice"), PlayerPrefs.GetInt(saleMissionList[i].missionName));
                saleMissionList[i].missionRateText.text = PlayerPrefs.GetInt(saleMissionList[i].missionName + i.ToString() + "maxcount").ToString();
            }
        }



        if (PlayerPrefs.GetInt(technoShopMission.missionName + "missionactive") == 1)
        {
            panelOpenButton.gameObject.SetActive(true);
            technoShopMission.gameObject.SetActive(true);
            technoShopMission.MissionStart(PlayerPrefs.GetInt(technoShopMission.missionName + "count"), PlayerPrefs.GetInt(technoShopMission.missionName + "maxcount"), PlayerPrefs.GetInt(technoShopMission.missionName + "missionprice"));
            technoShopMission.missionRateText.text = PlayerPrefs.GetInt(technoShopMission.missionName + "maxcount").ToString();

            float ratio = shopSettings._shopData[0].shopRatio[PlayerPrefs.GetInt(technoShopMission.missionName)];
            ratio *= 100;

            technoShopMission.missionRateText.text = "%" + ((int)ratio).ToString();
        }


        if (PlayerPrefs.GetInt(sportShopMission.missionName + "missionactive") == 1)
        {
            panelOpenButton.gameObject.SetActive(true);
            sportShopMission.gameObject.SetActive(true);
            sportShopMission.MissionStart(PlayerPrefs.GetInt(sportShopMission.missionName + "count"), PlayerPrefs.GetInt(sportShopMission.missionName + "maxcount"), PlayerPrefs.GetInt(sportShopMission.missionName + "missionprice"));
            sportShopMission.missionRateText.text = PlayerPrefs.GetInt(sportShopMission.missionName + "maxcount").ToString();

            float ratio = shopSettings._shopData[1].shopRatio[PlayerPrefs.GetInt(sportShopMission.missionName)];
            ratio *= 100;

            sportShopMission.missionRateText.text = "%" + ((int)ratio).ToString();
        }


        if (PlayerPrefs.GetInt(toysShopMission.missionName + "missionactive") == 1)
        {
            panelOpenButton.gameObject.SetActive(true);
            toysShopMission.gameObject.SetActive(true);
            toysShopMission.MissionStart(PlayerPrefs.GetInt(toysShopMission.missionName + "count"), PlayerPrefs.GetInt(toysShopMission.missionName + "maxcount"), PlayerPrefs.GetInt(toysShopMission.missionName + "missionprice"));
            toysShopMission.missionRateText.text = PlayerPrefs.GetInt(toysShopMission.missionName + "maxcount").ToString();

            float ratio = shopSettings._shopData[2].shopRatio[PlayerPrefs.GetInt(toysShopMission.missionName)];
            ratio *= 100;

            toysShopMission.missionRateText.text = "%" + ((int)ratio).ToString();
        }

        if (PlayerPrefs.GetInt(technoShopFullMission.missionName + "missionactive") == 1)
        {
            panelOpenButton.gameObject.SetActive(true);
            technoShopFullMission.gameObject.SetActive(true);
            technoShopFullMission.MissionStart(PlayerPrefs.GetInt(technoShopFullMission.missionName + "count"), PlayerPrefs.GetInt(technoShopFullMission.missionName + "maxcount"), PlayerPrefs.GetInt(technoShopFullMission.missionName + "missionprice"));
            technoShopFullMission.missionRateText.text = PlayerPrefs.GetInt(technoShopFullMission.missionName + "maxcount").ToString();

            float ratio = shopSettings._shopData2[0].shopRatio[PlayerPrefs.GetInt(technoShopFullMission.missionName)];
            ratio *= 100;

            technoShopFullMission.missionRateText.text = "%" + ((int)ratio).ToString();
        }


        if (PlayerPrefs.GetInt(sportShopFullMission.missionName + "missionactive") == 1)
        {
            panelOpenButton.gameObject.SetActive(true);
            sportShopFullMission.gameObject.SetActive(true);
            sportShopFullMission.MissionStart(PlayerPrefs.GetInt(sportShopFullMission.missionName + "count"), PlayerPrefs.GetInt(sportShopFullMission.missionName + "maxcount"), PlayerPrefs.GetInt(sportShopFullMission.missionName + "missionprice"));
            sportShopFullMission.missionRateText.text = PlayerPrefs.GetInt(sportShopFullMission.missionName + "maxcount").ToString();

            float ratio = shopSettings._shopData2[1].shopRatio[PlayerPrefs.GetInt(sportShopFullMission.missionName)];
            ratio *= 100;

            sportShopFullMission.missionRateText.text = "%" + ((int)ratio).ToString();
        }


        if (PlayerPrefs.GetInt(toysShopFullMission.missionName + "missionactive") == 1)
        {
            panelOpenButton.gameObject.SetActive(true);
            toysShopFullMission.gameObject.SetActive(true);
            toysShopFullMission.MissionStart(PlayerPrefs.GetInt(toysShopFullMission.missionName + "count"), PlayerPrefs.GetInt(toysShopFullMission.missionName + "maxcount"), PlayerPrefs.GetInt(toysShopFullMission.missionName + "missionprice"));
            toysShopFullMission.missionRateText.text = PlayerPrefs.GetInt(toysShopFullMission.missionName + "maxcount").ToString();

            float ratio = shopSettings._shopData2[2].shopRatio[PlayerPrefs.GetInt(toysShopFullMission.missionName)];
            ratio *= 100;

            toysShopFullMission.missionRateText.text = "%" + ((int)ratio).ToString();
        }

        if (PlayerPrefs.GetInt(machineMission.missionName + "missionactive") == 1)
        {
            panelOpenButton.gameObject.SetActive(true);
            machineMission.gameObject.SetActive(true);
            //productMissionList[productID].MissionStart(0, 1,5);
            machineMission.MissionStart(PlayerPrefs.GetInt(machineMission.missionName + "count"), 1, PlayerPrefs.GetInt(machineMission.missionName + "missionprice"));
            int machineID = PlayerPrefs.GetInt(machineMission.missionName) + 1;

            if (machineID == 1) { machineMission.missionRateText.text = "headphone"; }
            if (machineID == 2) { machineMission.missionRateText.text = "shoe"; }
            if (machineID == 3) { machineMission.missionRateText.text = "bat"; }
            if (machineID == 4) { machineMission.missionRateText.text = "tshirt"; }
            if (machineID == 5) { machineMission.missionRateText.text = "baby doll"; }
            if (machineID == 6) { machineMission.missionRateText.text = "teddy bear"; }
            if (machineID == 7) { machineMission.missionRateText.text = "toy car"; }
        }


        if (PlayerPrefs.GetInt(standMission.missionName + "missionactive") == 1)
        {
            panelOpenButton.gameObject.SetActive(true);
            standMission.gameObject.SetActive(true);
            //productMissionList[productID].MissionStart(0, 1,5);
            standMission.MissionStart(PlayerPrefs.GetInt(standMission.missionName + "count"), PlayerPrefs.GetInt(standMission.missionName + "maxcount"), PlayerPrefs.GetInt(standMission.missionName + "missionprice"));
            int maxCount = PlayerPrefs.GetInt(standMission.missionName + "maxcount");

            int stndId = PlayerPrefs.GetInt(standMission.missionName);

            if (stndId == 0) { standMission.missionRateText.text = "phone stands"; }
            if (stndId == 1) { standMission.missionRateText.text = "laptop stands"; }
            if (stndId == 2) { standMission.missionRateText.text = "headphone stands"; }
            if (stndId == 3) { standMission.missionRateText.text = "shoe stands"; }
            if (stndId == 4) { standMission.missionRateText.text = "baseball bat stands"; }
            if (stndId == 5) { standMission.missionRateText.text = "tshirt stands"; }
            if (stndId == 6) { standMission.missionRateText.text = "baby doll stands"; }
            if (stndId == 7) { standMission.missionRateText.text = "teddy bear stands"; }
            if (stndId == 8) { standMission.missionRateText.text =  "toy car stands"; }
        }


        if (PlayerPrefs.GetInt(skinMission.missionName + "missionactive") == 1)
        {
            skinMission.gameObject.SetActive(true);
            skinMission.MissionStart(PlayerPrefs.GetInt(skinMission.missionName + "count"), PlayerPrefs.GetInt(skinMission.missionName + "maxcount"), PlayerPrefs.GetInt(skinMission.missionName + "missionprice"));

            skinMission.missionRateText.text = missionSettings._skinName[PlayerPrefs.GetInt(skinMission.missionName)].ToString();

            //skinMission.missionRateText.text = PlayerPrefs.GetInt(skinMission.missionName + "maxcount").ToString();
        }

        if (PlayerPrefs.GetInt(newMapMission.missionName + "missionactive") == 1)
        {
            newMapMission.gameObject.SetActive(true);
            newMapMission.MissionStart(0, 1, 25);


        }

        if (PlayerPrefs.GetInt(dateMission.missionName + "missionactive") == 1)
        {
            dateMission.gameObject.SetActive(true);
            dateMission.MissionStart(0, 1, 10);
        }
        SaveDate();
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
        if (PlayerPrefs.GetInt("missionactivator") == 1 && !dateMission.mission_Active && activeMissionCount < maxMissionCount)
        {
            dateMission.gameObject.SetActive(true);
            dateMission.MissionStart(0, 1, 10);

            //dateMission.missionRateText.text = "";

        }
    }
    public void ProductMission_Start(int productID , float productMoneyValue)
    {
        for(int i = 0; i < preProductIdList.Count; i++)
        {
            if(preProductIdList[i] == productID)
            {
                return;
            }
        }
        if (PlayerPrefs.GetInt("missionactivator") == 1 && !productMissionList[productID].mission_Active && activeMissionCount < maxMissionCount && activeProductMissionCount < 1)
        {
            preProductIdList.Add(productID);
            if(PlayerPrefs.GetInt("shopindex") + 1 < preProductIdList.Count)
            {
                preProductIdList.Remove(preProductIdList[0]);
            }
            productMissionList[productID].gameObject.SetActive(true);
            //productMissionList[productID].MissionStart(0, 1,5);
            productMissionList[productID].MissionStartProduce(0, 50 * (PlayerPrefs.GetInt("shopindex") + 1), (int)(50 * (PlayerPrefs.GetInt("shopindex") + 1) * productMoneyValue), productID);
            productMissionList[productID].missionRateText.text = (50 * (PlayerPrefs.GetInt("shopindex") + 1)).ToString();
        }
    }
    public void SalingMission_Start(int productID, float productMoneyValue)
    {
        for (int i = 0; i < preSaleIdList.Count; i++)
        {
            if (preSaleIdList[i] == productID)
            {
                return;
            }
        }
        if (PlayerPrefs.GetInt("missionactivator") == 1 && !saleMissionList[productID].mission_Active && activeMissionCount < maxMissionCount && activeSaleMissionCount < 1)
        {
            preSaleIdList.Add(productID);
            if (PlayerPrefs.GetInt("shopindex") + 1 < preSaleIdList.Count)
            {
                preSaleIdList.Remove(preSaleIdList[0]);
            }
            saleMissionList[productID].gameObject.SetActive(true);
            //productMissionList[productID].MissionStart(0, 1,5);
            saleMissionList[productID].MissionStartSale(0, 50 * (PlayerPrefs.GetInt("shopindex") + 1), (int)(50 * (PlayerPrefs.GetInt("shopindex") + 1) * productMoneyValue), productID);
            saleMissionList[productID].missionRateText.text = (50 * (PlayerPrefs.GetInt("shopindex") + 1)).ToString();

        }
    }
    public void MachineMission_Start(int machineID)
    {
      
        if (PlayerPrefs.GetInt("missionactivator") == 1 && PlayerPrefs.GetInt(machineMission.missionName) + 1 == machineID && PlayerPrefs.GetInt(machineMission.missionName) < missionSettings._openMachineMissionPrice.Length && !machineMission.mission_Active && activeMissionCount < maxMissionCount)
        {

            machineMission.gameObject.SetActive(true);
            //productMissionList[productID].MissionStart(0, 1,5);
            machineMission.MissionStart(0, 1, missionSettings._openMachineMissionPrice[PlayerPrefs.GetInt(machineMission.missionName)]);


            if(machineID == 1) { machineMission.missionRateText.text = "headphone"; }
            if(machineID == 2) { machineMission.missionRateText.text = "shoe"; }
            if(machineID == 3) { machineMission.missionRateText.text = "bat"; }
            if(machineID == 4) { machineMission.missionRateText.text = "tshirt"; }
            if(machineID == 5) { machineMission.missionRateText.text = "baby doll"; }
            if(machineID == 6) { machineMission.missionRateText.text = "teddy bear"; }
            if(machineID == 7) { machineMission.missionRateText.text = "toy car"; }
           
        }
    }
    public void StandMission_Start(int productID)
    {

        if (PlayerPrefs.GetInt("missionactivator") == 1 && PlayerPrefs.GetInt(standMission.missionName) == productID && PlayerPrefs.GetInt(standMission.missionName) < missionSettings._standCountMission.Length && !standMission.mission_Active && activeMissionCount < maxMissionCount)
        {

            standMission.gameObject.SetActive(true);
            //productMissionList[productID].MissionStart(0, 1,5);
            standMission.MissionStart(0, missionSettings._standCountMission[PlayerPrefs.GetInt(standMission.missionName)], missionSettings._standMissionPrice[PlayerPrefs.GetInt(standMission.missionName)]);
            int maxCount = missionSettings._standCountMission[PlayerPrefs.GetInt(standMission.missionName)];

            if (productID == 0) { standMission.missionRateText.text = "phone stands"; }
            if (productID == 1) { standMission.missionRateText.text = "laptop stands"; }
            if (productID == 2) { standMission.missionRateText.text = "headphone stands"; }
            if (productID == 3) { standMission.missionRateText.text = "shoe stands"; }
            if (productID == 4) { standMission.missionRateText.text = "baseball bat stands"; }
            if (productID == 5) { standMission.missionRateText.text = "tshirt stands"; }
            if (productID == 6) { standMission.missionRateText.text = "baby doll stands"; }
            if (productID == 7) { standMission.missionRateText.text = "teddy bear stands"; }
            if (productID == 8) { standMission.missionRateText.text = "toy car stands"; }

        }
    }

    public void TechnoShopFullOpenMissionStart()
    {
        if (PlayerPrefs.GetInt("missionactivator") == 1 && PlayerPrefs.GetInt(technoShopFullMission.missionName) < shopSettings._shopData2[0].openShopCount.Length && !technoShopFullMission.mission_Active && activeMissionCount < maxMissionCount)
        {
            technoShopFullMission.gameObject.SetActive(true);
            technoShopFullMission.MissionStart(0, shopSettings._shopData2[0].openShopCount[PlayerPrefs.GetInt(technoShopFullMission.missionName)], shopSettings._shopData2[0].priceGem[PlayerPrefs.GetInt(technoShopFullMission.missionName)]);



            float ratio = shopSettings._shopData2[0].shopRatio[PlayerPrefs.GetInt(technoShopFullMission.missionName)];
            //float ratio = (float)(shopSettings._shopData[1].openShopCount[PlayerPrefs.GetInt(sportShopMission.missionName)]) / (float)(ShopManager.Instance.shopCountTotal[1]);
            ratio *= 100;

            technoShopFullMission.missionRateText.text = "%" + ((int)ratio).ToString();
        }
    }
    public void SportShopFullOpenMissionStart()
    {
        if (PlayerPrefs.GetInt("missionactivator") == 1 && PlayerPrefs.GetInt(sportShopFullMission.missionName) < shopSettings._shopData2[1].openShopCount.Length && !sportShopFullMission.mission_Active && activeMissionCount < maxMissionCount)
        {
            sportShopFullMission.gameObject.SetActive(true);
            sportShopFullMission.MissionStart(0, shopSettings._shopData2[1].openShopCount[PlayerPrefs.GetInt(sportShopFullMission.missionName)], shopSettings._shopData2[1].priceGem[PlayerPrefs.GetInt(sportShopFullMission.missionName)]);

            float ratio = shopSettings._shopData2[1].shopRatio[PlayerPrefs.GetInt(sportShopFullMission.missionName)];
            //float ratio = (float)(shopSettings._shopData[1].openShopCount[PlayerPrefs.GetInt(sportShopMission.missionName)]) / (float)(ShopManager.Instance.shopCountTotal[1]);
            ratio *= 100;

            sportShopFullMission.missionRateText.text = "%" + ((int)ratio).ToString();
        }
    }


    public void ToysShopFullOpenMissionStart()
    {
        if (PlayerPrefs.GetInt("missionactivator") == 1 && PlayerPrefs.GetInt(toysShopFullMission.missionName) < shopSettings._shopData2[2].openShopCount.Length && !toysShopFullMission.mission_Active && activeMissionCount < maxMissionCount)
        {
            toysShopFullMission.gameObject.SetActive(true);
            toysShopFullMission.MissionStart(0, shopSettings._shopData2[2].openShopCount[PlayerPrefs.GetInt(toysShopFullMission.missionName)], shopSettings._shopData2[2].priceGem[PlayerPrefs.GetInt(toysShopFullMission.missionName)]);

            float ratio = shopSettings._shopData2[2].shopRatio[PlayerPrefs.GetInt(toysShopFullMission.missionName)];
            ratio *= 100;

            toysShopFullMission.missionRateText.text = "%" + ((int)ratio).ToString();
        }
    }
    public void TechnoShopMissionStart()
    {
        if (PlayerPrefs.GetInt("missionactivator") == 1 && PlayerPrefs.GetInt(technoShopMission.missionName) < shopSettings._shopData[0].openShopCount.Length && !technoShopMission.mission_Active && activeMissionCount < maxMissionCount)
        {
            technoShopMission.gameObject.SetActive(true);
            technoShopMission.MissionStart(0, shopSettings._shopData[0].openShopCount[PlayerPrefs.GetInt(technoShopMission.missionName)], shopSettings._shopData[0].priceGem[PlayerPrefs.GetInt(technoShopMission.missionName)]);



            float ratio = shopSettings._shopData[0].shopRatio[PlayerPrefs.GetInt(technoShopMission.missionName)];
            //float ratio = (float)(shopSettings._shopData[1].openShopCount[PlayerPrefs.GetInt(sportShopMission.missionName)]) / (float)(ShopManager.Instance.shopCountTotal[1]);
            ratio *= 100;

            technoShopMission.missionRateText.text = "%" + ((int)ratio).ToString();
        }   
    }

    public void SportShopMissionStart()
    {
        if (PlayerPrefs.GetInt("missionactivator") == 1 && PlayerPrefs.GetInt(sportShopMission.missionName) < shopSettings._shopData[1].openShopCount.Length && !sportShopMission.mission_Active && activeMissionCount < maxMissionCount)
        {
            sportShopMission.gameObject.SetActive(true);
            sportShopMission.MissionStart(0, shopSettings._shopData[1].openShopCount[PlayerPrefs.GetInt(sportShopMission.missionName)], shopSettings._shopData[1].priceGem[PlayerPrefs.GetInt(sportShopMission.missionName)]);

            float ratio = shopSettings._shopData[1].shopRatio[PlayerPrefs.GetInt(sportShopMission.missionName)];
            //float ratio = (float)(shopSettings._shopData[1].openShopCount[PlayerPrefs.GetInt(sportShopMission.missionName)]) / (float)(ShopManager.Instance.shopCountTotal[1]);
            ratio *= 100;

            sportShopMission.missionRateText.text = "%" + ((int)ratio).ToString();
        }
    }


    public void ToysShopMissionStart()
    {
        if (PlayerPrefs.GetInt("missionactivator") == 1 && PlayerPrefs.GetInt(toysShopMission.missionName) < shopSettings._shopData[2].openShopCount.Length && !toysShopMission.mission_Active && activeMissionCount < maxMissionCount)
        {
            toysShopMission.gameObject.SetActive(true);
            toysShopMission.MissionStart(0, shopSettings._shopData[2].openShopCount[PlayerPrefs.GetInt(toysShopMission.missionName)], shopSettings._shopData[2].priceGem[PlayerPrefs.GetInt(toysShopMission.missionName)]);

            float ratio = shopSettings._shopData[2].shopRatio[PlayerPrefs.GetInt(toysShopMission.missionName)];
            ratio *= 100;

            toysShopMission.missionRateText.text = "%" + ((int)ratio).ToString();
        }
    }

    public void SkinMissionStart()
    {
        if (PlayerPrefs.GetInt("missionactivator") == 1 && PlayerPrefs.GetInt(skinMission.missionName) < missionSettings._skinCountMission.Length && !skinMission.mission_Active && activeMissionCount < maxMissionCount)
        {
            skinMission.gameObject.SetActive(true);
            skinMission.MissionStart(0, missionSettings._skinCountMission[PlayerPrefs.GetInt(skinMission.missionName)],
                missionSettings._skinMissionPrice[PlayerPrefs.GetInt(skinMission.missionName)]);


            skinMission.missionRateText.text = missionSettings._skinName[PlayerPrefs.GetInt(skinMission.missionName)].ToString();
        }
    }

    public void NewMapMissionStart()
    {
        if (PlayerPrefs.GetInt("missionactivator") == 1 && PlayerPrefs.GetInt(newMapMission.missionName) < 1 && !newMapMission.mission_Active && activeMissionCount < maxMissionCount)
        {
            newMapMission.gameObject.SetActive(true);
            newMapMission.MissionStart(0, 1, 25);
                //missionSettings._skinMissionPrice[PlayerPrefs.GetInt(newMapMission.missionName)]);


            //newMapMission.missionRateText.text = missionSettings._skinName[PlayerPrefs.GetInt(newMapMission.missionName)].ToString();
        }
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
}
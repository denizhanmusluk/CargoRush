using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Cinemachine;
public class BuyArea : MonoBehaviour, BuyCamera
{
    public string gaTag;

    public bool standUpgradeActive = false;
    public int standUpgradeLevel = 0;

    public bool shopBayArea = false;
    public int shopId;
    public int ratioValue;
    [SerializeField] bool cameraPassive;
    public bool IndicatorActive;
    public bool checkMoneyActive;

    //[SerializeField] CinemachineVirtualCamera nextAreaViewCamera;
    //[SerializeField] GameObject nextBuyCanvas;
    //[SerializeField] CinemachineVirtualCamera viewCamera;
    [SerializeField] ParticleSystem fireWork;

    //[SerializeField] GameObject buyCanvas, lockedIMG;
    public bool buyActive = false;
    [SerializeField] GameObject buildPrefab;
    [SerializeField] GameObject[] buyAreas;
    [SerializeField] GameObject[] closeAreas;
    //[SerializeField] Transform buildPosTR;

    public int cost;
    public int currentAmount;
    int deltaCost = 50;
    [SerializeField] public Image outline;
    [SerializeField] public TextMeshProUGUI costText;

    [SerializeField] GameObject buyArea;
    [SerializeField] string buyName;
    [SerializeField] string currentCostBuild;
    public bool isbuy = true;


    float counterTime = 0;
    [SerializeField] bool sellActive = true;
    [SerializeField] bool thisBuyViewActive;

    [SerializeField] bool tipUpActive = false;
    [SerializeField] int tipId;
    public CinemachineVirtualCamera thisBuyViewCamera;
    public CinemachineVirtualCamera buyCamera
    {
        get { return thisBuyViewCamera; }
        set { thisBuyViewCamera = value; }
    }
    public GameObject transparentModel_GO;
    public GameObject showBuyPNG_GO;
    public GameObject lockedPNG_GO;
    public GameObject buyCanvasGO;
    public string standShowName;
    public TextMeshProUGUI standShowText;
    public TextMeshProUGUI standShowLockedText;
    public bool isWorkerBuy = false;
    public Animator keyAnimator;
    //Vector3 firstPos;
    //Quaternion firstRot;

    public bool ceoActive = false;
    public Transform ceoTargetPosTR;
    public float showingTime = 1.5f;
    public bool boosterOpener = false;
    public bool vipActivator = false;
    public bool hrBuy;
    public bool machineErrorActivator = false;

    public bool specialVehicleOpener = false;
    public bool ticketTutorialActivator = false;
    void Awake()
    {
        if (cost >= 20)
        {
            deltaCost = cost / 20;
        }
        else
        {
            deltaCost = cost / 10;
        }
        StartCoroutine(StartDelay());

        //firstPos = buildPosTR.position;
        //firstRot = buildPosTR.rotation;
    }
    public void Start()
    {
        standShowText.text = standShowName;
        if (PlayerPrefs.GetInt(buyName + PlayerPrefs.GetInt("level")) == 0 && cost == 0 && buyActive)
        {
            PlayerPrefs.SetInt(buyName + PlayerPrefs.GetInt("level"), 1);
            IndicatorActive = false;
            instantiateBuild(Time.deltaTime, true);

            GetComponent<Collider>().enabled = false;

            buyArea.SetActive(false);

            StartCoroutine(CloseDelay());
        }
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(0.1f);

        if (PlayerPrefs.GetInt(buyName + PlayerPrefs.GetInt("level")) == 1)
        {
            checkMoneyActive = false;
            IndicatorActive = false;
            instantiateBuild(Time.deltaTime, false);

            GetComponent<Collider>().enabled = false;

            buyArea.SetActive(false);

            StartCoroutine(CloseDelay());
            if (ceoActive)
            {
                //ceoStand.gameObject.SetActive(true);
            }
        }
        else
        {
            OpenNextBuyArea();
        }


        //else if (thisBuyViewActive && PlayerPrefs.GetInt("level") >= 3)
        //{
        //    StartCoroutine(ThisBuyAreaView());
        //}
        //if (PlayerPrefs.GetInt("bodyoperationlevel") + 1 >= operationID)
        //{
        //    buyActive = true;
        //    buyCanvas.SetActive(true);
        //    lockedIMG.SetActive(false);
        //}
        //else
        //{
        //    buyCanvas.SetActive(false);
        //    lockedIMG.SetActive(true);
        //}



        if (PlayerPrefs.GetInt(currentCostBuild + PlayerPrefs.GetInt("level")) == 0)
        {
            currentAmount = cost;
            costText.text = CoefficientTransformation.Converter(cost);
        }
        else
        {
            currentAmount = PlayerPrefs.GetInt(currentCostBuild + PlayerPrefs.GetInt("level"));
            costText.text = CoefficientTransformation.Converter(currentAmount);
        }
        if (cost == 0)
        {
            outline.fillAmount = 0;
        }
        else
        {
            outline.fillAmount = 1 - (float)currentAmount / (float)cost;
        }
        yield return new WaitForSeconds(0.1f);

  
    }
    IEnumerator CheckMoney()
    {
        while (checkMoneyActive && currentAmount > 0)
        {
            if (currentAmount <= Globals.moneyAmount && currentAmount > 0)
            {
                IndicatorManager.Instance.IndicaorActive(transform);
                IndicatorManager.Instance.transUpIndActive = false;
            }
            else
            {
                //IndicatorManager.Instance.IndicaorDeActive();
                //IndicatorManager.Instance.transUpIndActive = true;
            }
            yield return new WaitForSeconds(1f);
            if (currentAmount == 0)
            {
                IndicatorManager.Instance.IndicaorDeActive();
                IndicatorManager.Instance.transUpIndActive = true;
            }
        }
        //yield return new WaitForSeconds(5f);

        //IndicatorManager.Instance.transUpIndActive = true;


    }
    IEnumerator CloseDelay()
    {
        yield return new WaitForSeconds(0.5f);
        int buildChildCount = transform.childCount;
        for (int i = 0; i < buildChildCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }
    bool cooldown = true;
    [SerializeField] bool paymentActive = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && Globals.buyActive)
        {
            StartCoroutine(CooldownActive(0.5f));
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            paymentActive = false;
        }
    }
    IEnumerator CooldownActive(float time)
    {
        paymentActive = false;
        cooldown = true;
        float counter = 0f;
        while (counter < time && cooldown)
        {
            counter += Time.deltaTime;
            yield return null;
        }
        if (counter >= time)
        {
            cooldown = false;
            paymentActive = true;
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            if (!other.GetComponent<PlayerController>().pressJoystick)
            {
                if (PlayerPrefs.GetInt("money", 0) >= deltaCost)
                {
                    if (sellActive && isbuy && buyActive && paymentActive)
                    {
                        StartCoroutine(Buy(true));
                        other.GetComponent<Payment>().Pay(transform.position);
                    }
                }
                else
                {
                    if (sellActive && isbuy && buyActive && paymentActive)
                    {
                        StartCoroutine(Buy(false));
                        //other.GetComponent<Payment>().Pay(transform.position);
                    }
                }
            }
        }
    }
    IEnumerator Buy(bool delta_cost_active)
    {
        if (IndicatorActive)
        {
            IndicatorActive = false;
            IndicatorManager.Instance.IndicaorDeActive();
        }
        isbuy = false;
        if (delta_cost_active)
        {
            currentAmount -= deltaCost;
            VibratoManager.Instance.LightVibration();
            AudioManager.Instance.PaymentSound();
        }
        else
        {
            currentAmount -= PlayerPrefs.GetInt("money");
        }
        outline.fillAmount = 1 - (float)currentAmount / (float)cost;

        if (currentAmount < 0)
        {
            currentAmount = 0;
        }
        costText.text = CoefficientTransformation.Converter(currentAmount);
        if (delta_cost_active)
        {
            GameManager.Instance.MoneyUpdate(-deltaCost);
        }
        else
        {
            GameManager.Instance.MoneyUpdate(-PlayerPrefs.GetInt("money"));
        }

        PlayerPrefs.SetInt(currentCostBuild + PlayerPrefs.GetInt("level"), currentAmount);
        if (currentAmount == 0)
        {
            FirstOpenArea();
            PlayerPrefs.SetInt(buyName + PlayerPrefs.GetInt("level"), 1);
            PlayerPrefs.Save();

        }
        counterTime += Time.deltaTime;
        if (counterTime > 0.15f)
        {
            counterTime = 0f;
        }

        yield return null;
        isbuy = true;

    }
    public bool indTutorialActive;
    void FirstOpenArea()
    {
        if (specialVehicleOpener)
        {
            MissionManager.Instance.SpecialShippingLineMissionStart();
        }
        if (standUpgradeActive)
        {
            string _tag = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-" + gaTag;
            GameManager.Instance.GameAnalyticsTag(_tag);
            AudioManager.Instance.UpgradeSound();
        }
        else
        {
            AudioManager.Instance.OpenNewAreaSound();
        }
        if (hrBuy)
        {
            if (PlayerPrefs.GetInt("hropen") == 0)
            {
                GameManager.Instance.ui.hrBuyTextGO.SetActive(false);
            }
        }

        StartCoroutine(BuyActivator());
        
        checkMoneyActive = false;

        VibratoManager.Instance.HeavyVibration();
        fireWork.Play();
        fireWork.transform.parent = null;
        outline.fillAmount = 0;
        sellActive = false;
        StartCoroutine(buildScaling());
        GetComponent<Collider>().enabled = false;
        if (indTutorialActive)
        {
            IndicatorManager.Instance.IndicatorTargeterActive();
        }
        if (tipUpActive)
        {
            //PopUpManager.Instance.TipPopUpOpen(tipId);
        }

        if (isWorkerBuy && HRUpgradeManager.Instance._upgradeAreaWorkers.gameObject.activeInHierarchy)
        {
            HRUpgradeManager.Instance.WorkerBuyArea();
        }
        transparentModel_GO.SetActive(false);

        if(keyAnimator != null)
        {
            keyAnimator.SetTrigger("unlock");
        }

        if (boosterOpener)
        {
            //SkillManager.Instance.SkillCreate();
            PlayerPrefs.SetInt("skillActive", 1);
        }
       
        if (vipActivator)
        {
            PlayerPrefs.SetInt("vipActive", 1);
            //MarketCustomerManager.Instance.currentCustomerCount = 125;
        }

    }
    IEnumerator BuyActivator()
    {
        Globals.buyActive = false;
        yield return new WaitForSeconds(1f);
        Globals.buyActive = true;
    }
    IEnumerator buildScaling()
    {
        instantiateBuild(0.2f,true);
        yield return null;

        int buildChildCount = transform.childCount;
        for (int i = 0; i < buildChildCount; i++)
        {
            StartCoroutine(throughlyScaling(transform.GetChild(i).transform));
        }
    }

    IEnumerator throughlyScaling(Transform bld)
    {
        float counter = 1f;
        float lastSize = 0f;
        float sizeDelta;

        while (counter < 1f)
        {
            counter -= 15 * Time.deltaTime;

            bld.localScale = new Vector3(counter, counter, counter);
            yield return null;
        }
        bld.localScale = new Vector3(lastSize, lastSize, lastSize);
    }
    void instantiateBuild(float waitTime, bool cameraActive)
    {
        if (standUpgradeActive && buildPrefab.GetComponent<IStandUpgrade>() != null)
        {
            buildPrefab.GetComponent<IStandUpgrade>().standLevel = standUpgradeLevel;
            buildPrefab.GetComponent<IStandUpgrade>().UpgradeValueInit();
        }
        else
        {
            buildPrefab.SetActive(true);
        }

        StartCoroutine(OpenBuyAreas(waitTime, cameraActive));
        ClosedAreas();
    }
    IEnumerator OpenBuyAreas(float waitTime, bool isNewOpen)
    {
        yield return new WaitForSeconds(waitTime);
        if (isNewOpen && !cameraPassive)
        {
            PlayerController.Instance.PlayerControlDeActive();
        }
        for (int i = 0; i < buyAreas.Length; i++)
        {

            buyAreas[i].SetActive(true);
            if (buyAreas[i].GetComponent<BuyArea>() != null)
            {
                // satýn alýndýktan sonra bir sonrakileri
                buyAreas[i].GetComponent<BuyArea>().buyActive = true;
                yield return null;
                buyAreas[i].GetComponent<BuyArea>().OpenNextBuyArea();


                buyAreas[i].GetComponent<BuyArea>().OpenAndActive();

            }
            if (isNewOpen && !cameraPassive)
            {
                yield return new WaitForSeconds(0.5f);

                if (buyAreas[i].GetComponent<BuyCamera>() != null)
                {
                    buyAreas[i].GetComponent<BuyCamera>().buyCamera.Priority = ((i + 1) * 10);
                    if (buyAreas[i].GetComponent<BuyArea>() != null)
                    {
                        yield return new WaitForSeconds(buyAreas[i].GetComponent<BuyArea>().showingTime);
                    }
                }
            }
            yield return null;
        }
        if (isNewOpen && !cameraPassive)
        {
            if (!Globals.goToCeoActive)
            {
                PlayerController.Instance.PlayerControl_ReActive();
            
            }

            for (int i = 0; i < buyAreas.Length; i++)
            {
                if (buyAreas[i].GetComponent<BuyCamera>() != null)
                {
                    buyAreas[i].GetComponent<BuyCamera>().buyCamera.Priority = 0;
                }
            }

            yield return new WaitForSeconds(1f);
            if (ticketTutorialActivator)
            {
                if (PlayerPrefs.GetInt("tickettutorial") == 0)
                {
                    GameManager.Instance.ui.GemCreate(1);
                    PlayerPrefs.SetInt("tickettutorial", 1);
                }
            }
        }

        if (shopBayArea)
        {
            if (isNewOpen)
            {
                ShopManager.Instance.SetShopCount(shopId, ratioValue, true);
            }
            else
            {
                ShopManager.Instance.SetShopCount(shopId, ratioValue, false);
            }
        }

        //PopUpManager.Instance.ActionInvoke();
        //PopUpManager.Instance.TipActionInvoke();

        if (machineErrorActivator)
        {
            Globals.machineErrorActivator = true;
        }
    }
    void ClosedAreas()
    {
        for (int i = 0; i < closeAreas.Length; i++)
        {
            closeAreas[i].SetActive(false);
        }
    }


    public void OpenNextBuyArea()
    {
        StartCoroutine(OpenNextBuyAreaDelay());
    }
    IEnumerator OpenNextBuyAreaDelay()
    {
        if (buyActive)
        {
            for (int i = 0; i < buyAreas.Length; i++)
            {
                if (buyAreas[i].GetComponent<BuyArea>() != null)
                {
                    if (!buyAreas[i].GetComponent<BuyArea>().standUpgradeActive)
                    {
                        buyAreas[i].SetActive(true);
                        buyAreas[i].GetComponent<BuyArea>().buyActive = false;
                        buyAreas[i].GetComponent<BuyArea>().OpenButDeactive();
                        buyAreas[i].GetComponent<BuyArea>().standShowLockedText.text = "Unlock \n" + standShowName;
                        //yield return new WaitForSeconds(0.1f);
                    }
                }
            }
        }
        yield return new WaitForSeconds(0.1f);
    }





    public void OpenAndActive()
    {
        StartCoroutine(OpenAndActiveDelay());
    }
    IEnumerator OpenAndActiveDelay()
    {
        yield return new WaitForSeconds(0.25f);
        buyActive = true;
        //transparentModel_GO.SetActive(true);
        showBuyPNG_GO.SetActive(true);
        lockedPNG_GO.SetActive(false);
        buyCanvasGO.SetActive(true);
        Start();
        if (checkMoneyActive)
        {
            StartCoroutine(CheckMoney());
        }
        else
        {
            if (IndicatorActive && PlayerPrefs.GetInt(buyName + PlayerPrefs.GetInt("level")) == 0)
            {
                IndicatorManager.Instance.IndicaorActive(transform);
            }
        }

        if (hrBuy)
        {
            if (PlayerPrefs.GetInt("hropen") == 0)
            {
                GameManager.Instance.ui.hrBuyTextGO.SetActive(true);
            }
        }

    }
    public void OpenButDeactive()
    {
        buyActive = false;
        transparentModel_GO.SetActive(false);
        showBuyPNG_GO.SetActive(false);
        lockedPNG_GO.SetActive(true);
        buyCanvasGO.SetActive(false);
    }
}
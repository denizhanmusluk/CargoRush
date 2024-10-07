using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Cinemachine;
using HomaGames.HomaBelly;

public class UpgradeArea : MonoBehaviour, BuyCamera , IBuyCost
{
    public string gaTag;
    public int upgradeLevel;
    public int ratioValue;
    public bool shopBayArea = false;

    public bool buyActive = false;
    [SerializeField] GameObject[] buyAreas;

    [SerializeField] int cost;
    int currentAmount;
    int deltaCost = 50;
    [SerializeField] public Image outline;
    [SerializeField] public TextMeshProUGUI costText;

    [SerializeField] GameObject buyArea;
    [SerializeField] string buyName;
    [SerializeField] string currentCostBuild;
    public bool isbuy = true;


    float counterTime = 0;
    bool sellActive = true;
    [SerializeField] bool thisBuyViewActive;
    [SerializeField] StandFishCar _StandFishCar;

    public CinemachineVirtualCamera thisBuyViewCamera;
    public CinemachineVirtualCamera buyCamera
    {
        get { return thisBuyViewCamera; }
        set { thisBuyViewCamera = value; }
    }
    public bool viewThisCamera { get; set; }
    public int buyCost
    {
        get;
        set;
    }
    public string buyNameForResource;

    //Vector3 firstPos;
    //Quaternion firstRot;
    void Awake()
    {
        if (cost >= 20)
        {
            deltaCost = cost / 20;
        }
        else
        {
            deltaCost = cost / 10;
        }        //firstPos = buildPosTR.position;
        //firstRot = buildPosTR.rotation;
        StartCoroutine(StartDelay());
    }
    IEnumerator StartDelay()
    {
        if (PlayerPrefs.GetInt(buyName + PlayerPrefs.GetInt("level")) == 1)
        {

            LevelSet(Time.deltaTime, false, false);

            GetComponent<Collider>().enabled = false;

            buyArea.SetActive(false);

            StartCoroutine(CloseDelay());
        }
        else
        {
            SkillManager.Instance.buyAreaList.Add(this);
        }

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
        outline.fillAmount = 1 - (float)currentAmount / (float)cost;

        buyCost = currentAmount;
        yield return new WaitForSeconds(0.1f);
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
    bool paymentActive = false;

    int buyCounter = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && Globals.buyActive)
        {
            StartCoroutine(CooldownActive(1f));
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            paymentActive = false;
            if (buyCounter > 0)
            {
                SendAnalyticResource(buyCounter);
                buyCounter = 0;
            }
        }
    }
    void SendAnalyticResource(int sendMoneyAmount)
    {
        Analytics.ResourceFlowEvent(ResourceFlowType.Sink, "Money", (float)sendMoneyAmount, (float)Globals.moneyAmount, upgradeLevel.ToString(), buyNameForResource, ResourceFlowReason.Progression);
        Debug.Log("sendMoneyAmount" + sendMoneyAmount);
    }
    IEnumerator CooldownActive(float time)
    {
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
                        StartCoroutine(buy());
                        other.GetComponent<Payment>().Pay(transform.position);
                    }
                }
            }
        }
    }
    IEnumerator buy()
    {
        VibratoManager.Instance.LightVibration();
        AudioManager.Instance.PaymentSound();
        isbuy = false;

        if (currentAmount < deltaCost)
        {
            deltaCost = currentAmount;
        }

        currentAmount -= deltaCost;
        outline.fillAmount = 1 - (float)currentAmount / (float)cost;

        if (currentAmount < 0)
        {
            currentAmount = 0;
        }


        costText.text = CoefficientTransformation.Converter(currentAmount);
        GameManager.Instance.MoneyUpdate(-deltaCost);
        buyCounter += deltaCost;

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

        buyCost = currentAmount;
    }
    void FirstOpenArea()
    {
        if (buyCounter > 0)
        {
            SendAnalyticResource(buyCounter);
        }
        //string _tag = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-" + gaTag;
        //GameManager.Instance.GameAnalyticsTag(_tag);

        //GameManager.Instance.HomaAnalyticsTag(gaTag, PlayerPrefs.GetInt("level") + 1, upgradeLevel);

        //GameManager.Instance.HomaAnalyticsTag(gaTag);
        Analytics.ItemUpgraded(ItemUpgradeType.Item, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " " + gaTag, upgradeLevel, ItemFlowReason.Progression);

        StartCoroutine(BuyActivator());

        VibratoManager.Instance.HeavyVibration();
        outline.fillAmount = 0;
        sellActive = false;
        StartCoroutine(buildScaling());
        GetComponent<Collider>().enabled = false;
        _StandFishCar.LevelUp();
        AudioManager.Instance.UpgradeSound();

        SkillManager.Instance.buyAreaList.Remove(this);

        if (QuestManager.Instance.upgradeQuest != null)
        {
            QuestManager.Instance.upgradeQuest.QuestUpdate(1);
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
        LevelSet(1f,false , true);
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
    void LevelSet(float waitTime, bool cameraActive, bool isNewOpen)
    {
        //buildPrefab.SetActive(true);
        StartCoroutine(OpenBuyAreas(waitTime, cameraActive, isNewOpen));
    }
    IEnumerator OpenBuyAreas(float waitTime, bool cameraActive, bool isNewOpen)
    {
        yield return new WaitForSeconds(waitTime);
        if (cameraActive)
        {
            PlayerController.Instance.PlayerControlDeActive();
        }
        for (int i = 0; i < buyAreas.Length; i++)
        {
            if (isNewOpen)
            {
                yield return new WaitForSeconds(10f);
            }
            buyAreas[i].SetActive(true);
            if (cameraActive)
            {
                yield return new WaitForSeconds(0.5f);

                if (buyAreas[i].GetComponent<BuyCamera>() != null)
                {
                    buyAreas[i].GetComponent<BuyCamera>().buyCamera.Priority = ((i + 1) * 10);
                    yield return new WaitForSeconds(1.5f);
                }
            }
        }
        if (cameraActive)
        {
            PlayerController.Instance.PlayerControl_ReActive();

            for (int i = 0; i < buyAreas.Length; i++)
            {
                if (buyAreas[i].GetComponent<BuyCamera>() != null)
                {
                    buyAreas[i].GetComponent<BuyCamera>().buyCamera.Priority = 0;
                }
            }
        }

        if (shopBayArea)
        {
            if (isNewOpen)
            {
                ShopManager.Instance.SetShopCount(0, ratioValue, true);
            }
            else
            {
                ShopManager.Instance.SetShopCount(0, ratioValue, false);
            }
        }
    }
}

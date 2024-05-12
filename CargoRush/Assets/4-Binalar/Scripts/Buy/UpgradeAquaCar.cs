using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Cinemachine;
public class UpgradeAquaCar : MonoBehaviour, BuyCamera
{
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
    [SerializeField] AquariumCar _aqFishCar;

    public CinemachineVirtualCamera thisBuyViewCamera;
    public CinemachineVirtualCamera buyCamera
    {
        get { return thisBuyViewCamera; }
        set { thisBuyViewCamera = value; }
    }
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
        if (PlayerPrefs.GetInt(buyName) == 1)
        {

            LevelSet(Time.deltaTime, false);

            GetComponent<Collider>().enabled = false;

            buyArea.SetActive(false);

            StartCoroutine(CloseDelay());
        }


        if (PlayerPrefs.GetInt(currentCostBuild) == 0)
        {
            currentAmount = cost;
            costText.text = cost.ToString();
        }
        else
        {
            currentAmount = PlayerPrefs.GetInt(currentCostBuild);
            costText.text = currentAmount.ToString();
        }
        outline.fillAmount = 1 - (float)currentAmount / (float)cost;
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            StartCoroutine(CooldownActive(0.9f));
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
    IEnumerator buy()
    {
        VibratoManager.Instance.LightVibration();
        isbuy = false;
        currentAmount -= deltaCost;
        outline.fillAmount = 1 - (float)currentAmount / (float)cost;

        if (currentAmount < 0)
        {
            currentAmount = 0;
        }


        costText.text = currentAmount.ToString();
        GameManager.Instance.MoneyUpdate(-deltaCost);

        PlayerPrefs.SetInt(currentCostBuild, currentAmount);
        if (currentAmount == 0)
        {
            FirstOpenArea();
            PlayerPrefs.SetInt(buyName, 1);
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
    void FirstOpenArea()
    {
        VibratoManager.Instance.HeavyVibration();
        outline.fillAmount = 0;
        sellActive = false;
        StartCoroutine(buildScaling());
        GetComponent<Collider>().enabled = false;
        _aqFishCar.LevelUp();
    }

    IEnumerator buildScaling()
    {
        LevelSet(1f, true);
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
    void LevelSet(float waitTime, bool cameraActive)
    {
        //buildPrefab.SetActive(true);
        StartCoroutine(OpenBuyAreas(waitTime, cameraActive));
    }
    IEnumerator OpenBuyAreas(float waitTime, bool cameraActive)
    {
        yield return new WaitForSeconds(waitTime);
        if (cameraActive)
        {
            PlayerController.Instance.PlayerControlDeActive();
        }
        for (int i = 0; i < buyAreas.Length; i++)
        {
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
    }
}

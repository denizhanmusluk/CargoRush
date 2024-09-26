using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using HomaGames.HomaBelly;

public class BoxSellingInfoManager : MonoBehaviour
{
    private static BoxSellingInfoManager _instance = null;
    public static BoxSellingInfoManager Instance => _instance;
    public List<BoxSellingInfo> boxSellingInfos = new List<BoxSellingInfo>();
    public BoxSellingInfo box_SellingInfos;
    public GameObject infoPanelGO;
    public int priceValue = 0;
    public Button priceButton;
    public TextMeshProUGUI priceText;

    public GameObject totalPriceParentGO;
    public GameObject claimButtonGO;
    public GameObject advButtonGO;
    private void Awake()
    {
        _instance = this;
    }
    public void GetPriceButton_ADVClick()
    {
        string _tag = "DeliveryPerformanceDouble_RV";
        string adv_name = _tag;

        ADVManager.Instance.RewardedStart(GetPriceDouble,adv_name, true);
        priceButton.interactable = false;
        PlayerController.Instance.PlayerControl_ReActive();
        //GameManager.Instance.GameAnalyticsTag(tag);
        //GameManager.Instance.HomaAnalyticsTag(tag);


    }
    void GetPriceDouble(bool ticketActive)
    {
        string _tag = "DeliveryPerformanceDouble_RV";

        MoneyCreate(priceValue * 2, priceButton.transform, true);
        priceButton.interactable = false;
        StartCoroutine(ButtonClickDelay());

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
    public void GetPriceButtonClick()
    {
        //GameManager.Instance.MoneyUpdate(priceValue);
        MoneyCreate(priceValue, priceButton.transform, false);
        priceButton.interactable = false;
        StartCoroutine(ButtonClickDelay());
        PlayerController.Instance.PlayerControl_ReActive();
    }

    IEnumerator ButtonClickDelay()
    {
        yield return new WaitForSeconds(2f);
        CeoInfoManager.Instance.GetPrice();
        UIClose();
    }
    public void UIClose()
    {
        infoPanelGO.SetActive(false);
        PlayerController.Instance.PlayerControl_ReActive();

    }



    //////////////////////////////////////////
    public GameObject moneyPrefab;
    public Transform moneyTargetTR;
    public void MoneyCreate(int _moneyCount, Transform moneyCreatePosTR, bool RV_Active)
    {
        StartCoroutine(Money_Create(_moneyCount, moneyCreatePosTR , RV_Active));
    }
    IEnumerator Money_Create(int moneyCount, Transform moneyCreatePosTR, bool RV_Active)
    {
        int _moneyCount = moneyCount;
        if (_moneyCount < 10)
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

        if (RV_Active)
        {
            Analytics.ResourceFlowEvent(ResourceFlowType.Source, "Money", (float)moneyCount, (float)Globals.moneyAmount, null, " ManagerBonusRV", ResourceFlowReason.RewardedVideoAd);
        }
        else
        {
            Analytics.ResourceFlowEvent(ResourceFlowType.Source, "Money", (float)moneyCount, (float)Globals.moneyAmount, null, " ManagerBonus", ResourceFlowReason.Progression);
        }

    }
    IEnumerator MoneyMoveUI(Transform moneyTR)
    {
        Vector3 firstPos = moneyTR.position;
        Vector3 targetPos = moneyTR.position + new Vector3(UnityEngine.Random.Range(-200, 200), UnityEngine.Random.Range(-300, 300), 0);
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


    public void SetBonusText()
    {
        StartCoroutine(TextLerp());
    }
    IEnumerator TextLerp()
    {
        yield return new WaitForSeconds(1.5f);
        totalPriceParentGO.SetActive(true);
        float priceValCounter = 0;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += Time.deltaTime;
            priceValCounter = Mathf.Lerp(0, priceValue, counter);
            priceText.text =  ((int)priceValCounter).ToString();
            yield return null;
        }
        priceText.text = priceValue.ToString();

        claimButtonGO.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        advButtonGO.SetActive(true);
    }
}

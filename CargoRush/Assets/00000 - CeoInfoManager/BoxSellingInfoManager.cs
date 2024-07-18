using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BoxSellingInfoManager : MonoBehaviour
{
    private static BoxSellingInfoManager _instance = null;
    public static BoxSellingInfoManager Instance => _instance;
    public List<BoxSellingInfo> boxSellingInfos = new List<BoxSellingInfo>();
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
        string adv_name = "";
        ADVManager.Instance.RewardedStart(GetPriceDouble,adv_name);
        priceButton.interactable = false;
        PlayerController.Instance.PlayerControl_ReActive();
        string tag = "DeliveryPerformanceDoubleRewarded";
        GameManager.Instance.GameAnalyticsTag(tag);
    }
    void GetPriceDouble()
    {
        MoneyCreate(priceValue * 2, priceButton.transform);
        priceButton.interactable = false;
        StartCoroutine(ButtonClickDelay());
    }
    public void GetPriceButtonClick()
    {
        //GameManager.Instance.MoneyUpdate(priceValue);
        MoneyCreate(priceValue, priceButton.transform);
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
    public void MoneyCreate(int _moneyCount, Transform moneyCreatePosTR)
    {
        StartCoroutine(Money_Create(_moneyCount, moneyCreatePosTR));
    }
    IEnumerator Money_Create(int moneyCount, Transform moneyCreatePosTR)
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
        advButtonGO.SetActive(true);
    }
}

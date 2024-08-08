using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    private static ShopManager _instance = null;
    public static ShopManager Instance => _instance;
    //public ShopSettings shopSettings;
    public GameObject shopProgresGO;
    public Image shopProgresFill;
    public Image shopProgresFillBG;
    //public int technoTotalCount;
    //public int technoCurrentCount;

    //public int sportsTotalCount;
    //public int sportsCurrentCount;

    //public int toysTotalCount;
    //public int toysCurrentCount;

    [Range(0.0f, 1.0f)]

    [SerializeField] private float[] shopRatio = new float[3];


    public int[] shopCountTotal;
    public int[] shopCountCurrent = { 0, 0, 0 };
    public List<GameObject> newShopBuyArea = new List<GameObject>();
    public List<string> shopName = new List<string>();
    public Sprite[] shopSpriteList = new Sprite[4];
    public Sprite questionMark;

    public GameObject buyOthersGO;
    public float nextLevelShowRatio;

    public GameObject standOnlineGO;
    public TextMeshProUGUI ratioText;

    void Awake()
    {
        _instance = this;
    }
    void Start()
    {
        shopProgresGO = CollectProgressManager.Instance.shopProgresGO;
        shopProgresFill = CollectProgressManager.Instance.shopProgresFill;
        shopProgresFillBG = CollectProgressManager.Instance.shopProgresFillBG;
        ratioText = CollectProgressManager.Instance.ratioText;
        //StartCoroutine(ChildColorAlphaSet());
        //shopProgresGO.SetActive(false);
        StartCoroutine(StartDelay());
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(2f);
        for (int i = 1; i <= PlayerPrefs.GetInt("shopLevel" +PlayerPrefs.GetInt("level")); i++)
        {
            newShopBuyArea[i - 1].SetActive(true);
            newShopBuyArea[i - 1].GetComponent<BuyArea>().OpenAndActive();
            newShopBuyArea[i - 1].GetComponent<BuyArea>().buyActive = true;

        }

        if (PlayerPrefs.GetInt("tutorialseq1") == 1)
        {
            buyOthersGO.SetActive(true);
        }

        shopProgresFill.fillAmount = PlayerPrefs.GetFloat("shopprogressfill");
        ratioText.text = ((int)(PlayerPrefs.GetFloat("shopprogressfill") * 100)).ToString() + "/100";

        

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //SetProgress();
        }
    }
    int preCount;
    public void SetShopCount(int shopId,int shopValue, bool newOpen)
    {
        //if (PlayerPrefs.GetInt("shopLevel") == shopId)
        {
            preCount = shopCountCurrent[shopId];
            shopCountCurrent[shopId] += shopValue;
            CollectProgressManager.Instance.shopFirstIcon.sprite = shopSpriteList[shopId];
            //CollectProgressManager.Instance.shopTargetIcon.sprite = shopSpriteList[shopId + 1];
            //CollectProgressManager.Instance.questMarkImgGO.SetActive(false);

            if (shopId + 1 == PlayerPrefs.GetInt("shopLevel" + PlayerPrefs.GetInt("level")))
            {
                //CollectProgressManager.Instance.shopTargetIcon.sprite = shopSpriteList[shopId + 1];
                //CollectProgressManager.Instance.questMarkImgGO.SetActive(false);
            }
            else
            {
                //CollectProgressManager.Instance.shopTargetIcon.sprite = questionMark;
                //CollectProgressManager.Instance.questMarkImgGO.SetActive(true);
            }

            if (newOpen)
            {
                SetProgress(shopId , preCount);
            }
            else
            {

            }
    
        }
    }
    public void SetProgress(int shopId , int preValue)
    {
        StartCoroutine(SetSlider(shopId, preValue));

       
    }
    IEnumerator SetSlider(int shopId, int preVal)
    {

        shopProgresGO.gameObject.SetActive(true);
        shopProgresFill.fillAmount = (float)(preVal) / (float)shopCountTotal[shopId];
        shopProgresFillBG.fillAmount = (float)(shopCountCurrent[shopId]) / (float)shopCountTotal[shopId];
        //StartCoroutine(ChildColorAlphaSet());
        //GameManager.Instance.ui.Panel_Down();
        yield return new WaitForSeconds(1f);

        StartCoroutine(SliderFillAmountSet(shopId, preVal));
        yield return new WaitForSeconds(8f);
        //StartCoroutine(ChildColorAlphaSet(true));
        //GameManager.Instance.ui.Panel_Up();


        yield return new WaitForSeconds(1f);
        //shopProgresGO.gameObject.SetActive(false);
    }
    IEnumerator ChildColorAlphaSet()
    {


        float counter = 0;
        float SimulationSpeed = 1f;
        while (counter < 1f)
        {
            counter += SimulationSpeed * Time.deltaTime;

            foreach (var img in shopProgresGO.GetComponentsInChildren<Image>())
            {
                img.color = Color.Lerp(img.color, new Color(img.color.r, img.color.g, img.color.b, 1), counter);
                //img.color = new Color(img.color.r, img.color.g, img.color.b,  counter);
            }
            foreach (var txt in shopProgresGO.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.color = Color.Lerp(txt.color, new Color(txt.color.r, txt.color.g, txt.color.b, 1), counter);
                //txt.color = new Color(txt.color.r, txt.color.g, txt.color.b,  counter);
            }
            yield return null;
        }
        foreach (var img in shopProgresGO.GetComponentsInChildren<Image>())
        {
            img.color = new Color(img.color.r, img.color.g, img.color.b, 1);
        }
        foreach (var txt in shopProgresGO.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, 1);
        }


        yield return new WaitForSeconds(8f);

        counter = 0;

        while (counter < 1f)
        {
            counter += SimulationSpeed * Time.deltaTime;

            foreach (var img in shopProgresGO.GetComponentsInChildren<Image>())
            {
                img.color = Color.Lerp(img.color, new Color(img.color.r, img.color.g, img.color.b, 0), counter);

            }
            foreach (var txt in shopProgresGO.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.color = Color.Lerp(txt.color, new Color(txt.color.r, txt.color.g, txt.color.b, 0), counter);
            }
            yield return null;
        }
        foreach (var img in shopProgresGO.GetComponentsInChildren<Image>())
        {
            img.color = new Color(img.color.r, img.color.g, img.color.b, 0);
        }
        foreach (var txt in shopProgresGO.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, 0);
        }

    }

    IEnumerator SliderFillAmountSet(int shopID , int preVal)
    {
        float currentFill = (float)(preVal) / (float)(shopCountTotal[shopID]);
        float targetFill = (float)shopCountCurrent[shopID] / (float)(shopCountTotal[shopID]);
        float counter = 0f;

        while(counter < 1f)
        {
            counter += Time.deltaTime;
            shopProgresFill.fillAmount = Mathf.Lerp(currentFill, targetFill, counter);
            ratioText.text = ((int)(shopProgresFill.fillAmount * 100)).ToString() + "/100";
            yield return null;
        }
        PlayerPrefs.SetFloat("shopprogressfill", targetFill);
        if(targetFill >= shopRatio[shopID])
        {
            //CollectProgressManager.Instance.shopTargetIcon.sprite = shopSpriteList[shopID + 1];
            //CollectProgressManager.Instance.questMarkImgGO.SetActive(false);

            if (PlayerPrefs.GetInt("shopLevel" + PlayerPrefs.GetInt("level")) == shopID)
            {
                NewShopOpen();
            }
        }
        if (nextLevelShowRatio <= shopProgresFill.fillAmount)
        {
            CollectProgressManager.Instance.shopTargetIcon.sprite = shopSpriteList[1];
            CollectProgressManager.Instance.questMarkImgGO.SetActive(false);

        }
        else
        {
            CollectProgressManager.Instance.shopTargetIcon.sprite = questionMark;
        }
        if (0.55f <= shopProgresFill.fillAmount)
        {
            MapManager.Instance.MapButtonOpen();
        }
        //if (PlayerPrefs.GetInt(shopName[shopID]) < shopSettings._shopData[shopID].shopRatio.Length)
        //{
        //    if (targetFill > shopSettings._shopData[shopID].shopRatio[PlayerPrefs.GetInt(shopName[shopID])])
        //    {
        //        GetGem(shopSettings._shopData[shopID].priceGem[PlayerPrefs.GetInt(shopName[shopID])]);

        //        PlayerPrefs.SetInt(shopName[shopID], PlayerPrefs.GetInt(shopName[shopID]) + 1);
        //    }
        //}
    }
    void NewShopOpen()
    {
        PlayerPrefs.SetInt("shopLevel" + PlayerPrefs.GetInt("level"), PlayerPrefs.GetInt("shopLevel" + PlayerPrefs.GetInt("level")) + 1);

        newShopBuyArea[PlayerPrefs.GetInt("shopLevel" + PlayerPrefs.GetInt("level")) - 1].SetActive(true);
        newShopBuyArea[PlayerPrefs.GetInt("shopLevel" + PlayerPrefs.GetInt("level")) - 1].GetComponent<BuyArea>().OpenAndActive();
        StartCoroutine(ViewNewArea(newShopBuyArea[PlayerPrefs.GetInt("shopLevel" + PlayerPrefs.GetInt("level")) - 1]));
    }
    IEnumerator ViewNewArea(GameObject buyArea)
    {
        buyArea.GetComponent<BuyArea>().buyActive = true;
        if (buyArea.GetComponent<BuyCamera>() != null)
        {
            PlayerController.Instance.PlayerControlDeActive();
            buyArea.GetComponent<BuyCamera>().buyCamera.Priority = 50;
        }

        yield return new WaitForSeconds(2f);
        if (buyArea.GetComponent<BuyCamera>() != null)
        {
            PlayerController.Instance.PlayerControl_ReActive();
            buyArea.GetComponent<BuyCamera>().buyCamera.Priority = 0;
        }
    }

    //public void GetGem(int gemCount)
    //{
    //    GameManager.Instance.ui.GemCreate(gemCount);
    //}
}

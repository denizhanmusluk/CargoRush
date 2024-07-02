using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeoInfoManager : MonoBehaviour
{
    private static CeoInfoManager _instance = null;
    public static CeoInfoManager Instance => _instance;

    [SerializeField] int totalInfoTime = 60;
    [SerializeField] int infoTimeCounter = 0;


    public CeoInfoCharacter ceoInfoCharacter;
    public Transform ceoCreatePos;
    public Transform ceoTargetPos;
    public Transform ceoExitPos;

    public List<int> priceList = new List<int>();
    public List<string> productNameList = new List<string>();
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        if (PlayerPrefs.GetInt("boxcounteractive" + PlayerPrefs.GetInt("level")) == 0)
        {
            StartCoroutine(InfoCounter());
        }
        else
        {
            CeoActive();
        }
    }
    public void InfoCounterStarter()
    {
        StartCoroutine(InfoCounter());
    }
    IEnumerator InfoCounter()
    {
        infoTimeCounter = PlayerPrefs.GetInt("infocounter" + PlayerPrefs.GetInt("level"));
        while (infoTimeCounter < totalInfoTime)
        {
            infoTimeCounter++;
            PlayerPrefs.SetInt("infocounter" + PlayerPrefs.GetInt("level"), infoTimeCounter);
            yield return new WaitForSeconds(1f);
        }
        PlayerPrefs.SetInt("boxcounteractive" + PlayerPrefs.GetInt("level"), 1);
        infoTimeCounter = 0;
        PlayerPrefs.SetInt("infocounter" + PlayerPrefs.GetInt("level"), infoTimeCounter);
        CeoActive();

    }
    void CeoActive()
    {
        ceoInfoCharacter.transform.position = ceoCreatePos.position;
        ceoInfoCharacter.gameObject.SetActive(true);
        ceoInfoCharacter.GoToWaitingArea();
        IndicatorManager.Instance.IndicaorActive(ceoInfoCharacter.transform);
        TutorialManager.Instance.goToManagerGO.SetActive(true);
        StartCoroutine(CeoActiveDelay());
    }
    IEnumerator CeoActiveDelay()
    {
        yield return new WaitForSeconds(1f);
        IndicatorManager.Instance.IndicaorActive(ceoInfoCharacter.transform);
    }
    public void BoxUIOpen()
    {
        BoxSellingInfoManager.Instance.infoPanelGO.SetActive(true);
        BoxSellingInfoManager.Instance.priceButton.interactable = true;
        BoxValueInitialize();
    }
        
    void BoxValueInitialize()
    {
        int priceValue = 0;
        for (int i = 0; i < Globals.collectableLevel + 1; i++)
        {

            int boxCount = PlayerPrefs.GetInt("box" + (i + 1).ToString() + "counter" + PlayerPrefs.GetInt("level"));


            BoxSellingInfoManager.Instance.boxSellingInfos[i].gameObject.SetActive(true);
            BoxSellingInfoManager.Instance.boxSellingInfos[i].sellingBoxCount = boxCount;
            BoxSellingInfoManager.Instance.boxSellingInfos[i].productName = productNameList[i];
            BoxSellingInfoManager.Instance.boxSellingInfos[i].TextSet();
            //BoxSellingInfoManager.Instance.boxSellingInfos[i].boxCountText.text = productNameList[i] + " x" + PlayerPrefs.GetInt("box" + (i + 1).ToString() + "counter" + PlayerPrefs.GetInt("level")).ToString();

            priceValue += boxCount * priceList[i];
        }
        
        BoxSellingInfoManager.Instance.priceValue = priceValue;
        BoxSellingInfoManager.Instance.SetBonusText();
        //BoxSellingInfoManager.Instance.priceText.text = priceValue.ToString();
    }
    public void GetPrice()
    {
        ceoInfoCharacter.GoExit();
        PlayerPrefs.SetInt("boxcounteractive" + PlayerPrefs.GetInt("level"), 0);
        PlayerPrefs.SetInt("box1counter" + PlayerPrefs.GetInt("level"), 0);
        PlayerPrefs.SetInt("box2counter" + PlayerPrefs.GetInt("level"), 0);
        PlayerPrefs.SetInt("box3counter" + PlayerPrefs.GetInt("level"), 0);
        PlayerPrefs.SetInt("box4counter" + PlayerPrefs.GetInt("level"), 0);
       InfoCounterStarter();
    }


}

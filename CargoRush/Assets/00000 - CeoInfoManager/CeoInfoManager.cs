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
        //if (PlayerPrefs.GetInt("boxcounteractive" + PlayerPrefs.GetInt("level")) == 0)
        //{
        //    StartCoroutine(InfoCounter());
        //}
        //else
        //{
        //    CeoActive();
        //}
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

            if (PlayerPrefs.GetInt("tutorialcompleted") == 1)
            {
                infoTimeCounter++;
            }

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
        BoxSellingInfoManager.Instance.priceText.text = "";
        BoxSellingInfoManager.Instance.priceButton.interactable = true;
        BoxValueInitialize();
        PlayerController.Instance.PlayerControlDeActive();
    }

    void BoxValueInitialize()
    {
        int priceValue = 0;
        int totalBoxCount = 0;
        for (int i = 0; i < Globals.collectableLevel + 1; i++)
        {

            int boxCount = PlayerPrefs.GetInt((i + 1) + "boxcounter" + PlayerPrefs.GetInt("level"));
            Debug.Log("boxcount" + PlayerPrefs.GetInt((i + 1) + "boxcounter" + PlayerPrefs.GetInt("level")));

            //BoxSellingInfoManager.Instance.boxSellingInfos[i].gameObject.SetActive(true);
            //BoxSellingInfoManager.Instance.boxSellingInfos[i].sellingBoxCount = boxCount;
            //BoxSellingInfoManager.Instance.boxSellingInfos[i].productName = productNameList[i];
            //BoxSellingInfoManager.Instance.boxSellingInfos[i].TextSet();

            priceValue += boxCount * priceList[i];
            totalBoxCount += boxCount;
        }
        BoxSellingInfoManager.Instance.box_SellingInfos.gameObject.SetActive(true);
        BoxSellingInfoManager.Instance.box_SellingInfos.sellingBoxCount = totalBoxCount;
        BoxSellingInfoManager.Instance.box_SellingInfos.TextSet2();

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

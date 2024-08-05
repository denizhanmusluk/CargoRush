using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialManager : MonoBehaviour
{
    private static TutorialManager _instance = null;
    public static TutorialManager Instance => _instance;

    public GameObject goToManagerGO;
    public GameObject repairMachineGO;
    public GameObject clickUpgradeButtonGO;
    public GameObject newProductTutorialGO;
    public TextMeshProUGUI newProducttext;

    public GameObject repairFinishedGO;
    public GameObject rceycleTutorialGO;

    public GameObject bandTut_1;
    public GameObject bandTut_2;
    public GameObject bandTut_3;
    public GameObject lunch_Break;
    public GameObject click_skin_Tut_GO;

    public GameObject goToRepairMan_GO;

    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        StartCoroutine(StartDelay());
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(5f);
        TutorialCompletedCheck();
    }
    public void TutorialCompletedCheck()
    {
        if(PlayerPrefs.GetInt("tutorialcompleted") == 1)
        {
            PlayerPrefs.SetInt("missionactivator" + PlayerPrefs.GetInt("level"), 1);
            StarterMissions();
            StartCoroutine(TutorialCompletedCheckDelay());

            MapManager.Instance.mapButton.gameObject.SetActive(true);
            ShareManager.Instance.graphButton.SetActive(true);
            PurchaseManager.Instance.purchaseButton_GO.SetActive(true);
            SettingsManager.Instance.settingsButtonGO.SetActive(true);
            CollectProgressManager.Instance.dirtyProgressPanelGo.SetActive(true);
           
           if( ShopManager.Instance.standOnlineGO != null)
            {
                ShopManager.Instance.standOnlineGO.SetActive(true);
            }
        }
    }
    IEnumerator TutorialCompletedCheckDelay()
    {
        if (PlayerPrefs.GetInt("upgradeclicktutorial") == 1)
        {
            yield return new WaitForSeconds(2);
        }
        else
        {
            yield return new WaitForSeconds(10);
        }
        HRUpgradeManager.Instance.upgradeButton.SetActive(true);
        if (PlayerPrefs.GetInt("upgradeclicktutorial") == 0)
        {
            PlayerPrefs.SetInt("upgradeclicktutorial", 1);
            clickUpgradeButtonGO.SetActive(true);
        }
    }
    void StarterMissions()
    {
        MissionManager.Instance.OrderMissionStart();
        MissionManager.Instance.TapeBoxMissionStart();
        MissionManager.Instance.ShippingLineMissionStart();
        MissionManager.Instance.TapingLineMissionStart();
        if (PlayerPrefs.GetInt("skinactive") == 1)
        {
            StoreManager.Instance.storeButton.SetActive(true);
            //StoreManager.Instance.storeButtonTapTutorialGO.SetActive(true);
            //PlayerPrefs.SetInt("skinactive", 1);
        }
    }
 
}

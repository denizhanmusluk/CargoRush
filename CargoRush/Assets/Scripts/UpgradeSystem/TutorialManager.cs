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
            MapManager.Instance.mapButton.gameObject.SetActive(true);
            HRUpgradeManager.Instance.upgradeButton.SetActive(true);
            ShareManager.Instance.graphButton.SetActive(true);
            if (PlayerPrefs.GetInt("upgradeclicktutorial") == 0)
            {
                PlayerPrefs.SetInt("upgradeclicktutorial", 1);
                clickUpgradeButtonGO.SetActive(true);
            }

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

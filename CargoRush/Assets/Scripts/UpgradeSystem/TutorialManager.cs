using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    private static TutorialManager _instance = null;
    public static TutorialManager Instance => _instance;
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
            PlayerPrefs.SetInt("missionactivator", 1);
            StarterMissions();
        }
    }
    void StarterMissions()
    {
        MissionManager.Instance.OrderMissionStart();
        MissionManager.Instance.TapeBoxMissionStart();
        MissionManager.Instance.ShippingLineMissionStart();
        MissionManager.Instance.TapingLineMissionStart();
    }
}

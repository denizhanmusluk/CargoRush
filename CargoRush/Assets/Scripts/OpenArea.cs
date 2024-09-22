//using GameAnalyticsSDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HomaGames.HomaBelly;

public class OpenArea : MonoBehaviour
{
    [SerializeField] string areaName;
    private void OnEnable()
    {
        if (PlayerPrefs.GetInt(areaName + (PlayerPrefs.GetInt("level") + 1).ToString()) == 0)
        {
            PlayerPrefs.SetInt(areaName + (PlayerPrefs.GetInt("level") + 1).ToString(), 1);

            int levelId = (PlayerPrefs.GetInt("level") + 1);




            string tag = "Zone " + levelId.ToString() + " " + areaName;
            Analytics.Checkpoint(tag);
        }
    }
}

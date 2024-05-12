//using GameAnalyticsSDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenArea : MonoBehaviour
{
    [SerializeField] string areaName;
    private void OnEnable()
    {
        if (PlayerPrefs.GetInt(areaName) == 0)
        {
            PlayerPrefs.SetInt(areaName, 1);
            string str = areaName;
            float time = CoefficientTransformation.FormatSaniye(Globals.playTime);
            //GameAnalytics.NewDesignEvent(str, time);
            Debug.Log(str + time);
        }
    }
}

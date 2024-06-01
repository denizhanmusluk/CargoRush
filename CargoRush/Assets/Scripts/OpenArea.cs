//using GameAnalyticsSDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenArea : MonoBehaviour
{
    [SerializeField] string areaName;
    private void OnEnable()
    {
        if (PlayerPrefs.GetInt(areaName + (PlayerPrefs.GetInt("level") + 1).ToString()) == 0)
        {
            PlayerPrefs.SetInt(areaName + (PlayerPrefs.GetInt("level") + 1).ToString(), 1);
            string _tag = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-" + areaName;
            GameManager.Instance.GameAnalyticsTag(_tag);
            //GameAnalytics.NewDesignEvent(str);
        }
    }
}

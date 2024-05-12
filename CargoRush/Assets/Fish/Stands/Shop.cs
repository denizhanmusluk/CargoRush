using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public int shopIndex = 0;
    public int machineProductID = 0;
    private void OnEnable()
    {
        if(PlayerPrefs.GetInt("shopindex") < shopIndex)
        {
            PlayerPrefs.SetInt("shopindex", shopIndex);
        }
        if (machineProductID != 0)
        {
            MissionManager.Instance.MachineMission_Start(machineProductID);
        }
    }
}

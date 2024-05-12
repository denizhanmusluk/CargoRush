using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    public List<BuyBuild> _buyBuilds = new List<BuyBuild>();
    int opendBuildCount = 0;
    public void BuildOpen()
    {
        opendBuildCount++;
    }
    public void BuildCompleteCheck()
    {
        if (opendBuildCount >= _buyBuilds.Count)
        {
            AvailableForPurchase.Instance.OpenAreaLevelUp();
            opendBuildCount = 0;
        }
    }
    public void OpenNewBuild()
    {
        int _openedBuildCount = PlayerPrefs.GetInt("buildcount");

        _openedBuildCount++;

        PlayerPrefs.SetInt("buildcount", _openedBuildCount);

        //Debug.Log("Level " + Globals.currentLevel.ToString() + " New Build" + ":" + _openedBuildCount);


        //Debug.Log("ACILMIS BINA SAYISI" + _openedBuildCount);
        Debug.Log("GameAnalytics.NewDesignEvent(New Build + : + _openedBuildCount);");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainParent : MonoBehaviour
{
    [SerializeField] List<GameObject> vagonList = new List<GameObject>();
    private void Start()
    {
        OpenVagons();
    }
    public void OpenVagons()
    {
        int vagonCount = MRCUpgradeManager.Instance._characterUpgradeSettings.trainWagonCount[Globals.trainWagonLevel];
        for (int i = 0; i < vagonCount; i++)
        {
            vagonList[i].SetActive(true);
        }
    }
}

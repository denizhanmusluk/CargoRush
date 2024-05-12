using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct ProductsMission
{
    public int productID;
    public List<int> productCountMission;
    public List<int> productMissionPrice;

}
[CreateAssetMenu(menuName = "Scriptable Objects/Mission System/MissionSettings")]

public class MissionSettings : ScriptableObject
{

    [Header("       ==========PRODUCT MISSION=========")]

    [Header("       Product Mission")]
    [SerializeField] private ProductsMission[] productions;
    public ProductsMission[] _productions { get { return productions; } }



 

  


    [Header("       ==========MACHINE OPEN MISSION=========")]

    [Header("       MACHINE Mission")]

    [SerializeField] private int[] openMachineMissionPrice;
    public int[] _openMachineMissionPrice { get { return openMachineMissionPrice; } }





    [Header("        Stand Mission")]
    [SerializeField] private int[] standCountMission;
    public int[] _standCountMission { get { return standCountMission; } }


    [SerializeField] private int[] standMissionPrice;
    public int[] _standMissionPrice { get { return standMissionPrice; } }





    [Header("        Skin Mission")]
    [SerializeField] private int[] skinCountMission;
    public int[] _skinCountMission { get { return skinCountMission; } }


    [SerializeField] private int[] skinMissionPrice;
    public int[] _skinMissionPrice { get { return skinMissionPrice; } }

    [SerializeField] private string[] skinName;
    public string[] _skinName { get { return skinName; } }

}

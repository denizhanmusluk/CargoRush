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



    [Header("        Order Mission")]
    [SerializeField] private int[] orderCountMission;
    public int[] _orderCountMission { get { return orderCountMission; } }


    [SerializeField] private int[] orderMissionPrice;
    public int[] _orderMissionPrice { get { return orderMissionPrice; } }

    [SerializeField] private string[] orderName;
    public string[] _orderName { get { return orderName; } }

    [Header("        Order Mission")]
    [SerializeField] private int[] specialOrderCountMission;
    public int[] _specialOrderCountMission { get { return specialOrderCountMission; } }


    [SerializeField] private int[] specialOrderMissionPrice;
    public int[] _specialOrderMissionPrice { get { return specialOrderMissionPrice; } }

    [SerializeField] private string[] specialOrderName;
    public string[] _specialOrderName { get { return specialOrderName; } }


    [Header("        Tape Box Mission")]
    [SerializeField] private int[] tapeBoxCountMission;
    public int[] _tapeBoxCountMission { get { return tapeBoxCountMission; } }


    [SerializeField] private int[] tapeBoxMissionPrice;
    public int[] _tapeBoxMissionPrice { get { return tapeBoxMissionPrice; } }

    [SerializeField] private string[] tapeBoxName;
    public string[] _tapeBoxName { get { return tapeBoxName; } }





    [Header("        Buy ShippingLine Mission")]
    [SerializeField] private int[] shippingCountMission;
    public int[] _shippingCountMission { get { return shippingCountMission; } }


    [SerializeField] private int[] shippingMissionPrice;
    public int[] _shippingMissionPrice { get { return shippingMissionPrice; } }

    [SerializeField] private string[] shippingName;
    public string[] _shippingName { get { return shippingName; } }

    [SerializeField] private string[] shippingNameTut;
    public string[] _shippingNameTut { get { return shippingNameTut; } }

    [Header("        Buy Special ShippingLine Mission")]
    [SerializeField] private int[] specialShippingCountMission;
    public int[] _specialShippingCountMission { get { return specialShippingCountMission; } }


    [SerializeField] private int[] specialShippingMissionPrice;
    public int[] _specialShippingMissionPrice { get { return specialShippingMissionPrice; } }

    [SerializeField] private string[] specialShippingName;
    public string[] _specialShippingName { get { return specialShippingName; } }

    [SerializeField] private string[] specialShippingNameTut;
    public string[] _specialShippingNameTut { get { return specialShippingNameTut; } }

    [Header("        Buy TapingLine Mission")]
    [SerializeField] private int[] tapingLineCountMission;
    public int[] _tapingLineCountMission { get { return tapingLineCountMission; } }


    [SerializeField] private int[] tapingLineMissionPrice;
    public int[] _tapingLineMissionPrice { get { return tapingLineMissionPrice; } }

    [SerializeField] private string[] tapingLineName;
    public string[] _tapingLineName { get { return tapingLineName; } }


    [SerializeField] private string[] tapingLineNameTut;
    public string[] _tapingLineNameTut { get { return tapingLineNameTut; } }



    [Header("        New Map Mission")]
    [SerializeField] private int[] newMapCountMission;
    public int[] _newMapCountMission { get { return newMapCountMission; } }


    [SerializeField] private int[] newMapMissionPrice;
    public int[] _newMapMissionPrice { get { return newMapMissionPrice; } }

    [SerializeField] private string[] newMapName;
    public string[] _newMapName { get { return newMapName; } }

    [SerializeField] private string[] newMapNameTut;
    public string[] _newMapNameTut { get { return newMapNameTut; } }

    /////////////////////////////////////////
}

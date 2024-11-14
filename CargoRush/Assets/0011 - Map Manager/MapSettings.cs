using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Scriptable Objects/MapSettings")]

public class MapSettings : ScriptableObject
{
    [Header("       Map Offline Earning")]
    [SerializeField] private int maxOfflineEarning;
    public int _maxOfflineEarning { get { return maxOfflineEarning; } }

    [SerializeField] private int pricePerPeriod;
    public int _pricePerPeriod { get { return pricePerPeriod; } }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Scriptable Objects/IS Settings")]

public class ISSettings : ScriptableObject
{
    [Header("       IS Periods")]
    [SerializeField] private int firstIS_Time;
    public int _firstIS_Time { get { return firstIS_Time; } }

    [SerializeField] private int period_IS;
    public int _period_IS { get { return period_IS; } }
}

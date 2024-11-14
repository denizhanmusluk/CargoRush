using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Scriptable Objects/Daily Rewarded Settings")]

public class DailyRewardedSettings : ScriptableObject
{
    [Header("       Cash Reward Based on Level ")]
    [SerializeField] private int[] cashRewardAmount;
    public int[] _cashRewardAmount { get { return cashRewardAmount; } }
}

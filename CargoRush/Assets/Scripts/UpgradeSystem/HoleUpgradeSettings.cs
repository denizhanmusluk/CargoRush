using UnityEngine;
[CreateAssetMenu(menuName = "Scriptable Objects/Upgrade System/HoleUpgradeSettings")]

public class HoleUpgradeSettings : ScriptableObject
{
    public int[] holeCollectLevel;

    [Header("       HOLE RADIUS")]
    //public float throwSpeedDivideRatio;
    public float[] holeRadius;
    public int[] holeRadiusCost;
    [Header("       HOLE SPEED")]
    public float[] holeSpeed;
    public int[] holeSpeedCost;

    [Header("       HOLE TIME")]
    public int[] holeTime;
    public int[] holeTimeCost;


    [Header("       COLLECT ENV COUNT")]

    [SerializeField] private int[] envCount;
    public int[] _envCount { get { return envCount; } }

    [Header("       Reward Activate")]
    [SerializeField] private int rewardPeriod;
    public int _rewardPeriod { get { return rewardPeriod; } }
    [Header("       Hole Radius Inc.")]
    [SerializeField] private float holeRadInc;
    public float _holeRadInc { get { return holeRadInc; } }
    //[SerializeField] private bool[] rewardActive;
    //public bool[] _rewardActive { get { return rewardActive; } }
}

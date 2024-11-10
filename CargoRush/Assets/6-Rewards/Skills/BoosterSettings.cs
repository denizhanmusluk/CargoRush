using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Scriptable Objects/Booster System/BoosterSettings")]

public class BoosterSettings : ScriptableObject
{
    [Header("       SPEED BOOSTER")]
    [SerializeField] private int speedBoosterPeriod;
    public int _speedBoosterPeriod { get { return speedBoosterPeriod; } }

    [SerializeField] private int speedBoosterDuration;
    public int _speedBoosterDuration { get { return speedBoosterDuration; } }


    [Header("       CAPACITY BOOSTER")]
    [SerializeField] private int capacityBoosterPeriod;
    public int _capacityBoosterPeriod { get { return capacityBoosterPeriod; } }

    [SerializeField] private int capacityBoosterDuration;
    public int _capacityBoosterDuration { get { return capacityBoosterDuration; } }

    [SerializeField] private int capacityValue;
    public int _capacityValue { get { return capacityValue; } }



    [Header("       DOUBLE INCOME BOOSTER")]
    [SerializeField] private int doubleIncomeBoosterPeriod;
    public int _doubleIncomeBoosterPeriod { get { return doubleIncomeBoosterPeriod; } }

    [SerializeField] private int doubleIncomeBoosterDuration;
    public int _doubleIncomeBoosterDuration { get { return doubleIncomeBoosterDuration; } }

    [Header("       MONEY REWARDED BOOSTER")]
    [SerializeField] private int moneyRewardedBoosterPeriod;
    public int _moneyRewardedBoosterPeriod { get { return moneyRewardedBoosterPeriod; } }

    [Header("       WORKER BOOSTER")]
    [SerializeField] private int workerBoosterPeriod;
    public int _workerBoosterPeriod { get { return workerBoosterPeriod; } }

    [SerializeField] private int workerBoosterDuration;
    public int _workerBoosterDuration { get { return workerBoosterDuration; } }

    [SerializeField] private int workerStackFactor;
    public int _workerStackFactor { get { return workerStackFactor; } }

    [SerializeField] private float workerSpeedFactor;
    public float _workerSpeedFactor { get { return workerSpeedFactor; } }

    [Header("       MACHINE BOOSTER")]
    [SerializeField] private int machineBoosterPeriod;
    public int _machineBoosterPeriod { get { return machineBoosterPeriod; } }

    [SerializeField] private int machineBoosterDuration;
    public int _machineBoosterDuration { get { return machineBoosterDuration; } }
    [SerializeField] private float machineSpeedFactor;
    public float _machineSpeedFactor { get { return machineSpeedFactor; } }
}

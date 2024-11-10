using UnityEngine;
[CreateAssetMenu(menuName = "Scriptable Objects/Upgrade System/CharacterUpgradeSettings")]
public class CharacterUpgradeSettings : ScriptableObject
{
    [Header("       MAGNET RADIUS")]
    public float[] magnetRadius;


    [Header("       CHARACTER SPEED")]
    public float[] characterSpeed;
    public int[] characterSpeedCost;

    [Header("       STACK CAPACITY")]
    public int[] stackCapacity;
    public int[] stackCapacityCost;


    [Header("       WORKER MOVE SPEED")]
    //public float throwSpeedDivideRatio;
    public float[] workerMoveSpeed;
    public int[] workerMoveSpeedCost;

    [Header("       WORKER CAPACITY")]
    public float[] workerCapacity;
    public int[] workerCapacityCost;

    [Header("       WORKER NO")]
    public int[] workerNo;
    public int[] workerNoCost;


    [Header("       MACHINE UPGRADE")]
    public float[] machineSpeed;
    public int[] machineSpeedCost;

    public int[] machineErrorBoxCount;
    public int[] machineErrorBoxCount_Cost;

    [Header("       CUSTOMER UPGRADE")]
    public int[] customerEarning;
    public int[] customerEarningCost;

    public int[] customerCooldown;
    public int[] customerCooldownCost;

    [Header("       REPAIR UPGRADE")]
    public int[] repairRunTime;
    public int[] repairRunTimeCost;

    public int[] repairSpeed;
    public int[] repairSpeedCost;


    [Header("       TRAIN UPGRADE")]
    public int[] trainCapacity;
    public int[] trainCapacityCost;

    public float[] trainSpeedFactor;
    public int[] trainSpeedFactorCost;
}

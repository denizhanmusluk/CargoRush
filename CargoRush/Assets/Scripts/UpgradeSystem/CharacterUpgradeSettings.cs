using UnityEngine;
[CreateAssetMenu(menuName = "Scriptable Objects/Upgrade System/CharacterUpgradeSettings")]
public class CharacterUpgradeSettings : ScriptableObject
{
    [Header("       MAGNET RADIUS")]
    public float throwSpeedDivideRatio;
    public float[] magnetRadius;
    public int[] magnetRadiusCost;
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
}

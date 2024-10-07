using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct QuestData
{
    public GameObject[] questPrefab;
    public int[] priceMoney;
    public int[] totalCount;
}
[CreateAssetMenu(menuName = "Scriptable Objects/Quest Settings")]
public class QuestSettings : ScriptableObject
{
    [Header("Quest Data")]
    [SerializeField] private QuestData[] quaestData;
    public QuestData[] _quaestData { get { return quaestData; } }
}

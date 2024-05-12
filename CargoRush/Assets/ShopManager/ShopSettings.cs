using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Datas
{
    public int[] openShopCount;
    [Range(0.0f, 1.0f)]
    public float[] shopRatio;
    public int[] priceGem;
}
[CreateAssetMenu(menuName = "Scriptable Objects/Shop Settings")]

public class ShopSettings : ScriptableObject
{
    [Header("Shop Data")]
    [SerializeField] private Datas[] shopData;
    public Datas[] _shopData { get { return shopData; } }

    [Header("Shop Data")]
    [SerializeField] private Datas[] shopData2;
    public Datas[] _shopData2 { get { return shopData2; } }
}

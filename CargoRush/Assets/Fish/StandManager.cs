using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandManager : MonoBehaviour
{
    private static StandManager _instance = null;
    public static StandManager Instance => _instance;

    public List<Stand> standList;
    public List<FishDropArea> fishDropAreaList;

    private void Awake()
    {
        _instance = this;
    }

}

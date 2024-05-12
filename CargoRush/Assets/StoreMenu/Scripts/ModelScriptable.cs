using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Character/ModelScriptable")]

public class ModelScriptable : ScriptableObject
{

    [Header("NEW Models")]

    [SerializeField] private GameObject[] newModels;
    public GameObject[] _newModels { get { return newModels; } }



    [Header("Star Models")]

    [SerializeField] private GameObject[] starModels;
    public GameObject[] _starModels { get { return starModels; } }

    [Header("Star Models")]

    [SerializeField] private int[] starModelCost;
    public int[] _starModelCost { get { return starModelCost; } }

    [Header("Popular Models")]

    [SerializeField] private GameObject[] popularModels;
    public GameObject[] _popularModels { get { return popularModels; } }


    //[Header("Knife Models")]

    //[SerializeField] private GameObject[] knifeModels;
    //public GameObject[] _knifeModels { get { return knifeModels; } }
}
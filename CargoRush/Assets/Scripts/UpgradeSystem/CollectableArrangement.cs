using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Scriptable Objects/Collectable/CollectableSettings")]

public class CollectableArrangement : ScriptableObject
{
    public string[] Collectables;
    public string[] Collectables2;
    public string[] _Collectables2 { get { return Collectables2; } }


}

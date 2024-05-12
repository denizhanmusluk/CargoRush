using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiCaseModelActive : MonoBehaviour
{
    [SerializeField] GameObject activeObject;
    private void OnEnable()
    {
        activeObject.transform.localPosition = Vector3.zero;
    }
}

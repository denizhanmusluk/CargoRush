using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseOtherObject : MonoBehaviour
{
    [SerializeField] GameObject closeObject;
    private void OnEnable()
    {
        closeObject.SetActive(false);
        closeObject.transform.position = transform.position;
    }
}

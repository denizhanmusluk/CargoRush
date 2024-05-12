using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoes : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject[] shoes;
    private void OnEnable()
    {
        int randomSelect = Random.Range(0, shoes.Length);
        shoes[randomSelect].SetActive(true);
    }
}

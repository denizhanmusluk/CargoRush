using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceSpot : MonoBehaviour
{
    [SerializeField] GameObject light1, light2;
    void Start()
    {
        StartCoroutine(SpotLight());
    }
    IEnumerator SpotLight()
    {
        while (true)
        {
            light1.SetActive(true);
            light2.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            light1.SetActive(false);
            light2.SetActive(true);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostPopUp : MonoBehaviour
{
    public GameObject noThnks_GO;
    private void OnEnable()
    {
        noThnks_GO.SetActive(false);
        StartCoroutine(OpenDelay());
    }
    IEnumerator OpenDelay()
    {
        yield return new WaitForSeconds(1.5f);
        noThnks_GO.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleUpgradeTap : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(DeActivation());
    }
    IEnumerator DeActivation()
    {
        yield return new WaitForSeconds(3f);
        gameObject.SetActive(false);
    }
}

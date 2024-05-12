using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapAnimation : MonoBehaviour
{
    private void OnEnable()
    {
        GetComponent<Animator>().enabled = false;
        StartCoroutine(StartDelayedAnimation());
    }
    IEnumerator StartDelayedAnimation()
    {
        float randomTime = Random.Range(0f, 0.2f);
        yield return new WaitForSeconds(randomTime);
        GetComponent<Animator>().enabled = true;
    }
}

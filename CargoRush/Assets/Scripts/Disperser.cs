using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disperser : MonoBehaviour
{
    public Transform impulseTargetTR;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            other.GetComponent<PlayerController>()._stackCollect.DisperseCollected(impulseTargetTR);
            StartCoroutine(SetCollider());
        }
    }

    IEnumerator SetCollider()
    {
        FishDropArea.Instance.WallColliderReset();
        GetComponent<Collider>().isTrigger = false;
        yield return new WaitForSeconds(1f);
        GetComponent<Collider>().isTrigger = true;
    }
}

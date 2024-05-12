using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roof : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Collider>().isTrigger = true;
        StartCoroutine(SetCollider());
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collectable>() != null)
        {
            if (other.GetComponent<Collectable>().roofPushActive)
            {
                other.GetComponent<Collectable>().DisperseCollected();
            }
        }
    }
    IEnumerator SetCollider()
    {
        yield return new WaitForSeconds(2f);
        GetComponent<Collider>().isTrigger = false;
        Destroy(this, 1f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductDestroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collector>() != null && !other.GetComponent<Collector>().hitOutSd)
        {
            other.GetComponent<Collector>().hitOutSd = true;
            //Destroy(other.GetComponent<Collector>().shadowGO);
            other.GetComponent<Collector>().collectorActive = false;
            other.GetComponent<Collector>().pushActive = false;

            int layer = LayerMask.NameToLayer("stackedproduct");
            other.gameObject.layer = layer;
            //Destroy(other.GetComponent<Collector>());
            if (other.GetComponent<Collector>().shadowGO != null)
            {
                Destroy(other.GetComponent<Collector>().shadowGO);
            }
            FishDropArea.Instance.proType[other.GetComponent<Collector>().productId].productList.Remove(other.GetComponent<Collectable>());
            Destroy(other.gameObject);
        }
    }
}

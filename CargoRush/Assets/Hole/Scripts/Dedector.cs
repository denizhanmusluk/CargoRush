using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dedector : MonoBehaviour
{
    //public Transform rotatorTR;
    //public Transform targetCenterTR;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Environments>() != null)
        {
            Environments collectable = other.GetComponent<Environments>();
            if (collectable.collectActive && collectable.collectLevel <= Globals.holeRadiusLevel)
            {
                collectable.collectActive = false;
                collectable.triggerActive = true;
                collectable.GetComponent<Rigidbody>().isKinematic = false;
                collectable.ForceObject(transform);
                VibratoManager.Instance.LightVibration();
            }

        }
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.GetComponent<Environments>() != null)
    //    {
    //        Environments collectable = other.GetComponent<Environments>();
    //        if (collectable.collectActive && collectable.collectLevel <= Globals.holeRadiusLevel)
    //        {
    //            collectable.collectActive = false;
    //            collectable.triggerActive = true;
    //            //collectable.GetComponent<Rigidbody>().isKinematic = false;
    //            collectable.ForceObject(targetCenterTR);
    //            collectable.transform.parent = rotatorTR;
    //        }

    //    }
    //}
    //private void OnTriggerStay(Collider other)
    //{ 
    //    if (other.GetComponent<Environments>() != null)
    //    {
    //        Environments collectable = other.GetComponent<Environments>();
    //        if (collectable.collectActive && collectable.collectLevel > Globals.holeRadiusLevel)
    //        {
    //            collectable.collectActive = false;
    //            collectable.triggerActive = true;
    //            //collectable.GetComponent<Rigidbody>().isKinematic = false;
    //            //collectable.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
    //            collectable.ForceLockedObject(transform);
    //        }

    //    }
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.GetComponent<Environments>() != null)
    //    {
    //        Environments collectable = other.GetComponent<Environments>();
    //        if (collectable.collectLevel <= Globals.holeRadiusLevel)
    //        {
    //            if (collectable.transform.position.y >= 0f)
    //            {
    //                collectable.triggerActive = false;
    //                StartCoroutine(EnvironmentRB_Set(collectable));
    //            }
    //        }

    //    }
    //    if (other.GetComponent<Environments>() != null)
    //    {
    //        Environments collectable = other.GetComponent<Environments>();
    //        if (!collectable.collectActive && collectable.collectLevel > Globals.holeRadiusLevel)
    //        {
    //            if (collectable.transform.position.y >= 0f)
    //            {
    //                collectable.triggerActive = false;
    //            }
    //        }

    //    }
    //}

    IEnumerator EnvironmentRB_Set(Environments collectable)
    {
        float counter = 0f;
        while (counter < 1f)
        {
            counter += Time.deltaTime;
            if (collectable.triggerActive)
            {
                break;
            }
            yield return null;
        }
        if(counter >= 1f)
        {
            if (collectable.transform.position.y >= 0f)
            {
                //collectable.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                yield return new WaitForSeconds(0.5f);
                collectable.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
    }
    //private void Update()
    //{
    //    rotatorTR.Rotate(0, 300 * Time.deltaTime, 0);
    //}
}

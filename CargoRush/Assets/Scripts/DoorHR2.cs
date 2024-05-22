using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHR2 : MonoBehaviour
{
    [SerializeField] Animator doorAnimator;
    bool isOpen = false;
    [SerializeField] bool customerActive = false;
    public GameObject frontGO, backGO;

    [SerializeField] bool frontInActive = false;
    [SerializeField] bool backInActive = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            if (!isOpen)
            {
                isOpen = true;

                if (Vector3.Distance(other.transform.position, frontGO.transform.position) < Vector3.Distance(other.transform.position, backGO.transform.position))
                {

                    doorAnimator.SetBool("openfront", true);
                    frontInActive = true;
                    backInActive = false;

                }
                else
                {
                    doorAnimator.SetBool("openback", true);
                    frontInActive = false;
                    backInActive = true;
                }


            }
         
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            if (isOpen)
            {
                isOpen = false;
                if (Vector3.Distance(other.transform.position, frontGO.transform.position) > Vector3.Distance(other.transform.position, backGO.transform.position))
                {
                
                    if (frontInActive)
                    {
                        doorAnimator.SetBool("openfront", false);
                        frontInActive = false;
                    }
                    else
                    {
                        doorAnimator.SetBool("openback", false);
                        backInActive = false;
                    }

                }
                else
                {
                    if (backInActive)
                    {
                        doorAnimator.SetBool("openback", false);
                        backInActive = false;
                    }
                   else
                    {
                        doorAnimator.SetBool("openfront", false);
                        frontInActive = false;
                    }
                }
            }
        }
  
    }
}

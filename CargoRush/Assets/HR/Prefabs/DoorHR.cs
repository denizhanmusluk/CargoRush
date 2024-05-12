using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHR : MonoBehaviour
{
    [SerializeField] Animator doorAnimator;
    bool isOpen = false;
    [SerializeField] bool customerActive = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null || other.GetComponent<AIWorker>() != null)
        {
            if (!isOpen)
            {
                doorAnimator.SetBool("openactive", true);
                isOpen = true;
            }
        }
        if(customerActive && other.GetComponent<AIMarketCustomer>() != null)
        {
            if (!isOpen)
            {
                doorAnimator.SetBool("openactive", true);
                isOpen = true;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null || other.GetComponent<AIWorker>() != null)
        {
            if (!isOpen)
            {
                doorAnimator.SetBool("openactive", true);
                isOpen = true;
            }
        }

        if (customerActive && other.GetComponent<AIMarketCustomer>() != null)
        {
            if (!isOpen)
            {
                doorAnimator.SetBool("openactive", true);
                isOpen = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null || other.GetComponent<AIWorker>() != null)
        {
            if (isOpen)
            {
                doorAnimator.SetBool("openactive", false);
                isOpen = false;
            }
        }
        if (customerActive && other.GetComponent<AIMarketCustomer>() != null)
        {
            if (isOpen)
            {
                doorAnimator.SetBool("openactive", false);
                isOpen = false;
            }
        }
    }
}

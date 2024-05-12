using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Door : MonoBehaviour
{
    [SerializeField] bool wievAllActive;
    [SerializeField] Transform leftDoor;
    [SerializeField] Transform rightDoor;
    [SerializeField] Transform leftTarget;
    [SerializeField] Transform rightTarget;

    Vector3 leftFirstPos = Vector3.zero;
    Vector3 rightFirstPos = Vector3.zero;
    bool isOpen = false;
    Collider collider;
    NavMeshObstacle[] navMeshObs;
    private void Awake()
    {
        collider = GetComponent<Collider>();
    }
    private void Start()
    {
        navMeshObs = GetComponentsInChildren<NavMeshObstacle>();
        StartCoroutine(StartDelay());
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(3f);
        collider.enabled = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if ((other.GetComponent<AIMarketCustomer>() != null || other.GetComponent<AIWorker>() != null || other.GetComponent<CEOCharacter>() != null || other.GetComponent<PlayerController>() != null || other.GetComponent<VipCustomer>() != null) || wievAllActive)
        {
            if (!isOpen)
            {
                StartCoroutine(OpenDoor());
                isOpen = true;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if ((other.GetComponent<AIMarketCustomer>() != null || other.GetComponent<AIWorker>() != null || other.GetComponent<CEOCharacter>() != null || other.GetComponent<PlayerController>() != null || other.GetComponent<VipCustomer>()) || wievAllActive)
        {
            if (!isOpen)
            {
                StartCoroutine(OpenDoor());
                isOpen = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if ((other.GetComponent<AIMarketCustomer>() != null || other.GetComponent<AIWorker>() != null || other.GetComponent<CEOCharacter>() != null || other.GetComponent<PlayerController>() != null || other.GetComponent<VipCustomer>()) || wievAllActive)
        {
            if (isOpen)
            {
                StartCoroutine(CloseDoor());
                isOpen = false;
            }
        }
    }
    IEnumerator OpenDoor()
    {
        foreach(var navObs in navMeshObs)
        {
            navObs.enabled = false;
        }
        float speed = 2f;
        float value = 0f;
        float counter = 0;
        while(counter < Mathf.PI / 2)
        {
            counter += speed * Time.deltaTime;
            value = Mathf.Sin(counter);
            leftDoor.localPosition = Vector3.Lerp(leftFirstPos,leftTarget.localPosition, value);
            rightDoor.localPosition = Vector3.Lerp(rightFirstPos,rightTarget.localPosition, value);
            yield return null;
        }
    }


    IEnumerator CloseDoor()
    {
        foreach (var navObs in navMeshObs)
        {
            navObs.enabled = true;
        }
        float speed = 2f;
        float value = 0f;
        float counter = 0;
        while (counter < Mathf.PI / 2)
        {
            counter += speed * Time.deltaTime;
            value = Mathf.Sin(counter);

            leftDoor.localPosition = Vector3.Lerp(leftTarget.localPosition, leftFirstPos, value);
            rightDoor.localPosition = Vector3.Lerp(rightTarget.localPosition, rightFirstPos, value);
            yield return null;
        }
        isOpen = false;
    }
}

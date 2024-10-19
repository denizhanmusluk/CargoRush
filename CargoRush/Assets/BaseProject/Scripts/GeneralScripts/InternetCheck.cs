using UnityEngine;
using System.Collections;

public class InternetCheck : MonoBehaviour
{
    public GameObject notConnection_GO;
    bool internetActive;

    private void Start()
    {
        StartCoroutine(CheckInternetConnection());
    }
    IEnumerator CheckInternetConnection()
    {
        while (true)
        {
            if (Application.internetReachability == NetworkReachability.NotReachable)
            {
                internetActive = true;
                notConnection_GO.SetActive(true);
            }
            else
            {
                internetActive = false;
                notConnection_GO.SetActive(false);
            }
            yield return new WaitForSeconds(1);
        }
    }
}

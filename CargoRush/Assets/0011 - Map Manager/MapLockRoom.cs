using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLockRoom : MonoBehaviour
{
    [SerializeField] GameObject lockRoomUI_GO;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            lockRoomUI_GO.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            lockRoomUI_GO.SetActive(false);
        }
    }
}

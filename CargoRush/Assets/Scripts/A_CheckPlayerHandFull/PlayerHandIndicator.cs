using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandIndicator : MonoBehaviour
{

    [SerializeField] private LineRenderer lineRenderer; 

    [SerializeField] private Transform packMachine1EklemeYeri;
    [SerializeField] private Transform packMachine2EklemeYeri;

    private bool isPassedOnTrigger = false;
    // CollectID 1 ise ve type 1 ise elindekleri ilk bant makine bir göister
    // COllectID 1 ise ve type 2 ise pembe box bant alanı göster
    
    //
    private void Start()
    {
        CheckIfThisShouldWork();
        lineRenderer.gameObject.SetActive(false);
        lineRenderer.positionCount = 2; 
    }

    private void Update()
    {
        lineRenderer.SetPosition(0,PlayerController.Instance.transform.position);
        CheckPlayerHand();
    }

    private void CheckPlayerHand()
    {
        if(!isPassedOnTrigger) return; 
        CheckIfThisShouldWork();
     
        var playerStackList = PlayerController.Instance._stackCollect.collectionTrs;
        if (playerStackList.Count <= 0)
        {
            lineRenderer.gameObject.SetActive(false);
            isPassedOnTrigger=false;
            return;
        }
        lineRenderer.gameObject.SetActive(true);
        foreach (var collectable in playerStackList)
        {
            switch (collectable.collectType)
            {
                case CollectType.Type1 when collectable.collectID == 1:
                    lineRenderer.SetPosition(1,packMachine1EklemeYeri.position);
                    return;
                case CollectType.Type2 when collectable.collectID == 1:
                    lineRenderer.SetPosition(1,packMachine2EklemeYeri.position);
                    return;
                default:
                    lineRenderer.gameObject.SetActive(false);
                    isPassedOnTrigger=false;
                    return;
            }
        }
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            isPassedOnTrigger = true;
        }
    }

    private void CheckIfThisShouldWork()
    {
        if(PlayerPrefs.HasKey("playerHandIndicator"))
            Destroy(gameObject);
    }
}

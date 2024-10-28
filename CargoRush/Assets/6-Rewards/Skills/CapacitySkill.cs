using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CapacitySkill : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI viewCounterText;
    [SerializeField] int viewTime;
    int viewTimeCounter = 0;
    bool collectActive = true;
    [SerializeField] GameObject cicrcle;
    [SerializeField] GameObject particleGO;
    private void OnTriggerEnter(Collider other)
    {
        //if (other.GetComponent<PlayerController>() != null && collectActive)
        //{
        //    cicrcle.SetActive(false);
        //    collectActive = false;
        //    particleGO.SetActive(true);
        //    particleGO.transform.parent = null;
        //    PopUpManager.Instance.BoostPopUpOpen(1);
        //    PopUpManager.Instance.BoosterInvoke();
        //    gameObject.SetActive(false);
        //    PlayerController.Instance.PlayerControlDeActive();
        //}
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && collectActive && !other.GetComponent<PlayerController>().pressJoystick && !Globals.goToCeoActive)
        {
            cicrcle.SetActive(false);
            collectActive = false;
            particleGO.SetActive(true);
            particleGO.transform.parent = null;
            PopUpManager.Instance.BoostPopUpOpen(1);
            PopUpManager.Instance.BoosterInvoke();
            gameObject.SetActive(false);
            PlayerController.Instance.PlayerControlDeActive();
        }
    }
    private void Start()
    {
        StartCoroutine(ViewCounter());
    }
    IEnumerator ViewCounter()
    {
        while (viewTimeCounter < viewTime)
        {
            viewTimeCounter++;
            viewCounterText.text = ConvertSecondToMinSec.Converter(viewTime - viewTimeCounter);
            yield return new WaitForSeconds(1f);
        }
        Globals.isCapacityRewardCreated = false;
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HoverboardSkill : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI viewCounterText;
    [SerializeField] int viewTime;
    int viewTimeCounter = 0;
    bool collectActive = true;
    [SerializeField] GameObject cicrcle;
    [SerializeField] GameObject particleGO;
    int rewardSelect = 0;
    public List<GameObject> speedModelList = new List<GameObject>();
    private void OnTriggerEnter(Collider other)
    {
        //if (other.GetComponent<PlayerController>() != null && collectActive)
        //{
        //    cicrcle.SetActive(false);
        //    collectActive = false;
        //    particleGO.SetActive(true);
        //    particleGO.transform.parent = null;
        //    PopUpManager.Instance.BoostPopUpOpen(0);
        //    PopUpManager.Instance.BoosterInvoke();
        //    gameObject.SetActive(false);
        //    PlayerController.Instance.PlayerControlDeActive();
        //}
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && collectActive && !other.GetComponent<PlayerController>().pressJoystick)
        {
            cicrcle.SetActive(false);
            collectActive = false;
            particleGO.SetActive(true);
            particleGO.transform.parent = null;
            PopUpManager.Instance.BoostPopUpOpen(0);
            PopUpManager.Instance.BoosterInvoke();
            gameObject.SetActive(false);
            PlayerController.Instance.PlayerControlDeActive();
        }
    }
    private void Start()
    {
        StartCoroutine(ViewCounter());
        rewardSelect = PlayerPrefs.GetInt("speedskil") % 3;
        speedModelList[rewardSelect].SetActive(true);
    }
    IEnumerator ViewCounter()
    {
        while(viewTimeCounter < viewTime)
        {
            viewTimeCounter++;
            viewCounterText.text = ConvertSecondToMinSec.Converter(viewTime - viewTimeCounter);
            yield return new WaitForSeconds(1f);
        }
        Globals.isSpeedRewardCreated = false;
        Destroy(gameObject);
    }
}

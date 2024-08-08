using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareCeo : MonoBehaviour
{
    private static ShareCeo _instance = null;
    public static ShareCeo Instance => _instance;
    public ShareCeoCharacter shareCeoCharacter;
    public Transform ceoFirtPosTR;
    public Transform playerTargetPosTR;
    public Transform exitPosTR;

    public GameObject popUp1_GO;
    public GameObject bag_GO;

    public Transform bagFirstPos_TR;
    public Transform bagLastPos_TR;
    bool ceoActive = false;
    private void Awake()
    {
        _instance = this;
    }
 
    public void CeoActive()
    {
        Globals.goToCeoActive = true;
        ceoActive = true;
        shareCeoCharacter.gameObject.SetActive(true);
        PlayerController.Instance.PlayerRotReset();
        PlayerController.Instance.PlayerControlDeActive();
        PlayerController.Instance.FollowShareCeo();

        bag_GO.SetActive(true);
        bag_GO.transform.position = bagFirstPos_TR.position;
        bag_GO.transform.rotation = bagFirstPos_TR.rotation;
    }
    public void CharacterArrivedCeo()
    {
        popUp1_GO.SetActive(true);
        StartCoroutine(PopUpReward_Open());
    }

    IEnumerator PopUpReward_Open()
    {
        bag_GO.GetComponent<Animator>().SetTrigger("open");
        //bag_GO.SetActive(true);
        //bag_GO.transform.position = bagFirstPos_TR.position;
        float counter = 0f;
        while(counter < 1f)
        {
            counter += 2f * Time.deltaTime;
            bag_GO.transform.position = Vector3.Lerp(bagFirstPos_TR.position, bagLastPos_TR.position, counter);
            bag_GO.transform.rotation = Quaternion.Lerp(bagFirstPos_TR.rotation, bagLastPos_TR.rotation, counter);
           yield return null;
        }
        bag_GO.transform.position = bagLastPos_TR.position;
        bag_GO.transform.rotation = bagLastPos_TR.rotation;


        yield return new WaitForSeconds(3f);
        popUp1_GO.SetActive(false);
        ShareManager.Instance.ShareLevelUp_PopUp();


        PlayerController.Instance.PlayerControl_ReActive();
        bag_GO.SetActive(false);
    }
    public void BossGoExit()
    {
        if (ceoActive)
        {
            shareCeoCharacter.GoExit(exitPosTR);
            ceoActive = false;
        }
    }
}

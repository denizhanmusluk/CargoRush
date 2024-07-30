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

    private void Awake()
    {
        _instance = this;
    }
 
    public void CeoActive()
    {
        Globals.goToCeoActive = true;
        shareCeoCharacter.gameObject.SetActive(true);
        PlayerController.Instance.PlayerRotReset();
        PlayerController.Instance.PlayerControlDeActive();
        PlayerController.Instance.FollowShareCeo();
    }
    public void CharacterArrivedCeo()
    {
        popUp1_GO.SetActive(true);
        StartCoroutine(PopUpReward_Open());
    }

    IEnumerator PopUpReward_Open()
    {

        yield return new WaitForSeconds(2f);
        popUp1_GO.SetActive(false);
        ShareManager.Instance.ShareLevelUp_PopUp();


        PlayerController.Instance.PlayerControl_ReActive();
        shareCeoCharacter.GoExit(exitPosTR);
    }
}

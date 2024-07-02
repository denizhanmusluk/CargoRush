using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DitzelGames.FastIK;

public class Player : MonoBehaviour
{
    public float extraSpeed;
    public int extraStack;
    public float extraMoney;
    public float repairSpeed;
    public Transform hoverboardCreatePos;
    public bool blendShapeActive = false;
    public FastIKFabric ikLeft;
    public FastIKFabric ikRight;

    public Transform leftIkTarget;
    public Transform rightIkTarget;

    public Transform leftProductTarget;
    public Transform rightProductTarget;

    public Transform leftBoxTarget;
    public Transform rightBoxTarget;

    public Transform leftNullTarget;
    public Transform rightNullTarget;
    private void OnEnable()
    {
        StartCoroutine(EnableDelay());
    }
    IEnumerator EnableDelay()
    {
        yield return new WaitForSeconds(0.5f);
        if (true)
        {
            Globals.extraSpeedSkins = extraSpeed;
            Globals.extraStackSkin = extraStack;
            Globals.extraMoneySkin = extraMoney;
            Globals.repairSpeedSkin = repairSpeed;
            PlayerController.Instance.hoverBoardCreatePos = hoverboardCreatePos;
            PlayerController.Instance._player = this;
            PlayerController.Instance._stackCollect.ikLeft = ikLeft;
            PlayerController.Instance._stackCollect.ikRight = ikRight;

            PlayerController.Instance._stackCollect.leftIkTarget = leftIkTarget;
            PlayerController.Instance._stackCollect.rightIkTarget = rightIkTarget;

            PlayerController.Instance._stackCollect.leftProductTarget = leftProductTarget;
            PlayerController.Instance._stackCollect.rightProductTarget = rightProductTarget;

            PlayerController.Instance._stackCollect.leftBoxTarget = leftBoxTarget;
            PlayerController.Instance._stackCollect.rightBoxTarget = rightBoxTarget;


            PlayerController.Instance._stackCollect.leftNullTarget = leftNullTarget;
            PlayerController.Instance._stackCollect.rightNullTarget = rightNullTarget;
        }
    }
}

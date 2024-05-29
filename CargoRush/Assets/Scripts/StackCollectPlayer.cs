using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackCollectPlayer : StackCollect
{
    [SerializeField] PlayerController _playerController;

    public override void StackAnimation()
    {
        _playerController.animator.SetBool("carry", true);

        if (collectionTrs[0].collectID == 0)
        {
            StartCoroutine(StackIkPosSet(leftIkTarget, leftProductTarget));
            StartCoroutine(StackIkPosSet(rightIkTarget, rightProductTarget));
        }
        else
        {
            StartCoroutine(StackIkPosSet(leftIkTarget, leftBoxTarget));
            StartCoroutine(StackIkPosSet(rightIkTarget, rightBoxTarget));
        }
    }

    public override void StackEmptyAnimation()
    {
        _playerController.animator.SetBool("carry", false);
        StartCoroutine(StackIkPosReset(leftIkTarget, leftNullTarget));
        StartCoroutine(StackIkPosReset(rightIkTarget, rightNullTarget));
    }

    public override float StackFollowSpeed()
    {
        return _playerController._characterUpgradeSettings.characterSpeed[Globals.characterSpeedLevel] * Globals.extraSpeedSkins * Globals.extraSpeed;
    }

    IEnumerator StackIkPosSet(Transform ikHandTR , Transform targetTR)
    {
        ikLeft.enabled = true;
        ikRight.enabled = true;
        float counter = 0f;
        while(counter < 1f)
        {
            counter += Time.deltaTime;
            ikHandTR.position = Vector3.Lerp(ikHandTR.position, targetTR.position, 2f * Time.deltaTime);
            ikHandTR.rotation = Quaternion.Lerp(ikHandTR.rotation, targetTR.rotation, 2f * Time.deltaTime);
            yield return null;
        }
    }

    IEnumerator StackIkPosReset(Transform ikHandTR, Transform targetTR)
    {
        float counter = 0f;
        while (counter < 1f)
        {
            counter += Time.deltaTime;
            ikHandTR.position = Vector3.Lerp(ikHandTR.position, targetTR.position, 2f * Time.deltaTime);
            ikHandTR.rotation = Quaternion.Lerp(ikHandTR.rotation, targetTR.rotation, 2f * Time.deltaTime);
            yield return null;
        }
        ikLeft.enabled = false;
        ikRight.enabled = false;
    }
}

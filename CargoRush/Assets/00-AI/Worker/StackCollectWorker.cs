using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackCollectWorker : StackCollect
{
    public int currentCapacity;
    public int baseStackCapacity;
    [SerializeField] AIWorker _aiWorker;
    [SerializeField] AIGarbageWorker _aiGarbageWorker;
    public int targetId;
    public bool aiCollectActive = true;

    public CollectType collectableType;
    public bool carryPassive;
    public CharacterUpgradeSettings characterUpgradeSettings;
    public override float StackFollowSpeed()
    {
        if (_aiWorker != null)
        {
            return _aiWorker.AImoveSpeed;

        }
        else
        {
            return _aiGarbageWorker.AImoveSpeed;
        }
    }
    public override void StackAnimation()
    {
        if (!carryPassive)
        {
            if (_aiWorker != null)
            {
                _aiWorker.animator.SetBool("carry", true);
            }
            else
            {
                _aiGarbageWorker.animator.SetBool("carry", true);
                
            }
        }

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
        if (_aiWorker != null)
        {
            _aiWorker.animator.SetBool("carry", false);

        }
        else
        {
            _aiGarbageWorker.animator.SetBool("carry", false);
        }

        StartCoroutine(StackIkPosReset(leftIkTarget, leftNullTarget));
        StartCoroutine(StackIkPosReset(rightIkTarget, rightNullTarget));
    }

    IEnumerator StackIkPosSet(Transform ikHandTR, Transform targetTR)
    {
        ikLeft.enabled = true;
        ikRight.enabled = true;
        float counter = 0f;
        while (counter < 1f)
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

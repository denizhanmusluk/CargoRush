using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackCollectWorker : StackCollect
{
    public int currentCapacity;
    public int baseStackCapacity;
    [SerializeField] AIWorker _aiWorker;
    [SerializeField] AIGarbageWorker _aiGarbageWorker;
    [SerializeField] OnlineWorker _onlineWorker;
    public int targetId;
    public bool aiCollectActive = true;

    public CollectType collectableType;
    public bool carryPassive;
    public CharacterUpgradeSettings characterUpgradeSettings;

    private void Awake()
    {
        //characterUpgradeSettings = LevelManager.Instance._currnetCharacterUpgradeSettings;
    }
    public override float StackFollowSpeed()
    {
        if (_aiWorker != null)
        {
            return _aiWorker.AImoveSpeed;

        }
        else if (_aiGarbageWorker != null)
        {
            return _aiGarbageWorker.AImoveSpeed;
        }
        else if (_onlineWorker != null)
        {
            return _onlineWorker.aiMoving.AImoveSpeed;
        }
        else
        {
            return 5f;
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
            else if (_aiGarbageWorker != null)
            {
                _aiGarbageWorker.animator.SetBool("carry", true);
            }
            else if (_onlineWorker != null)
            {
                _onlineWorker.workerAnimator.SetBool("carry", true);
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
        else if (_aiGarbageWorker != null)
        {
            _aiGarbageWorker.animator.SetBool("carry", false);
        }
        else if (_onlineWorker != null)
        {
            _onlineWorker.workerAnimator.SetBool("carry", false);
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
            counter += 4 * Time.deltaTime;
            ikHandTR.position = Vector3.Lerp(ikHandTR.position, targetTR.position, 2f * Time.deltaTime);
            ikHandTR.rotation = Quaternion.Lerp(ikHandTR.rotation, targetTR.rotation, 2f * Time.deltaTime);
            yield return null;
        }
        ikLeft.enabled = false;
        ikRight.enabled = false;
    }
}

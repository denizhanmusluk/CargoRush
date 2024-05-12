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
    }
}

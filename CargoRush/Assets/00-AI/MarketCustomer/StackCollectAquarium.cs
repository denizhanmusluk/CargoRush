using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackCollectAquarium : StackCollect
{
    public int stackCapacity;
    public AquariumCustomer _aiCustomer;
    public int targetId;
    public override float StackFollowSpeed()
    {
        return _aiCustomer.AImoveSpeed * 4;
    }

    public override void StackAnimation()
    {
        _aiCustomer.animator.SetBool("carry", true);
    }

    public override void StackEmptyAnimation()
    {
        _aiCustomer.animator.SetBool("carry", false);
    }
}

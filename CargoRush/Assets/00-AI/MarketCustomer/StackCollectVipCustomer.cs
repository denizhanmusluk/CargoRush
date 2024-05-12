using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackCollectVipCustomer : StackCollect
{
    public int stackCapacity;
    public VipCustomer _aiCustomer;
    public int targetId;
    public bool cabinActive = false;
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

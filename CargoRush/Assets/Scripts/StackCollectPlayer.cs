using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackCollectPlayer : StackCollect
{
    [SerializeField] PlayerController _playerController;

    public override void StackAnimation()
    {
        _playerController.animator.SetBool("carry", true);
    }

    public override void StackEmptyAnimation()
    {
        _playerController.animator.SetBool("carry", false);
    }

    public override float StackFollowSpeed()
    {
        return _playerController._characterUpgradeSettings.characterSpeed[Globals.characterSpeedLevel] * Globals.extraSpeedSkins * Globals.extraSpeed;
    }
}

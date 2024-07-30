using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCharacter : MonoBehaviour
{
    public NewLevelBoss newLevelBoss;
    public AIMoving aiMoving;
    public void GoExit(Transform targetExit)
    {
        aiMoving.GoTargetStart(targetExit);
        aiMoving.BehaviourInit(SelfDestroy);
    }
    void SelfDestroy()
    {
        PlayerPrefs.SetInt(newLevelBoss.bossName, 1);
        Destroy(gameObject, 1);
    }
}

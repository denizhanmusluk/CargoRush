using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCharacterSecond : MonoBehaviour
{
    public NewLevelFirstOpenBoss newLevelFirstOpenBoss;
    public AIMoving aiMoving;
    public void GoExit(Transform targetExit)
    {
        aiMoving.GoTargetStart(targetExit);
        aiMoving.BehaviourInit(SelfDestroy);
    }
    void SelfDestroy()
    {
        PlayerPrefs.SetInt(newLevelFirstOpenBoss.bossName + PlayerPrefs.GetInt("level"), 1);
        Destroy(gameObject, 1);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareCeoCharacter : MonoBehaviour
{
    public AIMoving aiMoving;
    public void GoExit(Transform targetExit)
    {
        aiMoving.GoTargetStart(targetExit);
        aiMoving.BehaviourInit(SelfDestroy);
    }
    void SelfDestroy()
    {
        gameObject.SetActive(false);
    }
    private void OnEnable()
    {
        transform.position = ShareCeo.Instance.ceoFirtPosTR.position;
        transform.rotation = ShareCeo.Instance.ceoFirtPosTR.rotation;
    }
}

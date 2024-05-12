using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasierAquarium : MonoBehaviour
{
    public Animator _animator;
    private void OnEnable()
    {
        AquariumCaseManager.Instance.casierWorkerActive = true;
    }
}

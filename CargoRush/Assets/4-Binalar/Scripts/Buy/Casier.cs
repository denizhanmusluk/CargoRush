using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Cinemachine;

public class Casier : MonoBehaviour
{
    [SerializeField] ElectronicsCaseManager electronicsCaseManager;
    [SerializeField] SportsCaseManager sportsCaseManager;
    [SerializeField] ToysCaseManager toysCaseManager;
    public Animator _animator;
    private void OnEnable()
    {
        if(electronicsCaseManager != null)
        {
            electronicsCaseManager.casierWorkerActive = true;
        }
        if (sportsCaseManager != null)
        {
            sportsCaseManager.casierWorkerActive = true;
        }
        if (toysCaseManager != null)
        {
            toysCaseManager.casierWorkerActive = true;
        }
    }
}
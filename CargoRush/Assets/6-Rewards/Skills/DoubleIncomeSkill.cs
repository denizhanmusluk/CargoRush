using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleIncomeSkill : MonoBehaviour
{
    bool collectActive = true;
    [SerializeField] GameObject cicrcle;
    [SerializeField] GameObject particleGO;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && collectActive)
        {
            cicrcle.SetActive(false);
            collectActive = false;
            particleGO.SetActive(true);
            particleGO.transform.parent = null;
            //PopUpManager.Instance.BoostPopUpOpen(2);
            //PopUpManager.Instance.BoosterInvoke();
            gameObject.SetActive(false);
            PlayerController.Instance.PlayerControlDeActive();
        }
    }
}

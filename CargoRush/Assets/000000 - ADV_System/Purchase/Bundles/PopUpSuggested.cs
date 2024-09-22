using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HomaGames.HomaBelly;

public class PopUpSuggested : MonoBehaviour
{
    public string popupName;
    [SerializeField] string productId;
    private void OnEnable()
    {
        Analytics.IAPSuggested(popupName, productId = null);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardedButton : MonoBehaviour
{
    public Image adv_Image;
    public Image gem_Image;
    private void Start()
    {
        ADVManager.Instance.allRewardedButtons.Add(this);
    }
    private void OnEnable()
    {
        _UpdateCheckTicket();
    }
    void _UpdateCheckTicket()
    {
        if (Globals.gemAmount > 0)
        {
            adv_Image.gameObject.SetActive(false);
            gem_Image.gameObject.SetActive(true);
        }
        else
        {
            adv_Image.gameObject.SetActive(true);
            gem_Image.gameObject.SetActive(false);
        }
    }
    public void UpdateCheckTicket()
    {
        _UpdateCheckTicket();
    }

}

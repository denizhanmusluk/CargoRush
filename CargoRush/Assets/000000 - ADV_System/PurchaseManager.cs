using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseManager : MonoBehaviour
{
    private static PurchaseManager _instance = null;
    public static PurchaseManager Instance => _instance;
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        
    }
    public void BuyBannerDisable()
    {
        ADVManager.Instance.BannerHide();
    }
    public void BuyTicket()
    {

    }
    public void BuySpeedBoost()
    {
        SkillManager.Instance.PurchaseSpeedBoostActive();
    }
    public void BuyFullCapacityBoost()
    {
        SkillManager.Instance.PurchaseCapacityBoostActive();
    }
    public void BuyDoubleIncomeBoost()
    {
        SkillManager.Instance.PurchaseDoubleIncomeBoostActive();
    }
}

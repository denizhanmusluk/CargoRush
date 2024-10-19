using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RewardPanel : MonoBehaviour
{
    private static RewardPanel _instance = null;
    public static RewardPanel Instance => _instance;

    private void Awake()
    {
        _instance = this;
    }




    public GameObject hoverboardPanelGO;
    public TextMeshProUGUI hoverboardCounterText;

    public GameObject capacityPanelGO;
    public TextMeshProUGUI capacityCounterText;

    public GameObject doubleIncomePanelGO;
    public TextMeshProUGUI doubleIncomeCounterText;

    public GameObject workerRewardPanelGO;
    public TextMeshProUGUI workerCounterText;

    public GameObject machineRewardPanelGO;
    public TextMeshProUGUI machineCounterText;

    public GameObject vipPanelGO;
    public TextMeshProUGUI vipCounterText;

    public Image vipImg;

    public VipCustomerSlot vipCar;
    public Button vipViewButton;
    public void VipViewClick()
    {
        if(vipCar != null)
        {
            vipCar.VipViewCamera();
            vipViewButton.interactable = false;
        }
    }
}

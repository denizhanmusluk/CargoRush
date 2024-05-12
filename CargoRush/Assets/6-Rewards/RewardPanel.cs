using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RewardPanel : MonoBehaviour
{
    private static RewardPanel _instance = null;
    public static RewardPanel Instance => _instance;

    private void Awake()
    {
        _instance = this;
    }

    public GameObject biggerPanelGO;
    public TextMeshProUGUI biggerCounterText;

    public GameObject fasterPanelGO;
    public TextMeshProUGUI fasterCounterText;


    public GameObject hoverboardPanelGO;
    public TextMeshProUGUI hoverboardCounterText;

    public GameObject capacityPanelGO;
    public TextMeshProUGUI capacityCounterText;

    public GameObject doubleIncomePanelGO;
    public TextMeshProUGUI doubleIncomeCounterText;

    public GameObject vipPanelGO;
    public TextMeshProUGUI vipCounterText;
}

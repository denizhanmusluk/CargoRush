using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class PopUpManager : MonoBehaviour
{
    public delegate void MyAction(int macId);
    public event MyAction panelAction;
    public event MyAction tipAction;
    public event MyAction boostAction;

    private static PopUpManager _instance = null;
    public static PopUpManager Instance => _instance;
    public List<GameObject> popUpList = new List<GameObject>();
    public List<GameObject> tipList = new List<GameObject>();
    public List<GameObject> boosterList = new List<GameObject>();
    GameObject currentPopUp;
    GameObject currentTip;
    GameObject currentBooster;
    int lastID = 0;
    int tipID = 0;
    int boosterID = 0;

    public int freeMoneyValue;
    public TextMeshProUGUI moneyText;
    private void Awake()
    {
        _instance = this;
    }
    public void ActionInvoke()
    {
        panelAction?.Invoke(lastID);
    }

    public void TipActionInvoke()
    {
        tipAction?.Invoke(tipID);
    }
    public void BoosterInvoke()
    {
        boostAction?.Invoke(boosterID);
    }
    public void PopUpOpen(int machineId)
    {
        lastID = machineId;
        panelAction = null;
        panelAction += (macId) => PanelOpen(machineId);
    }
    public void TipPopUpOpen(int tipId)
    {
        tipID = tipId;
        tipAction = null;
        tipAction += (macId) => TipOpen(tipId);
    }
    public void BoostPopUpOpen(int boostID)
    {
        boosterID = boostID;
        boostAction = null;
        boostAction += (macId) => BoostPanelOpen(boostID);
    }

    public void PanelOpen(int machineId)
    {
        StartCoroutine(PanelOpen(popUpList[machineId]));
        currentPopUp = popUpList[machineId];

        panelAction = null;
    }
    public void TipOpen(int tipId)
    {
        StartCoroutine(PanelOpen(tipList[tipId]));
        currentTip = tipList[tipId];

        tipAction = null;
    }
    public void BoostPanelOpen(int boostID)
    {
        StartCoroutine(PanelOpen(boosterList[boostID]));
        currentBooster = boosterList[boostID];

        boostAction = null;
    }
    IEnumerator PanelOpen(GameObject popUp)
    {
        Globals.popUpActive = true;

        popUp.SetActive(true);
        float counter = 0;
        float SimulationSpeed = 1f;
        while (counter < 1f)
        {
            counter += SimulationSpeed * Time.deltaTime;

            foreach (var img in popUp.GetComponentsInChildren<Image>())
            {
                img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.Abs(counter));
                //img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.Abs(1 - counter));
            }
            foreach (var txt in popUp.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, Mathf.Abs(counter));
            }
            yield return null;
        }

    }
    public void TapClick()
    {
        if(currentPopUp != null)
        {
            StartCoroutine(PanelClose(currentPopUp));
            currentPopUp = null;
        }
    }
    public void TapTipClick()
    {
        if (currentTip != null)
        {
            StartCoroutine(PanelClose(currentTip));
            currentTip = null;
        }
    }

    public void TapBoostClick()
    {
        if (currentBooster != null)
        {
            StartCoroutine(PanelClose(currentBooster));
            currentBooster = null;
        }
    }
    IEnumerator PanelClose(GameObject popUp)
    {
        Globals.popUpActive = false;
        float counter = 0;
        float SimulationSpeed = 1f;
        while (counter < 1f)
        {
            counter += SimulationSpeed * Time.deltaTime;

            foreach (var img in popUp.GetComponentsInChildren<Image>())
            {
                img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.Abs(1 - counter));
            }
            foreach (var txt in popUp.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, Mathf.Abs(1 - counter));
            }
            yield return null;
        }
        popUp.SetActive(false);
    }
}

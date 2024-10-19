using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradePanel : MonoBehaviour
{
    private static UpgradePanel _instance = null;
    public static UpgradePanel Instance => _instance;

    public GameObject characterUpgradePanelGO;
    public GameObject workerUpgradePanelGO;
    public GameObject machinesUpgradePanelGO;
    public GameObject customerUpgradePanelGO;
    public GameObject repairUpgradePanelGO;

    public Button character_Upg_Button;
    public Button worker_Upg_Button;
    public Button machines_Upg_Button;
    public Button customer_Upg_Button;
    public Button repair_Upg_Button;
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        OpenCharacterUpgradePanel();
    }
    public void OpenCharacterUpgradePanel()
    {
        characterUpgradePanelGO.SetActive(true);
        workerUpgradePanelGO.SetActive(false);
        machinesUpgradePanelGO.SetActive(false);
        customerUpgradePanelGO.SetActive(false);
        repairUpgradePanelGO.SetActive(false);

        character_Upg_Button.interactable = false;
        worker_Upg_Button.interactable = true;
        machines_Upg_Button.interactable = true;
        customer_Upg_Button.interactable = true;
        repair_Upg_Button.interactable = true;
    }


    public void OpenWorkerUpgradePanel()
    {
        characterUpgradePanelGO.SetActive(false);
        workerUpgradePanelGO.SetActive(true);
        machinesUpgradePanelGO.SetActive(false);
        customerUpgradePanelGO.SetActive(false);
        repairUpgradePanelGO.SetActive(false);

        character_Upg_Button.interactable = true;
        worker_Upg_Button.interactable = false;
        machines_Upg_Button.interactable = true;
        customer_Upg_Button.interactable = true;
        repair_Upg_Button.interactable = true;
    }

    public void OpenMachinesUpgradePanel()
    {
        characterUpgradePanelGO.SetActive(false);
        workerUpgradePanelGO.SetActive(false);
        machinesUpgradePanelGO.SetActive(true);
        customerUpgradePanelGO.SetActive(false);
        repairUpgradePanelGO.SetActive(false);

        character_Upg_Button.interactable = true;
        worker_Upg_Button.interactable = true;
        machines_Upg_Button.interactable = false;
        customer_Upg_Button.interactable = true;
        repair_Upg_Button.interactable = true;
    }

    public void OpenCustomerUpgradePanel()
    {
        characterUpgradePanelGO.SetActive(false);
        workerUpgradePanelGO.SetActive(false);
        machinesUpgradePanelGO.SetActive(false);
        customerUpgradePanelGO.SetActive(true);
        repairUpgradePanelGO.SetActive(false);

        character_Upg_Button.interactable = true;
        worker_Upg_Button.interactable = true;
        machines_Upg_Button.interactable = true;
        customer_Upg_Button.interactable = false;
        repair_Upg_Button.interactable = true;
    }

    public void OpenRepairUpgradePanel()
    {
        characterUpgradePanelGO.SetActive(false);
        workerUpgradePanelGO.SetActive(false);
        machinesUpgradePanelGO.SetActive(false);
        customerUpgradePanelGO.SetActive(false);
        repairUpgradePanelGO.SetActive(true);

        character_Upg_Button.interactable = true;
        worker_Upg_Button.interactable = true;
        machines_Upg_Button.interactable = true;
        customer_Upg_Button.interactable = true;
        repair_Upg_Button.interactable = false;
    }
}

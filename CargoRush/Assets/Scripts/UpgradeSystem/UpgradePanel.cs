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
    public GameObject trainUpgradePanelGO;

    //public Button character_Upg_Button;
    //public Button worker_Upg_Button;
    //public Button machines_Upg_Button;
    //public Button customer_Upg_Button;
    //public Button repair_Upg_Button;
    //public Button train_Upg_Button;

    public ButtonUpgrade character_Upg_Button;
    public ButtonUpgrade worker_Upg_Button;
    public ButtonUpgrade machines_Upg_Button;
    public ButtonUpgrade customer_Upg_Button;
    public ButtonUpgrade repair_Upg_Button;
    public ButtonUpgrade train_Upg_Button;
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        characterUpgradePanelGO.SetActive(true);
        workerUpgradePanelGO.SetActive(false);
        machinesUpgradePanelGO.SetActive(false);
        customerUpgradePanelGO.SetActive(false);
        repairUpgradePanelGO.SetActive(false);
        trainUpgradePanelGO.SetActive(false);
        character_Upg_Button.GetComponent<Button>().interactable = false;
        //OpenCharacterUpgradePanel();
    }
    public void OpenCharacterUpgradePanel()
    {
        characterUpgradePanelGO.SetActive(true);
        workerUpgradePanelGO.SetActive(false);
        machinesUpgradePanelGO.SetActive(false);
        customerUpgradePanelGO.SetActive(false);
        repairUpgradePanelGO.SetActive(false);
        trainUpgradePanelGO.SetActive(false);

        character_Upg_Button.MoveButtonUp();
        worker_Upg_Button.MoveButtonDefaultPos();
        machines_Upg_Button.MoveButtonDefaultPos();
        customer_Upg_Button.MoveButtonDefaultPos();
        repair_Upg_Button.MoveButtonDefaultPos();
        train_Upg_Button.MoveButtonDefaultPos();
    }


    public void OpenWorkerUpgradePanel()
    {
        characterUpgradePanelGO.SetActive(false);
        workerUpgradePanelGO.SetActive(true);
        machinesUpgradePanelGO.SetActive(false);
        customerUpgradePanelGO.SetActive(false);
        repairUpgradePanelGO.SetActive(false);
        trainUpgradePanelGO.SetActive(false);

        character_Upg_Button.MoveButtonDefaultPos();
        worker_Upg_Button.MoveButtonUp();
        machines_Upg_Button.MoveButtonDefaultPos();
        customer_Upg_Button.MoveButtonDefaultPos();
        repair_Upg_Button.MoveButtonDefaultPos();
        train_Upg_Button.MoveButtonDefaultPos();
    }

    public void OpenMachinesUpgradePanel()
    {
        characterUpgradePanelGO.SetActive(false);
        workerUpgradePanelGO.SetActive(false);
        machinesUpgradePanelGO.SetActive(true);
        customerUpgradePanelGO.SetActive(false);
        repairUpgradePanelGO.SetActive(false);
        trainUpgradePanelGO.SetActive(false);

        character_Upg_Button.MoveButtonDefaultPos();
        worker_Upg_Button.MoveButtonDefaultPos();
        machines_Upg_Button.MoveButtonUp();
        customer_Upg_Button.MoveButtonDefaultPos();
        repair_Upg_Button.MoveButtonDefaultPos();
        train_Upg_Button.MoveButtonDefaultPos();
    }

    public void OpenCustomerUpgradePanel()
    {
        characterUpgradePanelGO.SetActive(false);
        workerUpgradePanelGO.SetActive(false);
        machinesUpgradePanelGO.SetActive(false);
        customerUpgradePanelGO.SetActive(true);
        repairUpgradePanelGO.SetActive(false);
        trainUpgradePanelGO.SetActive(false);

        character_Upg_Button.MoveButtonDefaultPos();
        worker_Upg_Button.MoveButtonDefaultPos();
        machines_Upg_Button.MoveButtonDefaultPos();
        customer_Upg_Button.MoveButtonUp();
        repair_Upg_Button.MoveButtonDefaultPos();
        train_Upg_Button.MoveButtonDefaultPos();
    }

    public void OpenRepairUpgradePanel()
    {
        characterUpgradePanelGO.SetActive(false);
        workerUpgradePanelGO.SetActive(false);
        machinesUpgradePanelGO.SetActive(false);
        customerUpgradePanelGO.SetActive(false);
        repairUpgradePanelGO.SetActive(true);
        trainUpgradePanelGO.SetActive(false);

        character_Upg_Button.MoveButtonDefaultPos();
        worker_Upg_Button.MoveButtonDefaultPos();
        machines_Upg_Button.MoveButtonDefaultPos();
        customer_Upg_Button.MoveButtonDefaultPos();
        repair_Upg_Button.MoveButtonUp();
        train_Upg_Button.MoveButtonDefaultPos();
    }

    public void OpenTrainUpgradePanel()
    {
        characterUpgradePanelGO.SetActive(false);
        workerUpgradePanelGO.SetActive(false);
        machinesUpgradePanelGO.SetActive(false);
        customerUpgradePanelGO.SetActive(false);
        repairUpgradePanelGO.SetActive(false);
        trainUpgradePanelGO.SetActive(true);

        character_Upg_Button.MoveButtonDefaultPos();
        worker_Upg_Button.MoveButtonDefaultPos();
        machines_Upg_Button.MoveButtonDefaultPos();
        customer_Upg_Button.MoveButtonDefaultPos();
        repair_Upg_Button.MoveButtonDefaultPos();
        train_Upg_Button.MoveButtonUp();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MachineRepairArea : MonoBehaviour
{
    public GameObject processMachine;
    public List<MachineRepair> machineRepairList = new List<MachineRepair>();

    private void OnEnable()
    {
        if(PlayerPrefs.GetInt("firsterrormachine") == 0)
        {
            TutorialManager.Instance.repairMachineGO.SetActive(true);
            IndicatorManager.Instance.IndicaorActive(machineRepairList[0].transform);
        }
        RepairListOpen();
    }
    void RepairListOpen()
    {
        foreach(var rpr in machineRepairList)
        {
            rpr.gameObject.SetActive(true);
            rpr.machineRepairArea = this;
        }
    }
    public void RepairingCheck()
    {
        bool repairingActive = true;

        for(int i = 0; i < machineRepairList.Count; i++)
        {
            if (!machineRepairList[i].repairStarted)
            {
                repairingActive = false;
            }
        }
        if (PlayerPrefs.GetInt("firsterrormachine") == 0)
        {
            List<MachineRepair> tempMachineRepair = new List<MachineRepair>();
            for (int i = 0; i < machineRepairList.Count; i++)
            {
                if (!machineRepairList[i].repairStarted)
                {
                    tempMachineRepair.Add(machineRepairList[i]);
                }
            }

            if (tempMachineRepair.Count > 0)
            {
                TutorialManager.Instance.repairMachineGO.SetActive(true);
                IndicatorManager.Instance.IndicaorActive(tempMachineRepair[0].transform);
            }
        }
        if (repairingActive)
        {
            if (PlayerPrefs.GetInt("firsterrormachine") == 0)
            {
                PlayerPrefs.SetInt("firsterrormachine", 1);
                TutorialManager.Instance.repairMachineGO.SetActive(false);
                IndicatorManager.Instance.IndicaorDeActive();
            }
            if (processMachine.GetComponent<IMachineActive>() != null)
            {
                processMachine.GetComponent<IMachineActive>().MachineRepaired();
            }
            gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class MachineRepairArea : MonoBehaviour
{
    public GameObject processMachine;
    public List<MachineRepair> machineRepairListAll = new List<MachineRepair>();
    public List<MachineRepair> selectedMachineRepairList = new List<MachineRepair>();

    private void OnEnable()
    {
        RepairListOpen();
    }
    void RepairListOpen()
    {
        int minElementCount = 3;
        if(minElementCount > machineRepairListAll.Count - 1)
        {
            minElementCount = machineRepairListAll.Count - 1;
        }
        int numberOfElementsToSelect = Random.Range(minElementCount, machineRepairListAll.Count);
        selectedMachineRepairList.Clear();
        if (PlayerPrefs.GetInt("firsterrortutorial") == 0)
        {
            PlayerPrefs.SetInt("firsterrortutorial", 1);
            //for(int i = 0; i < 3; i++)
            {
                selectedMachineRepairList.Add(machineRepairListAll[1]);
            }
        }
        else
        {
            selectedMachineRepairList = GetRandomElements(machineRepairListAll, numberOfElementsToSelect);
        }
        foreach (var rpr in machineRepairListAll)
        {
            rpr.machineRepairArea = this;
        }
        foreach (var rpr in selectedMachineRepairList)
        {
            rpr.gameObject.SetActive(true);
        }

        if (PlayerPrefs.GetInt("firsterrormachine") == 0)
        {
            List<MachineRepair> tempMachineRepair = new List<MachineRepair>();
            tempMachineRepair = selectedMachineRepairList;
            tempMachineRepair = GetSortedElementsByValue(tempMachineRepair);
            TutorialManager.Instance.repairMachineGO.SetActive(true);
            IndicatorManager.Instance.IndicaorActive(tempMachineRepair[0].transform);
        }
    }
    public void RepairingCheck()
    {
        bool repairingActive = true;

        for(int i = 0; i < selectedMachineRepairList.Count; i++)
        {
            if (!selectedMachineRepairList[i].repairStarted)
            {
                repairingActive = false;
            }
        }
        if (PlayerPrefs.GetInt("firsterrormachine") == 0)
        {
            List<MachineRepair> tempMachineRepair = new List<MachineRepair>();
            for (int i = 0; i < selectedMachineRepairList.Count; i++)
            {
                if (!selectedMachineRepairList[i].repairStarted)
                {
                    tempMachineRepair.Add(selectedMachineRepairList[i]);
                }
            }

            if (tempMachineRepair.Count > 0)
            {
                tempMachineRepair = GetSortedElementsByValue(tempMachineRepair);
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


    List<T> GetRandomElements<T>(List<T> list, int count)
    {
        // Rastgele sayýlar oluþturmak için Random sýnýfýný kullanýyoruz
        System.Random random = new System.Random();

        // Listeyi rastgele sýraya diziyoruz ve istediðimiz sayýda elemaný alýyoruz
        return list.OrderBy(x => random.Next()).Take(count).ToList();
    }

    List<MachineRepair> GetSortedElementsByValue(List<MachineRepair> list)
    {
        List<MachineRepair> sortedList = list.OrderBy(x => x.id).ToList();
        list = sortedList;
        return sortedList;
    }
}

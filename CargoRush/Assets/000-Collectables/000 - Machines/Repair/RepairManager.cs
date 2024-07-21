using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairManager : MonoBehaviour
{
    private static RepairManager _instance = null;
    public static RepairManager Instance => _instance;
    public List<ProcessMachine> processMachines = new List<ProcessMachine>();
    public RepairWorker repairWorker;
    public Transform repairWorkerFirstPosTR;
    public int repairTime = 300;
  [SerializeField]  int repairWorkerTimeCounter = 0;
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        if (PlayerPrefs.GetInt("machineerrorcount") >= 2)
        {
            repairWorker.gameObject.SetActive(true);
        }
        repairWorkerTimeCounter = PlayerPrefs.GetInt("repairWorkerTimeCounter");
        StartCoroutine(StartDelay());

    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(5f);
        if (repairWorkerTimeCounter > 0)
        {
            RepairWorkerStart();
        }
    }
    public void OpenRepairWorker()
    {
        repairWorker.gameObject.SetActive(true);
        if (PlayerPrefs.GetInt("machineerrorcount") == 2)
        {
            RepairWorkerStart();
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            RepairWorkerStart();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            RepairEnd();
        }
    }
    public void RepairWorkerStart()
    {
        Globals.repairManActive = true;
        repairWorker.repairActive = true;
        repairWorker.SelectGoMachine();
        FishDropArea.Instance.RepairProgressSet();
        FishDropArea.Instance.AllMachineRepair();
        repairWorker.showBuyRapairReward.gameObject.SetActive(false);
        StartCoroutine(RepairTimer());
    }
    IEnumerator RepairTimer()
    {
        repairWorkerTimeCounter = PlayerPrefs.GetInt("repairWorkerTimeCounter");
        while (repairWorkerTimeCounter < repairTime)
        {
            repairWorkerTimeCounter++;
            PlayerPrefs.SetInt("repairWorkerTimeCounter", repairWorkerTimeCounter);
            yield return new WaitForSeconds(1);
        }
        RepairEnd();
    }
    public void RepairEnd()
    {
        repairWorkerTimeCounter = 0;
        PlayerPrefs.SetInt("repairWorkerTimeCounter", repairWorkerTimeCounter);
        Globals.repairManActive = false;
        repairWorker.repairActive = false;
        repairWorker.WorkerRepairEnd();
        repairWorker.showBuyRapairReward.gameObject.SetActive(true);
    }
}

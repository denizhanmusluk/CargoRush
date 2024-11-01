using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RepairManager : MonoBehaviour
{
    private static RepairManager _instance = null;
    public static RepairManager Instance => _instance;
    public List<ProcessMachine> processMachines = new List<ProcessMachine>();
    public RepairWorker repairWorker;
    public Transform repairWorkerFirstPosTR;
    [SerializeField] int repairWorkerTimeCounter = 0;

    public GameObject buttonFree_GO;
    public GameObject buttonADV_GO;

    public TextMeshProUGUI repairCounterText;

    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
       
        repairWorkerTimeCounter = PlayerPrefs.GetInt("repairWorkerTimeCounter");
        StartCoroutine(StartDelay());
        repairCounterText = RewardPanel.Instance.repairCounterText;

    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(5f);
        if (repairWorkerTimeCounter > 0 && PlayerPrefs.GetInt("purchaserepairboost") == 0)
        {
            RepairWorkerStart();
        }
        if (Globals.loadingPanelActive)
        {

        }
        else
        {
            yield return new WaitForSeconds(60);
        }
        if (PlayerPrefs.GetInt("machineerrorcount") >= 1)
        {
            repairWorker.gameObject.SetActive(true);
            buttonFree_GO.SetActive(false);
            buttonADV_GO.SetActive(true);
        }
    }
    public void OpenRepairWorker()
    {
        buttonFree_GO.SetActive(false);
        buttonADV_GO.SetActive(true);

        repairWorker.gameObject.SetActive(true);
        if (PlayerPrefs.GetInt("machineerrorcount") == 1 && PlayerPrefs.GetInt("purchaserepairboost") == 0)
        {
            TutorialManager.Instance.goToRepairMan_GO.SetActive(true);
            //IndicatorManager.Instance.IndicaorActive(repairWorkerFirstPosTR);
            repairWorker.showBuyRapairReward.gameObject.SetActive(false);

            //buttonFree_GO.SetActive(true);
            //buttonADV_GO.SetActive(false);
            //RepairWorkerStart();
        }
    }
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    RepairWorkerStart();
        //}
        //if (Input.GetKeyDown(KeyCode.O))
        //{
        //    RepairEnd();
        //}
    }
    public void RepairWorkerStart()
    {
        Globals.repairManActive = true;
        repairWorker.repairActive = true;



        //FishDropArea.Instance.AllMachineRepair();
        repairWorker.showBuyRapairReward.gameObject.SetActive(false);
        StartCoroutine(RepairTimer());
        buttonFree_GO.SetActive(false);
        buttonADV_GO.SetActive(true);
        StartCoroutine(RepairWorkerStart_Delay());

        FishDropArea.Instance.AllMachineRepairClose();
    }
    IEnumerator RepairWorkerStart_Delay()
    {
        yield return new WaitForSeconds(1);
        //FishDropArea.Instance.RepairProgressSet();

        yield return new WaitForSeconds(1);
        repairWorker.SelectGoMachine();

    }
    IEnumerator RepairTimer()
    {
        if (PlayerPrefs.GetInt("purchaserepairboost") == 0)
        {
            RewardPanel.Instance.repairRewardPanelGO.SetActive(true);
        }
        repairWorkerTimeCounter = PlayerPrefs.GetInt("repairWorkerTimeCounter");
        while (repairWorkerTimeCounter < MRCUpgradeManager.Instance._characterUpgradeSettings.repairRunTime[Globals.repairRunTimeLevel])
        {
            repairWorkerTimeCounter++;
            PlayerPrefs.SetInt("repairWorkerTimeCounter", repairWorkerTimeCounter);
            if (PlayerPrefs.GetInt("purchaserepairboost") == 0)
            {
                repairCounterText.text = ConvertSecondToMinSec.Converter(MRCUpgradeManager.Instance._characterUpgradeSettings.repairRunTime[Globals.repairRunTimeLevel] - repairWorkerTimeCounter);
            }
            else
            {
                RewardPanel.Instance.repairRewardPanelGO.SetActive(false);
            }
            yield return new WaitForSeconds(1);
        }
        RewardPanel.Instance.repairRewardPanelGO.SetActive(false);
        if (PlayerPrefs.GetInt("purchaserepairboost") == 0)
        {
            RepairEnd();
        }
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

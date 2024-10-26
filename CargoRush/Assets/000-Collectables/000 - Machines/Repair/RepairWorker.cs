using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairWorker : MonoBehaviour
{
    public AIMoving aiMoving;
    public Animator animator;
    public MachineRepairArea machineRepairArea;
    public ShowBuyRapairReward showBuyRapairReward;

    Transform targetTR;
   public bool repairActive = false;
    int randomSelect = 0;
    ProcessMachine currentTargetMachine;
    public void SelectGoMachine()
    {
        randomSelect = Random.Range(0, RepairManager.Instance.processMachines.Count);

        bool isThereErrorMachine = false;
        foreach(var mchn in RepairManager.Instance.processMachines)
        {
            if (mchn.errorActive)
            {
                isThereErrorMachine = true;
                targetTR = mchn.repairWorkerWaitingPos_TR;
                currentTargetMachine = mchn;
                break;
            }
        }
        if (!isThereErrorMachine)
        {
            targetTR = RepairManager.Instance.processMachines[randomSelect].repairWorkerWaitingPos_TR;
            currentTargetMachine = RepairManager.Instance.processMachines[randomSelect];
        }
        GoToMachine();
    }
    public void GoToMachine()
    {
        aiMoving.GoTargetStart(targetTR);
        if (currentTargetMachine.errorActive)
        {
            aiMoving.BehaviourInit(StartErroredRepair);
        }
        else
        {
            aiMoving.BehaviourInit(StartRepairAnimation);
        }
    }
    void StartErroredRepair()
    {
        StartCoroutine(SetPosRepairMachine());
    }
    IEnumerator SetPosRepairMachine()
    {

        Vector3 firstPos = transform.position;
        Quaternion firstRot = transform.rotation;
        float counter = 0f;

        while (counter < 1f && repairActive)
        {
            counter += Time.deltaTime;
            transform.position = Vector3.Lerp(firstPos, targetTR.position, counter);
            transform.rotation = Quaternion.Lerp(firstRot, targetTR.rotation, counter);

            yield return null;
        }
        if (repairActive)
        {
            transform.position = targetTR.position;
            transform.rotation = targetTR.rotation;
            animator.SetBool("repair", true);
        }
        counter = 0f;
        while (counter < MRCUpgradeManager.Instance._characterUpgradeSettings.repairSpeed[Globals.repairSpeedLevel] && repairActive)
        {
            counter += Time.deltaTime;
            yield return null;
        }
        if (repairActive)
        {
            currentTargetMachine.MachineRepaired();
            animator.SetBool("repair", false);
            SelectGoMachine();
        }
    }
    void StartRepairAnimation()
    {
        StartCoroutine(SetPos());
    }
    IEnumerator SetPos()
    {

        Vector3 firstPos = transform.position;
        Quaternion firstRot = transform.rotation;
        float counter = 0f;

        while(counter < 1f && repairActive)
        {
            counter += Time.deltaTime;
            transform.position = Vector3.Lerp(firstPos, targetTR.position, counter);
            transform.rotation = Quaternion.Lerp(firstRot, targetTR.rotation, counter);

            yield return null;
        }
        if (repairActive)
        {
            transform.position = targetTR.position;
            transform.rotation = targetTR.rotation;
            animator.SetBool("repair", true);
        }
        counter = 0f;
        while (counter < 5f && repairActive)
        {
            counter += Time.deltaTime;
            yield return null;
        }
        if (repairActive)
        {
            animator.SetBool("repair", false);
            SelectGoMachine();
        }
    }
    public void WorkerRepairEnd()
    {
        animator.SetBool("repair", false);
        aiMoving.GoTargetStart(RepairManager.Instance.repairWorkerFirstPosTR);
        aiMoving.BehaviourInit(IdlePos);
    }
    void IdlePos()
    {
        StartCoroutine(IdleSetPos());
    }
    IEnumerator IdleSetPos()
    {

        Vector3 firstPos = transform.position;
        Quaternion firstRot = transform.rotation;
        float counter = 0f;

        while (counter < 1f)
        {
            counter += Time.deltaTime;
            transform.position = Vector3.Lerp(firstPos, RepairManager.Instance.repairWorkerFirstPosTR.position, counter);
            transform.rotation = Quaternion.Lerp(firstRot, RepairManager.Instance.repairWorkerFirstPosTR.rotation, counter);

            yield return null;
        }
        transform.position = RepairManager.Instance.repairWorkerFirstPosTR.position;
        transform.rotation = RepairManager.Instance.repairWorkerFirstPosTR.rotation;

    }
    public void GoExit()
    {
        animator.SetBool("repair", false);
        //aiMoving.GoTargetStart(machineRepairArea.repairExitPos);
        aiMoving.BehaviourInit(SelfClose);
    }
    void SelfClose()
    {

        gameObject.SetActive(false);
    }


    public void GoToMachineForRepair(ProcessMachine targetMachine)
    {
        if (!repairActive)
        {
     
            if (PlayerPrefs.GetInt("machineerrorcount") == 0)
            {
                targetTR = targetMachine.machineRepairArea.machineRepairListAll[0].workerRepairPosTR;
                aiMoving.GoTargetStart(targetTR);
                aiMoving.BehaviourInit(SetPos_Machine);
                transform.position = targetTR.position;
            }
            else
            {
                targetTR = targetMachine.repairWorkerWaitingPosForRepair_TR;
                aiMoving.GoTargetStart(targetMachine.repairWorkerWaitingPosForRepair_TR);
                aiMoving.BehaviourInit(SetPos_Machine);
            }
        }
    }
    public void SetPos_Machine()
    {
        StartCoroutine(SetPosMachine());
    }
    IEnumerator SetPosMachine()
    {

        Vector3 firstPos = transform.position;
        Quaternion firstRot = transform.rotation;
        float counter = 0f;

        while (counter < 1f)
        {
            counter += Time.deltaTime;
            transform.position = Vector3.Lerp(firstPos, targetTR.position, counter);
            transform.rotation = Quaternion.Lerp(firstRot, targetTR.rotation, counter);

            yield return null;
        }

        transform.position = targetTR.position;
        transform.rotation = targetTR.rotation;
    }
    public void RepairmanGoToWaitingPos()
    {
        if (!repairActive)
        {
            WorkerRepairEnd();
        }
    }
    public void OnlyRepairAnim()
    {
        animator.SetBool("repair", true);
    }
}

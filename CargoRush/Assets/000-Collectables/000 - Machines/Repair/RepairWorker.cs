using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairWorker : MonoBehaviour
{
    public AIMoving aiMoving;
    public Animator animator;
    public MachineRepairArea machineRepairArea;
    public ShowBuyRapairReward showBuyRapairReward;
    public void GoToMachine()
    {
        aiMoving.GoTargetStart(machineRepairArea.targetMachinePos);
        aiMoving.BehaviourInit(StartRepairAnimation);
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

        while(counter < 1f)
        {
            counter += Time.deltaTime;
            transform.position = Vector3.Lerp(firstPos, machineRepairArea.targetMachinePos.position, counter);
            transform.rotation = Quaternion.Lerp(firstRot, machineRepairArea.targetMachinePos.rotation, counter);

            yield return null;
        }
        transform.position = machineRepairArea.targetMachinePos.position;
        transform.rotation = machineRepairArea.targetMachinePos.rotation;
        animator.SetBool("repair", true);
    }
    public void GoExit()
    {
        animator.SetBool("repair", false);
        aiMoving.GoTargetStart(machineRepairArea.repairExitPos);
        aiMoving.BehaviourInit(SelfClose);
    }
    void SelfClose()
    {

        gameObject.SetActive(false);
    }
}

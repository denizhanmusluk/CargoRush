using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MachineRepairArea : MonoBehaviour
{
    public ProcessMachine processMachine;
    [SerializeField] Image imageFill;
    bool upgradeOpenActive = false;

    bool repairActive = false;
    public RepairWorker repairWorker;
    public Transform repairCreatePos;
    public Transform targetMachinePos;
    public Transform repairExitPos;
    bool repairStarted = false;
    private void OnEnable()
    {
        repairActive = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && !repairStarted)
        {
            upgradeOpenActive = true;
            StartCoroutine(CooldownActive(2f));
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && !repairStarted)
        {
            upgradeOpenActive = false;
        }
    }

    IEnumerator CooldownActive(float time)
    {
        float counter = 0f;
        while (counter < time && upgradeOpenActive)
        {
            counter += Time.deltaTime;
            imageFill.fillAmount = counter / time;
            yield return null;
        }
        if (counter >= time)
        {
            upgradeOpenActive = false;
            RepairStarted();
            StartCoroutine(CooldownPasive());
        }
        else
        {
            StartCoroutine(CooldownPasive());
        }
    }

    IEnumerator CooldownPasive()
    {
        float lastValue = imageFill.fillAmount;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 4 * Time.deltaTime;
            imageFill.fillAmount = Mathf.Lerp(lastValue, 0, counter);

            yield return null;
        }
    }
    void RepairStarted()
    {
        repairActive = false;
        StartCoroutine(RepairStartedDelay());
    }
    IEnumerator RepairStartedDelay()
    {
        repairStarted = true;
        repairWorker.transform.position = repairCreatePos.position;
        yield return new WaitForSeconds(0.1f);
        repairWorker.gameObject.SetActive(true);
        repairWorker.GoToMachine();

        yield return new WaitForSeconds(4f);
        processMachine.RepairStarter();
        yield return new WaitForSeconds(0.5f);

        repairActive = true;
        repairStarted = false;
        gameObject.SetActive(false);
        
    }
}

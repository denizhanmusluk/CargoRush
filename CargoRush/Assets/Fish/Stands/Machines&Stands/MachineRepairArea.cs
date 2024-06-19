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
    private void OnEnable()
    {
        repairActive = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            upgradeOpenActive = true;
            StartCoroutine(CooldownActive(0.7f));
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
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
        processMachine.RepairStarter();
        yield return new WaitForSeconds(0.5f);

        repairActive = true;
        gameObject.SetActive(false);
        
    }
}

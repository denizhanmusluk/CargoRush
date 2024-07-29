using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MachineRepair : MonoBehaviour
{
    [SerializeField] Image imageFill;
    bool upgradeOpenActive = false;
    public bool repairStarted = false;
    public MachineRepairArea machineRepairArea;
    private void OnEnable()
    {
        imageFill.fillAmount = 0;
        repairStarted = false;

        //if (PlayerPrefs.GetInt("firsterrormachine") == 0)
        //{
        //    TutorialManager.Instance.repairMachineGO.SetActive(true);
        //    IndicatorManager.Instance.IndicaorActive(transform);
        //}
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && !repairStarted)
        {
            PlayerController.Instance.PlayerControlDeActive();
            PlayerController.Instance.animator.SetBool("repair", true);
            upgradeOpenActive = true;
            StartCoroutine(CooldownActive(2f));
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && !repairStarted)
        {
            PlayerController.Instance.PlayerControl_ReActive();
            PlayerController.Instance.animator.SetBool("repair", false);
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
            //StartCoroutine(CooldownPasive());
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
        StartCoroutine(RepairStartedDelay());
        PlayerController.Instance.PlayerControl_ReActive();
        PlayerController.Instance.animator.SetBool("repair", false);
    }
    IEnumerator RepairStartedDelay()
    {
        //if (PlayerPrefs.GetInt("firsterrormachine") == 0)
        //{
        //    PlayerPrefs.SetInt("firsterrormachine", 1);
        //    TutorialManager.Instance.repairMachineGO.SetActive(false);
        //    IndicatorManager.Instance.IndicaorDeActive();
        //}
        repairStarted = true;

        machineRepairArea.RepairingCheck();


        yield return new WaitForSeconds(0.5f);
        imageFill.fillAmount = 0;
        gameObject.SetActive(false);
    }
}

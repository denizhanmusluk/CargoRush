using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MachineRepair : MonoBehaviour
{
    [SerializeField] Image imageFill;
    [SerializeField] Image imageRepairFill;
    bool upgradeOpenActive = false;
    public bool repairStarted = false;
    public MachineRepairArea machineRepairArea;
    public Transform characterRepairPosTR;
    public Transform workerRepairPosTR;
    public int id = 0;
    private void OnEnable()
    {
        imageFill.fillAmount = 0;
        imageRepairFill.fillAmount = 0;

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

            upgradeOpenActive = true;
            StartCoroutine(CooldownActive(1f));
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && !repairStarted)
        {
            //PlayerController.Instance.PlayerControl_ReActive();
            //PlayerController.Instance.animator.SetBool("repair", false);
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
        if (PlayerPrefs.GetInt("firstrepairactive") == 0)
        {
            PlayerPrefs.SetInt("firstrepairactive", 1);
            RepairManager.Instance.repairWorker.OnlyRepairAnim();
        }
    }
    IEnumerator RepairStartedDelay()
    {
        PlayerController.Instance.PlayerControlDeActive();
        PlayerController.Instance.animator.SetBool("repair", true);
        PlayerController.Instance.CharacterRepairPosSet(characterRepairPosTR);

        float counter = 0f;
        while (counter < 1f)
        {
            counter += 0.2f * Time.deltaTime;
            imageRepairFill.fillAmount = Mathf.Lerp(0, 1, counter);

            yield return null;
        }
        repairStarted = true;

        machineRepairArea.RepairingCheck();

        PlayerController.Instance.PlayerControl_ReActive();
        PlayerController.Instance.animator.SetBool("repair", false);

        if (PlayerPrefs.GetInt("firstrepairactive") == 1)
        {
            PlayerPrefs.SetInt("firstrepairactive", 2);
            PopUpManager.Instance.repairPopUp.SetActive(true);
        }

        yield return new WaitForSeconds(0.5f);
        imageRepairFill.fillAmount = 0;
        imageFill.fillAmount = 0;
        gameObject.SetActive(false);
       
    }
}

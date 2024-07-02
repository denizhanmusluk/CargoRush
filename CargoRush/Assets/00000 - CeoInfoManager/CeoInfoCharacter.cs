using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CeoInfoCharacter : MonoBehaviour
{
    //[SerializeField] Image imageFill;
    bool upgradeOpenActive = false;

    public AIMoving aiMoving;
    public Animator animator;

    public bool openUIActive = false;
    public Transform canvasGO;
    private void Update()
    {
        Quaternion cameraRot = Camera.main.transform.rotation;
        canvasGO.transform.rotation = Quaternion.Euler(cameraRot.eulerAngles.x, cameraRot.eulerAngles.y, cameraRot.eulerAngles.z);
    }
    public void GoToWaitingArea()
    {
        aiMoving.GoTargetStart(CeoInfoManager.Instance.ceoTargetPos);
        aiMoving.BehaviourInit(StopAfterArrived);
    }

    void StopAfterArrived()
    {
        openUIActive = true;
        StartCoroutine(SetPos());
    }
    IEnumerator SetPos()
    {

        Vector3 firstPos = transform.position;
        Quaternion firstRot = transform.rotation;
        float counter = 0f;

        while (counter < 1f)
        {
            counter += Time.deltaTime;
            transform.position = Vector3.Lerp(firstPos, CeoInfoManager.Instance.ceoTargetPos.position, counter);
            transform.rotation = Quaternion.Lerp(firstRot, CeoInfoManager.Instance.ceoTargetPos.rotation, counter);

            yield return null;
        }
        transform.position = CeoInfoManager.Instance.ceoTargetPos.position;
        transform.rotation = CeoInfoManager.Instance.ceoTargetPos.rotation;
    }
    public void GoExit()
    {
        openUIActive = false;

        aiMoving.GoTargetStart(CeoInfoManager.Instance.ceoExitPos);
        aiMoving.BehaviourInit(SelfClose);
    }
    void SelfClose()
    {
        gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && openUIActive)
        {
            upgradeOpenActive = true;
            StartCoroutine(CooldownActive(0.1f));
            IndicatorManager.Instance.IndicaorDeActive();
            TutorialManager.Instance.goToManagerGO.SetActive(false);

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && openUIActive)
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
            //imageFill.fillAmount = counter / time;
            yield return null;
        }
        if (counter >= time)
        {
            upgradeOpenActive = false;
            InfoOpen();
            StartCoroutine(CooldownPasive());
        }
        else
        {
            StartCoroutine(CooldownPasive());
        }
    }

    IEnumerator CooldownPasive()
    {
        //float lastValue = imageFill.fillAmount;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 4 * Time.deltaTime;
            //imageFill.fillAmount = Mathf.Lerp(lastValue, 0, counter);

            yield return null;
        }
    }
    void InfoOpen()
    {
        CeoInfoManager.Instance.BoxUIOpen();
        PlayerController.Instance.PlayerControlDeActive();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ShowBuyRapairReward : MonoBehaviour
{
    public GameObject Canvas;
    Vector3 firstSize;
    public bool firstOpenCloseCanvas = false;
    public bool showActive = false;
    //public ProcessMachine processMachine;
    public void ADV_ButtonClick()
    {
        showActive = false;
        Canvas.SetActive(false);
        string adv_name = "";
        ADVManager.Instance.RewardedStart(RepairImmediate,adv_name);
    }
    public void RepairImmediate()
    {
        //processMachine.repairTimeCounter = processMachine.repairTime - 1;
        string tag = "InstantRepairRewarded";
        GameManager.Instance.GameAnalyticsTag(tag);
        RepairManager.Instance.RepairWorkerStart();
        Canvas.SetActive(true);
        GameManager.Instance.ui.joyStick.SetActive(true);
    }
    private void Start()
    {
        firstSize = Canvas.transform.localScale;
        if (firstOpenCloseCanvas)
        {
            Canvas.transform.localScale = Vector3.zero;
        }
    }
    private void Update()
    {
        Quaternion cameraRot = Camera.main.transform.rotation;
        Canvas.transform.rotation = Quaternion.Euler(cameraRot.eulerAngles.x, cameraRot.eulerAngles.y, cameraRot.eulerAngles.z);
        if(PlayerPrefs.GetInt("level") == 1)
        {
            //Canvas.transform.rotation = Quaternion.Euler(cameraRot.eulerAngles.x, cameraRot.eulerAngles.y, cameraRot.eulerAngles.z);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            GameManager.Instance.ui.joyStick.GetComponent<FloatingJoystick>().PointerUpManuel();
            GameManager.Instance.ui.joyStick.SetActive(false);

            if (PlayerPrefs.GetInt("machineerrorcount") == 2 && PlayerPrefs.GetInt("purchaserepairboost") == 0)
            {
                IndicatorManager.Instance.IndicaorDeActive();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            StartCoroutine(OpenCanvas());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            StartCoroutine(CloseCanvas());
            GameManager.Instance.ui.joyStick.SetActive(true);
        }
    }

    IEnumerator OpenCanvas()
    {
        OpenScale(0f, 0.8f, 0.25f, Ease.InFlash);
        yield return new WaitForSeconds(0.25f);
        OpenScale(0.8f, 1f, 0.25f, Ease.OutElastic);
    }
    IEnumerator CloseCanvas()
    {
        CloseScale(1f, 0.8f, 0.1f, Ease.InElastic);
        yield return new WaitForSeconds(0.1f);
        CloseScale(0.8f, 0f, 0.25f, Ease.InFlash);
    }


    public Tween OpenScale(float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                Canvas.transform.localScale = firstSize * value;
            }).OnComplete(delegate ()
            {
            });
        return tween;
    }

    public Tween CloseScale(float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                Canvas.transform.localScale = firstSize * value;
            }).OnComplete(delegate ()
            {
            });
        return tween;
    }
}

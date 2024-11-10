using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using HomaGames.HomaBelly;

public class ShowTrainReward : MonoBehaviour
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
        string adv_name = "Train_REWARDED";
        ADVManager.Instance.RewardedStart(TrainImmediate, adv_name, true);



    }
    public void TrainImmediate(bool ticketActive)
    {
        Canvas.SetActive(false);

        //processMachine.repairTimeCounter = processMachine.repairTime - 1;
        string _tag = "Train_REWARDED";
        //GameManager.Instance.GameAnalyticsTag(tag);
        //GameManager.Instance.HomaAnalyticsTag(tag);

        TrainManager.Instance.TrainStart();
        //Canvas.SetActive(true);
        GameManager.Instance.ui.joyStick.SetActive(true);


        //if (PlayerPrefs.GetInt("firstclicktrainrew") > 0)
        {
            if (ticketActive)
            {
                Analytics.ItemObtained(_tag, 0, ItemFlowReason.Progression);
                Analytics.ItemConsumed(_tag, 0, ItemFlowReason.Progression);
            }
            else
            {
                Analytics.ItemObtained(_tag, 0, ItemFlowReason.RewardedVideoAd);
                Analytics.ItemConsumed(_tag, 0, ItemFlowReason.RewardedVideoAd);
            }

        }
        PlayerPrefs.SetInt("firstclicktrainrew", 1);

    }
    private void Start()
    {
        firstSize = Canvas.transform.localScale;
        if (firstOpenCloseCanvas)
        {
            Canvas.transform.localScale = Vector3.zero;
        }
        Adv_Free_Button_Check();


    }
    void Adv_Free_Button_Check()
    {
        if (PlayerPrefs.GetInt("firstclicktrainrew") == 0)
        {
            TrainManager.Instance.freeButtonGO.SetActive(true);
            TrainManager.Instance.advButtonGO.SetActive(false);
        }
        else
        {
            TrainManager.Instance.freeButtonGO.SetActive(false);
            TrainManager.Instance.advButtonGO.SetActive(true);
        }
    }
    private void Update()
    {
        Quaternion cameraRot = Camera.main.transform.rotation;
        Canvas.transform.rotation = Quaternion.Euler(cameraRot.eulerAngles.x, cameraRot.eulerAngles.y, cameraRot.eulerAngles.z);
        if (PlayerPrefs.GetInt("level") == 1)
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

            //if (PlayerPrefs.GetInt("machineerrorcount") == 2 && PlayerPrefs.GetInt("purchaserepairboost") == 0)
            //{
            //    IndicatorManager.Instance.IndicaorDeActive();
            //}
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            StartCoroutine(OpenCanvas());
            Adv_Free_Button_Check();
            if (PlayerPrefs.GetInt("traintutorial") == 1)
            {
                PlayerPrefs.SetInt("traintutorial", 2);
                IndicatorManager.Instance.IndicaorDeActive();
            }
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

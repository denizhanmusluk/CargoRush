using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TrainManager : Singleton<TrainManager>
{
    public GameObject freeButtonGO;
    public GameObject advButtonGO;
    public ShowTrainReward showTrainReward;
    public TrainParent train;
    [SerializeField] GameObject progressCanvasGO;
    [SerializeField] Image imageFill;
    bool trainOpenActive = false;

    TextMeshProUGUI trainCooldownTxt;
    private void Start()
    {
        trainCooldownTxt = RewardPanel.Instance.trainCounterText;
        if(PlayerPrefs.GetInt("openedtrain") == 1)
        {
            TrainActivator();
        }

        StartCoroutine(PurchaseTrain_CheckDelay());
    }
    IEnumerator PurchaseTrain_CheckDelay()
    {
        yield return new WaitForSeconds(2f);
        if (PlayerPrefs.GetInt("purchasetrainboost") == 1)
        {
            PurchaseTrainImmediateActive();
        }
    }
    public void TrainActivator()
    {
        PlayerPrefs.SetInt("openedtrain", 1);

        if (PlayerPrefs.GetInt("purchasetrainboost") == 0)
        {
            showTrainReward.gameObject.SetActive(true);
        }

        if (PlayerPrefs.GetInt("traintutorial") == 0)
        {
            PlayerPrefs.SetInt("traintutorial", 1);
            StartCoroutine(Tutorial_Delay());
        }
    }
    IEnumerator Tutorial_Delay()
    {
        yield return new WaitForSeconds(5f);
        {
            IndicatorManager.Instance.IndicaorActive(showTrainReward.transform);
        }
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.GetComponent<PlayerController>() != null && !Globals.trainActive)
    //    {

    //        trainOpenActive = true;
    //        StartCoroutine(CooldownActive(1f));
    //    }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.GetComponent<PlayerController>() != null)
    //    {

    //        trainOpenActive = false;
    //    }
    //}

    IEnumerator CooldownActive(float time)
    {
        float counter = 0f;
        while (counter < time && trainOpenActive)
        {
            counter += Time.deltaTime;
            imageFill.fillAmount = counter / time;
            yield return null;
        }
        if (counter >= time)
        {
            trainOpenActive = false;
            TrainStart();
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
    public void TrainStart()
    {
        train.gameObject.SetActive(false);
        PlayerController.Instance.TrainActive();
        TrainCooldownStart();
    }

    public void TrainCooldownStart()
    {
        StartCoroutine(TrainCooldown());
    }
    IEnumerator TrainCooldown()
    {
        Globals.trainExtraStack = (Globals.trainWagonLevel + 1) * (MRCUpgradeManager.Instance._characterUpgradeSettings.extraCapacityPerWagon[Globals.wagonCapacityLevel] + CharacterUpgradeManager.Instance._characterUpgradeSettings.stackCapacity[Globals.stackCapacityLevel]);
        //progressCanvasGO.SetActive(false);
        RewardPanel.Instance.trainRewardPanelGO.SetActive(true);
        int timer = 0;

        while (timer < MRCUpgradeManager.Instance._characterUpgradeSettings.trainUsageTime[Globals.trainUsageTimeLevel])
        {
            Globals.trainExtraStack = (Globals.trainWagonLevel + 1) * (MRCUpgradeManager.Instance._characterUpgradeSettings.extraCapacityPerWagon[Globals.wagonCapacityLevel] + CharacterUpgradeManager.Instance._characterUpgradeSettings.stackCapacity[Globals.stackCapacityLevel]);
            trainCooldownTxt.text = ConvertSecondToMinSec.Converter(MRCUpgradeManager.Instance._characterUpgradeSettings.trainUsageTime[Globals.trainUsageTimeLevel] - timer);
            timer++;
            yield return new WaitForSeconds(1);
        }

        trainCooldownTxt.text = "00:00";
        RewardPanel.Instance.trainRewardPanelGO.SetActive(false);
        //progressCanvasGO.SetActive(true);
        PlayerController.Instance.CloseTrain();
        showTrainReward.Canvas.SetActive(true);
        showTrainReward.SetUsageTimeText();
        train.gameObject.SetActive(true);

        Globals.trainExtraStack = 0;
    }
    public void PurchaseTrainImmediateActive()
    {
        PlayerPrefs.SetInt("purchasetrainboost", 1);
        PlayerController.Instance.TrainActive();
        showTrainReward.gameObject.SetActive(false);

    }
}

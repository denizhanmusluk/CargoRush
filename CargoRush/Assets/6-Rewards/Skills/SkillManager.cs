using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SkillManager : MonoBehaviour
{
    private static SkillManager _instance = null;
    public static SkillManager Instance => _instance;
    [SerializeField] Color targetColor;
    Color firstColor;
    public int extraStack = 5;

    public int hoverboardRewardTime;
    TextMeshProUGUI hoverboardCounterText;


    public int capacityRewardTime;
    TextMeshProUGUI capacityCounterText;

    public int doubleIncomeRewardTime;
    TextMeshProUGUI doubleIncomeCounterText;


    [SerializeField] int speedRewPeriod;
    [SerializeField] int capacityRewPeriod;
    [SerializeField] int doubleIncomeRewPeriod;
    [SerializeField] int moneyRewPeriod;

    public List<Transform> speedRewardPos = new List<Transform>();
    [SerializeField] GameObject[] speedRewards;

    public List<Transform> capacityRewardPos = new List<Transform>();
    [SerializeField] GameObject[] capacityRewards;

    public List<Transform> doubleIncomeRewardPos = new List<Transform>();
    [SerializeField] GameObject[] doubleIncomeRewards;

    public List<Transform> moneyRewardPos = new List<Transform>();
    [SerializeField] GameObject[] moneyRewards;

    private void Awake()
    {
        _instance = this;
    }

    public void HoverboardActive()
    {
        int rewardSelect = PlayerPrefs.GetInt("speedskil") % 3;
        Globals.hoverboardActive = true;
        RewardPanel.Instance.hoverboardPanelGO.SetActive(true);
        StartCoroutine(Hoverboard_Reset(hoverboardRewardTime));

        if(rewardSelect == 0)
        {
            PlayerController.Instance.BandBoardActive();
        }
        else if(rewardSelect == 1)
        {
            PlayerController.Instance.SkateBoardActive();
        }
        else
        {
            PlayerController.Instance.HoverBoardActive();
        }



        PlayerPrefs.SetInt("speedskil", PlayerPrefs.GetInt("speedskil") + 1);

        //if (PlayerPrefs.GetInt("hoverboardskill") % 2 == 0)
        //{
        //    PlayerController.Instance.HoverBoardActive();
        //}
        //else
        //{
        //    PlayerController.Instance.SkateBoardActive();
        //}
        //PlayerPrefs.SetInt("hoverboardskill", PlayerPrefs.GetInt("hoverboardskill") + 1);
    }
    bool speedCoroutineActive;
    IEnumerator Hoverboard_Reset(int rewardTime)
    {
        speedCoroutineActive = false;
        yield return new WaitForSeconds(1);
        speedCoroutineActive = true;
        int counter = rewardTime;
        while (counter > 0 && speedCoroutineActive)
        {
            int minute = Mathf.FloorToInt(counter / 60);
            int second = Mathf.FloorToInt(counter % 60);

            hoverboardCounterText.text = minute.ToString() + ":" + ($"{second}");
            if (minute < 10)
            {
                hoverboardCounterText.text = "0" + minute.ToString() + ":" + ($"{second}");

            }
            if (second < 10)
            {
                hoverboardCounterText.text = minute.ToString() + ":0" + ($"{second}");
                if (minute < 10)
                {
                    hoverboardCounterText.text = "0" + minute.ToString() + ":0" + ($"{second}");

                }
                if (counter <= 3)
                {
                    StartCoroutine(CounterTextColorSet(hoverboardCounterText));
                    VibratoManager.Instance.LightVibration();
                }
            }
            counter--;
            yield return new WaitForSeconds(1);
            if (!Globals.holePlatformActive)
            {
                RewardPanel.Instance.hoverboardPanelGO.SetActive(true);
            }
        }
        if (counter <= 0)
        {
            hoverboardCounterText.text = "00:00";
            PlayerController.Instance.NoneVehicle();
            RewardPanel.Instance.hoverboardPanelGO.SetActive(false);
            Globals.isSpeedRewardCreated = false;

            if (PlayerPrefs.GetInt("firstusagespeedboost") == 0)
            {
                PlayerPrefs.SetInt("firstusagespeedboost", 1);
                PurchaseManager.Instance.Speed_PopUp_Open();
            }

        }
        Globals.hoverboardActive = false;
    }


    public void CapacityActive()
    {
        //PlayerController.Instance.CapacityUp();
        RewardPanel.Instance.capacityPanelGO.SetActive(true);
        StartCoroutine(Capacity_Reset(capacityRewardTime));
        Globals.extraStack = extraStack;


    }
    bool capacityCoroutineActive;
    IEnumerator Capacity_Reset(int rewardTime)
    {
        capacityCoroutineActive = false;
        yield return new WaitForSeconds(1);
        capacityCoroutineActive = true;
        int counter = rewardTime;

        while (counter > 0 && capacityCoroutineActive)
        {
            int minute = Mathf.FloorToInt(counter / 60);
            int second = Mathf.FloorToInt(counter % 60);

            capacityCounterText.text = minute.ToString() + ":" + ($"{second}");
            if (minute < 10)
            {
                capacityCounterText.text = "0" + minute.ToString() + ":" + ($"{second}");

            }
            if (second < 10)
            {
                capacityCounterText.text = minute.ToString() + ":0" + ($"{second}");
                if (minute < 10)
                {
                    capacityCounterText.text = "0" + minute.ToString() + ":0" + ($"{second}");

                }
                if (counter <= 3)
                {
                    StartCoroutine(CounterTextColorSet(capacityCounterText));
                    VibratoManager.Instance.LightVibration();
                }
            }
            counter--;
            yield return new WaitForSeconds(1);
            if (!Globals.holePlatformActive)
            {
                RewardPanel.Instance.capacityPanelGO.SetActive(true);
            }
        }
        if (counter <= 0)
        {
            capacityCounterText.text = "00:00";
            RewardPanel.Instance.capacityPanelGO.SetActive(false);
            Globals.extraStack = 0;
            PlayerController.Instance.CapacityReset();
            Globals.isCapacityRewardCreated = false;
            if (PlayerPrefs.GetInt("firstusagecapacityboost") == 0)
            {
                PlayerPrefs.SetInt("firstusagecapacityboost", 1);
                PurchaseManager.Instance.DoubleCapacity_PopUp_Open();
            }
        }
    }

    public void DoubleIncomeActive()
    {
        RewardPanel.Instance.doubleIncomePanelGO.SetActive(true);
        StartCoroutine(DoubleIncome_Reset(doubleIncomeRewardTime));
        Globals.doubleIncomeActive = true;

    }
    bool doubleIncomeCoroutineActive;
    IEnumerator DoubleIncome_Reset(int rewardTime)
    {
        doubleIncomeCoroutineActive = false;
        yield return new WaitForSeconds(1);
        doubleIncomeCoroutineActive = true;
        int counter = rewardTime;

        while (counter > 0 && doubleIncomeCoroutineActive)
        {
            int minute = Mathf.FloorToInt(counter / 60);
            int second = Mathf.FloorToInt(counter % 60);

            doubleIncomeCounterText.text = minute.ToString() + ":" + ($"{second}");
            if (minute < 10)
            {
                doubleIncomeCounterText.text = "0" + minute.ToString() + ":" + ($"{second}");

            }
            if (second < 10)
            {
                doubleIncomeCounterText.text = minute.ToString() + ":0" + ($"{second}");
                if (minute < 10)
                {
                    doubleIncomeCounterText.text = "0" + minute.ToString() + ":0" + ($"{second}");

                }
                if (counter <= 3)
                {
                    StartCoroutine(CounterTextColorSet(doubleIncomeCounterText));
                    VibratoManager.Instance.LightVibration();
                }
            }
            counter--;
            yield return new WaitForSeconds(1);
            if (!Globals.holePlatformActive)
            {
                RewardPanel.Instance.doubleIncomePanelGO.SetActive(true);
            }
        }

        if (counter <= 0)
        {
            doubleIncomeCounterText.text = "00:00";
            RewardPanel.Instance.doubleIncomePanelGO.SetActive(false);
            Globals.doubleIncomeActive = false;
            Globals.isDoubleIncomeRewardCreated = false;
            if (PlayerPrefs.GetInt("firstusageincomeboost") == 0)
            {
                PlayerPrefs.SetInt("firstusageincomeboost", 1);
                PurchaseManager.Instance.DoubleIncome_PopUp_Open();
            }
        }

    }
    IEnumerator CounterTextColorSet(TextMeshProUGUI txt)
    {
        float counter = 0f;
        float value = 0f;
        while (counter < 1f)
        {
            counter += Time.deltaTime;
            value = (Mathf.Sin(Mathf.PI * counter));
            //holeTimerBG_Image.color = Color.Lerp(firstColor, targetColor, value);
            txt.color = Color.Lerp(firstColor, targetColor, value);
            yield return null;
        }
    }





    private void Start()
    {
        StartCoroutine(StartDelay());
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(5f);

        Globals.speedPlayTime = PlayerPrefs.GetInt("speedPlayTime");
        Globals.speedCreatingCooldown = PlayerPrefs.GetInt("speedCreatingCooldown");
        if (PlayerPrefs.GetInt("purchasespeedboost") == 0)
        {
            StartCoroutine(SpeedTimeCounter());
        }
        else
        {
            PurchaseSpeedBoostActive();
        }


        Globals.capacityPlayTime = PlayerPrefs.GetInt("capacityPlayTime");
        Globals.capacityCreatingCooldown = PlayerPrefs.GetInt("capacityCreatingCooldown");
        if (PlayerPrefs.GetInt("purchasecapacityboost") == 0)
        {
            StartCoroutine(CapacityTimeCounter());
        }
        else
        {
            PurchaseCapacityBoostActive();
        }

        Globals.doubleIncomePlayTime = PlayerPrefs.GetInt("doubleIncomePlayTime");
        Globals.doubleCreatingCooldown = PlayerPrefs.GetInt("doubleCreatingCooldown");
        if (PlayerPrefs.GetInt("purchasedoubleincomeboost") == 0)
        {
            StartCoroutine(DoubleIncomeTimeCounter());
        }
        else
        {
            PurchaseDoubleIncomeBoostActive();
        }



        Globals.moneyPlayTime = PlayerPrefs.GetInt("moneyPlayTime");
        Globals.moneyCreatingCooldown = PlayerPrefs.GetInt("moneyCreatingCooldown");
        StartCoroutine(MoneyTimeCounter());

        firstColor = Color.white;

        hoverboardCounterText = RewardPanel.Instance.hoverboardCounterText;

        capacityCounterText = RewardPanel.Instance.capacityCounterText;
        doubleIncomeCounterText = RewardPanel.Instance.doubleIncomeCounterText;


        if (PlayerPrefs.GetInt("purchaserepairboost") == 0)
        {
        }
        else
        {
            PurchaseRepairImmediateActive();
        }
    }

    IEnumerator SpeedTimeCounter()
    {
        while (true)
        {
            Globals.speedPlayTime++;
            PlayerPrefs.SetInt("speedPlayTime", Globals.speedPlayTime);

            if (PlayerPrefs.GetInt("skillActive") == 1)
            {
                Globals.speedCreatingCooldown++;
                PlayerPrefs.SetInt("speedCreatingCooldown", Globals.speedCreatingCooldown);
            }

            if (Globals.speedCreatingCooldown >= speedRewPeriod && !Globals.isSpeedRewardCreated)
            {
                if (PlayerPrefs.GetInt("purchasespeedboost") == 0)
                {
                    SpeedRewardCreate();
                }
            }
            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator CapacityTimeCounter()
    {
        while (true)
        {
            Globals.capacityPlayTime++;
            PlayerPrefs.SetInt("capacityPlayTime", Globals.capacityPlayTime);

            if (PlayerPrefs.GetInt("skillActive") == 1)
            {
                Globals.capacityCreatingCooldown++;
                PlayerPrefs.SetInt("capacityCreatingCooldown", Globals.capacityCreatingCooldown);
            }

            if (Globals.capacityCreatingCooldown >= capacityRewPeriod && !Globals.isCapacityRewardCreated)
            {
                //if (PlayerPrefs.GetInt("purchasecapacityboost") == 0)
                {
                    CapacityRewardCreate();
                }
            }
            yield return new WaitForSeconds(1);
        }
    }
    IEnumerator DoubleIncomeTimeCounter()
    {
        while (true)
        {
            Globals.doubleIncomePlayTime++;
            PlayerPrefs.SetInt("doubleIncomePlayTime", Globals.doubleIncomePlayTime);

            if (PlayerPrefs.GetInt("skillActive") == 1)
            {
                Globals.doubleCreatingCooldown++;
                PlayerPrefs.SetInt("doubleCreatingCooldown", Globals.doubleCreatingCooldown);
            }

            if (Globals.doubleCreatingCooldown >= doubleIncomeRewPeriod && !Globals.isDoubleIncomeRewardCreated)
            {
                if (PlayerPrefs.GetInt("purchasedoubleincomeboost") == 0)
                {
                    DoubleRewardCreate();
                }
            }
            yield return new WaitForSeconds(1);
        }
    }
    IEnumerator MoneyTimeCounter()
    {
        while (true)
        {
            Globals.moneyPlayTime++;
            PlayerPrefs.SetInt("moneyPlayTime", Globals.moneyPlayTime);

            if (PlayerPrefs.GetInt("skillActive") == 1)
            {
                Globals.moneyCreatingCooldown++;
                PlayerPrefs.SetInt("moneyCreatingCooldown", Globals.moneyCreatingCooldown);
            }

            if (Globals.moneyCreatingCooldown >= moneyRewPeriod && !Globals.isMoneyRewardCreated)
            {
                //Globals.skillCooldown = 0;
                //PlayerPrefs.SetInt("skillCooldown", Globals.skillCooldown);

                MoneyRewardCreate();
            }
            yield return new WaitForSeconds(1);
        }
    }
    public void SpeedRewardCreate()
    {
        Globals.isSpeedRewardCreated = true;
        Globals.speedCreatingCooldown = 0;
        PlayerPrefs.SetInt("speedCreatingCooldown", Globals.speedCreatingCooldown);


        int rewPosRandomSelcet = Random.Range(0, speedRewardPos.Count);
        int rewardSelect = Random.Range(0, speedRewards.Length);

        GameObject newReward = Instantiate(speedRewards[rewardSelect], speedRewardPos[rewPosRandomSelcet].transform.position, Quaternion.identity);


        //int rewardSelect = PlayerPrefs.GetInt("skill") % rewards.Length;
        //PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 1);
    }

    public void CapacityRewardCreate()
    {
        Globals.isCapacityRewardCreated = true;
        Globals.capacityCreatingCooldown = 0;
        PlayerPrefs.SetInt("capacityCreatingCooldown", Globals.capacityCreatingCooldown);

        int rewPosRandomSelcet = Random.Range(0, capacityRewardPos.Count);
        int rewardSelect = Random.Range(0, capacityRewards.Length);

        GameObject newReward = Instantiate(capacityRewards[rewardSelect], capacityRewardPos[rewPosRandomSelcet].transform.position, Quaternion.identity);
    }


    public void DoubleRewardCreate()
    {
        Globals.isDoubleIncomeRewardCreated = true;
        Globals.doubleCreatingCooldown = 0;
        PlayerPrefs.SetInt("doubleCreatingCooldown", Globals.doubleCreatingCooldown);

        int rewPosRandomSelcet = Random.Range(0, doubleIncomeRewardPos.Count);
        int rewardSelect = Random.Range(0, doubleIncomeRewards.Length);

        GameObject newReward = Instantiate(doubleIncomeRewards[rewardSelect], doubleIncomeRewardPos[rewPosRandomSelcet].transform.position, Quaternion.identity);
    }

    public void MoneyRewardCreate()
    {
        Globals.isMoneyRewardCreated = true;
        Globals.moneyCreatingCooldown = 0;
        PlayerPrefs.SetInt("moneyCreatingCooldown", Globals.moneyCreatingCooldown);

        int rewPosRandomSelcet = Random.Range(0, moneyRewardPos.Count);
        int rewardSelect = Random.Range(0, moneyRewards.Length);

        GameObject newReward = Instantiate(moneyRewards[rewardSelect], moneyRewardPos[rewPosRandomSelcet].transform.position, Quaternion.identity);

        if(newReward.GetComponent<MoneySkill>() != null)
        {
            newReward.GetComponent<MoneySkill>().moneyValue = (Globals.collectableLevel * 300) + (Globals.openedCarSlotCount * 200) * (PlayerPrefs.GetInt("level") + 1);
               newReward.GetComponent<MoneySkill>().ValueInit();
        }
    }

    public void PurchaseSpeedBoostActive()
    {
        PlayerPrefs.SetInt("purchasespeedboost", 1);
        PlayerController.Instance.BandBoardActive();
    }
    public void PurchaseCapacityBoostActive()
    {
        PlayerPrefs.SetInt("purchasecapacityboost", 1);
        Globals.stackFactor = 2;
        //Globals.extraStack = extraStack;
    }
    public void PurchaseDoubleIncomeBoostActive()
    {
        PlayerPrefs.SetInt("purchasedoubleincomeboost", 1);
        Globals.doubleIncomeActive = true;
    }

    public void PurchaseRepairImmediateActive()
    {
        PlayerPrefs.SetInt("purchaserepairboost", 1);
        RepairManager.Instance.repairWorker.showBuyRapairReward.RepairImmediate();
        RepairManager.Instance.repairWorker.showBuyRapairReward.Canvas.SetActive(false);
    }
}
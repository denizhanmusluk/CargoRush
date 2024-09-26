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

    public List<RewardPos> speedRewardPos = new List<RewardPos>();
    [SerializeField] GameObject[] speedRewards;

    public List<RewardPos> capacityRewardPos = new List<RewardPos>();
    [SerializeField] GameObject[] capacityRewards;

    public List<RewardPos> doubleIncomeRewardPos = new List<RewardPos>();
    [SerializeField] GameObject[] doubleIncomeRewards;

    public List<RewardPos> moneyRewardPos = new List<RewardPos>();
    [SerializeField] GameObject[] moneyRewards;
    [SerializeField] float expensiveCostFactor = 0.6f;


    public List<IBuyCost> buyAreaList = new List<IBuyCost>();

    Transform currentSpeedReward_TR;
    Transform currentCapacityReward_TR;
    Transform currentDoubleIncomeReward_TR;
    Transform currentMoneyReward_TR;
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

            int _speedRewPeriod = speedRewPeriod;
            if (PlayerPrefs.GetInt("speedRewCount") == 0)
            {
                _speedRewPeriod = 180;
            }

            if (Globals.speedCreatingCooldown >= _speedRewPeriod && !Globals.isSpeedRewardCreated)
            {
                if (PlayerPrefs.GetInt("purchasespeedboost") == 0)
                {
                    SpeedRewardCreate();

                    PlayerPrefs.SetInt("speedRewCount", PlayerPrefs.GetInt("speedRewCount") + 1);
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

            int _capacityRewPeriod = capacityRewPeriod;
            if (PlayerPrefs.GetInt("capacityRewCount") == 0)
            {
                _capacityRewPeriod = 180;
            }

            if (Globals.capacityCreatingCooldown >= _capacityRewPeriod && !Globals.isCapacityRewardCreated)
            {
                //if (PlayerPrefs.GetInt("purchasecapacityboost") == 0)
                {
                    CapacityRewardCreate();

                    PlayerPrefs.SetInt("capacityRewCount", PlayerPrefs.GetInt("capacityRewCount") + 1);
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

            int _doubleIncomeRewPeriod = doubleIncomeRewPeriod;
            if (PlayerPrefs.GetInt("doubleRewCount") == 0)
            {
                _doubleIncomeRewPeriod = 180;
            }

            if (Globals.doubleCreatingCooldown >= _doubleIncomeRewPeriod && !Globals.isDoubleIncomeRewardCreated)
            {
                if (PlayerPrefs.GetInt("purchasedoubleincomeboost") == 0)
                {
                    DoubleRewardCreate();

                    PlayerPrefs.SetInt("doubleRewCount", PlayerPrefs.GetInt("doubleRewCount") + 1);
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

            int _moneyRewPeriod = moneyRewPeriod;
            if (PlayerPrefs.GetInt("moneyRewCount") == 0)
            {
                _moneyRewPeriod = 180;
            }

            if (Globals.moneyCreatingCooldown >= _moneyRewPeriod && !Globals.isMoneyRewardCreated)
            {
                //Globals.skillCooldown = 0;
                //PlayerPrefs.SetInt("skillCooldown", Globals.skillCooldown);

                MoneyRewardCreate();


                PlayerPrefs.SetInt("moneyRewCount", PlayerPrefs.GetInt("moneyRewCount") + 1);
            }
            yield return new WaitForSeconds(1);
        }
    }
    public void SpeedRewardCreate()
    {
        Globals.isSpeedRewardCreated = true;
        Globals.speedCreatingCooldown = 0;
        PlayerPrefs.SetInt("speedCreatingCooldown", Globals.speedCreatingCooldown);

        List<RewardPos> currnetLevelRewPosList = new List<RewardPos>();
        foreach(var spdrewpos in speedRewardPos)
        {
            if(spdrewpos.levelID == Globals.collectableLevel)
            {
                currnetLevelRewPosList.Add(spdrewpos);
            }
        }
        int rewPosRandomSelcet = Random.Range(0, currnetLevelRewPosList.Count);
        int rewardSelect = Random.Range(0, speedRewards.Length);

        GameObject currentSpeedReward;

        if (PlayerPrefs.GetInt("firstspeedcreate") == 0)
        {
            PlayerPrefs.SetInt("firstspeedcreate", 1);
            currentSpeedReward = Instantiate(speedRewards[rewardSelect], currnetLevelRewPosList[0].transform.position, Quaternion.identity);
        }
        else
        {
            currentSpeedReward = Instantiate(speedRewards[rewardSelect], currnetLevelRewPosList[rewPosRandomSelcet].transform.position, Quaternion.identity);
        }
        currentSpeedReward_TR = currentSpeedReward.transform;

        //int rewardSelect = PlayerPrefs.GetInt("skill") % rewards.Length;
        //PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 1);
    }

    public void CapacityRewardCreate()
    {
        Globals.isCapacityRewardCreated = true;
        Globals.capacityCreatingCooldown = 0;
        PlayerPrefs.SetInt("capacityCreatingCooldown", Globals.capacityCreatingCooldown);

        List<RewardPos> currnetLevelRewPosList = new List<RewardPos>();
        foreach (var capctyrewpos in capacityRewardPos)
        {
            if (capctyrewpos.levelID == Globals.collectableLevel)
            {
                currnetLevelRewPosList.Add(capctyrewpos);
            }
        }

        int rewPosRandomSelcet = Random.Range(0, currnetLevelRewPosList.Count);
        int rewardSelect = Random.Range(0, capacityRewards.Length);

        GameObject currentCapacityReward;
        if (PlayerPrefs.GetInt("firstcapacitycreate") == 0)
        {
            PlayerPrefs.SetInt("firstcapacitycreate", 1);
            currentCapacityReward = Instantiate(capacityRewards[rewardSelect], currnetLevelRewPosList[0].transform.position, Quaternion.identity);
        }
        else
        {
            currentCapacityReward = Instantiate(capacityRewards[rewardSelect], currnetLevelRewPosList[rewPosRandomSelcet].transform.position, Quaternion.identity);
        }
        currentCapacityReward_TR = currentCapacityReward.transform;

    }


    public void DoubleRewardCreate()
    {
        Globals.isDoubleIncomeRewardCreated = true;
        Globals.doubleCreatingCooldown = 0;
        PlayerPrefs.SetInt("doubleCreatingCooldown", Globals.doubleCreatingCooldown);

        List<RewardPos> currnetLevelRewPosList = new List<RewardPos>();
        foreach (var dblIncomeRewpos in doubleIncomeRewardPos)
        {
            if (dblIncomeRewpos.levelID == Globals.collectableLevel)
            {
                currnetLevelRewPosList.Add(dblIncomeRewpos);
            }
        }

        int rewPosRandomSelcet = Random.Range(0, currnetLevelRewPosList.Count);
        int rewardSelect = Random.Range(0, doubleIncomeRewards.Length);

        GameObject currentDoubleIncomeReward;
        if (PlayerPrefs.GetInt("firstdoubleincomecreate") == 0)
        {
            PlayerPrefs.SetInt("firstdoubleincomecreate", 1);
            currentDoubleIncomeReward = Instantiate(doubleIncomeRewards[rewardSelect], currnetLevelRewPosList[0].transform.position, Quaternion.identity);
        }
        else
        {
            currentDoubleIncomeReward = Instantiate(doubleIncomeRewards[rewardSelect], currnetLevelRewPosList[rewPosRandomSelcet].transform.position, Quaternion.identity);
        }
        currentDoubleIncomeReward_TR = currentDoubleIncomeReward.transform;

    }

    public void MoneyRewardCreate()
    {
        Globals.isMoneyRewardCreated = true;
        Globals.moneyCreatingCooldown = 0;
        PlayerPrefs.SetInt("moneyCreatingCooldown", Globals.moneyCreatingCooldown);

        List<RewardPos> currnetLevelRewPosList = new List<RewardPos>();
        foreach (var mnyRewpos in moneyRewardPos)
        {
            if (mnyRewpos.levelID == Globals.collectableLevel)
            {
                currnetLevelRewPosList.Add(mnyRewpos);
            }
        }

        int rewPosRandomSelcet = Random.Range(0, currnetLevelRewPosList.Count);
        int rewardSelect = Random.Range(0, moneyRewards.Length);

        GameObject currentMoneyReward;
        if (PlayerPrefs.GetInt("firstmoneycreate") == 0)
        {
            PlayerPrefs.SetInt("firstmoneycreate", 1);
            currentMoneyReward = Instantiate(moneyRewards[rewardSelect], currnetLevelRewPosList[0].transform.position, Quaternion.identity);
        }
        else
        {
            currentMoneyReward = Instantiate(moneyRewards[rewardSelect], currnetLevelRewPosList[rewPosRandomSelcet].transform.position, Quaternion.identity);
        }
        currentMoneyReward_TR = currentMoneyReward.transform;

        if (currentMoneyReward.GetComponent<MoneySkill>() != null)
        {
            //newReward.GetComponent<MoneySkill>().moneyValue = (Globals.collectableLevel * 300) + (Globals.openedCarSlotCount * 200) * (PlayerPrefs.GetInt("level") + 1);
            currentMoneyReward.GetComponent<MoneySkill>().moneyValue = (int)(CheckExpensiveCost() * expensiveCostFactor);
            currentMoneyReward.GetComponent<MoneySkill>().ValueInit();
        }
    }
    public void ResetRewardedPos()
    {
        if(currentSpeedReward_TR != null)
        {
            List<RewardPos> currnetLevelRewPosList = new List<RewardPos>();
            foreach (var spdRewpos in speedRewardPos)
            {
                if (spdRewpos.levelID == Globals.collectableLevel)
                {
                    currnetLevelRewPosList.Add(spdRewpos);
                }
            }

            int rewPosRandomSelcet = Random.Range(0, currnetLevelRewPosList.Count);
            currentSpeedReward_TR.position = currnetLevelRewPosList[rewPosRandomSelcet].transform.position;
        }

        if (currentCapacityReward_TR != null)
        {
            List<RewardPos> currnetLevelRewPosList = new List<RewardPos>();
            foreach (var cptyRewpos in capacityRewardPos)
            {
                if (cptyRewpos.levelID == Globals.collectableLevel)
                {
                    currnetLevelRewPosList.Add(cptyRewpos);
                }
            }

            int rewPosRandomSelcet = Random.Range(0, currnetLevelRewPosList.Count);
            currentCapacityReward_TR.position = currnetLevelRewPosList[rewPosRandomSelcet].transform.position;
        }

        if (currentDoubleIncomeReward_TR != null)
        {
            List<RewardPos> currnetLevelRewPosList = new List<RewardPos>();
            foreach (var dblIncRewpos in doubleIncomeRewardPos)
            {
                if (dblIncRewpos.levelID == Globals.collectableLevel)
                {
                    currnetLevelRewPosList.Add(dblIncRewpos);
                }
            }

            int rewPosRandomSelcet = Random.Range(0, currnetLevelRewPosList.Count);
            currentDoubleIncomeReward_TR.position = currnetLevelRewPosList[rewPosRandomSelcet].transform.position;
        }

        if (currentMoneyReward_TR != null)
        {
            List<RewardPos> currnetLevelRewPosList = new List<RewardPos>();
            foreach (var mnyRewpos in moneyRewardPos)
            {
                if (mnyRewpos.levelID == Globals.collectableLevel)
                {
                    currnetLevelRewPosList.Add(mnyRewpos);
                }
            }

            int rewPosRandomSelcet = Random.Range(0, currnetLevelRewPosList.Count);
            currentMoneyReward_TR.position = currnetLevelRewPosList[rewPosRandomSelcet].transform.position;
        }
    }
    private int CheckExpensiveCost()
    {
        int expensiveCost = 0;
        if(buyAreaList.Count > 0)
        {
            for(int i = 0; i < buyAreaList.Count;i++)
            {
                if(expensiveCost < buyAreaList[i].buyCost)
                {
                    expensiveCost = buyAreaList[i].buyCost;
                }
            }
        }
        else
        {

            expensiveCost = (Globals.collectableLevel * 300) + (Globals.openedCarSlotCount * 200) * (PlayerPrefs.GetInt("level") + 1);
        }
        return expensiveCost;
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
        RepairManager.Instance.repairWorker.showBuyRapairReward.RepairImmediate(false);
        RepairManager.Instance.repairWorker.showBuyRapairReward.Canvas.SetActive(false);
    }
}
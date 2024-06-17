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
    public int hoverboardRewardTime;
    TextMeshProUGUI hoverboardCounterText;


    public int extraStack = 5;
    public int capacityRewardTime;
    TextMeshProUGUI capacityCounterText;

    public int doubleIncomeRewardTime;
    TextMeshProUGUI doubleIncomeCounterText;

    public List<RewardPos> rewardPos = new List<RewardPos>();
    [SerializeField] GameObject[] rewards;

    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        Globals.playTime = PlayerPrefs.GetInt("playtime");
        Globals.skillCooldown = PlayerPrefs.GetInt("skillCooldown");
        StartCoroutine(PlayTimeCounter());

        firstColor = Color.white;

        hoverboardCounterText = RewardPanel.Instance.hoverboardCounterText;

        capacityCounterText = RewardPanel.Instance.capacityCounterText;
        doubleIncomeCounterText = RewardPanel.Instance.doubleIncomeCounterText;
    }
    public void HoverboardActive()
    {
        RewardPanel.Instance.hoverboardPanelGO.SetActive(true);
        StartCoroutine(Hoverboard_Reset(hoverboardRewardTime));
        PlayerController.Instance.HoverBoardActive();


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

    IEnumerator Hoverboard_Reset(int rewardTime)
    {
        int counter = rewardTime;
        while (counter > 0)
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
        hoverboardCounterText.text = "00:00";
        PlayerController.Instance.NoneVehicle();
        RewardPanel.Instance.hoverboardPanelGO.SetActive(false);
        Globals.isSkillCreated = false;

    }


    public void CapacityActive()
    {
        PlayerController.Instance.CapacityUp();
        RewardPanel.Instance.capacityPanelGO.SetActive(true);
        StartCoroutine(Capacity_Reset(capacityRewardTime));
        Globals.extraStack = extraStack;


    }

    IEnumerator Capacity_Reset(int rewardTime)
    {
        int counter = rewardTime;

        while (counter > 0)
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

        capacityCounterText.text = "00:00";
        RewardPanel.Instance.capacityPanelGO.SetActive(false);
        Globals.extraStack = 0;
        PlayerController.Instance.CapacityReset();
        Globals.isSkillCreated = false;

    }

    public void DoubleIncomeActive()
    {
        RewardPanel.Instance.doubleIncomePanelGO.SetActive(true);
        StartCoroutine(DoubleIncome_Reset(doubleIncomeRewardTime));
        Globals.doubleIncomeActive = true;

    }

    IEnumerator DoubleIncome_Reset(int rewardTime)
    {
        int counter = rewardTime;

        while (counter > 0)
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

        doubleIncomeCounterText.text = "00:00";
        RewardPanel.Instance.doubleIncomePanelGO.SetActive(false);
        Globals.doubleIncomeActive = false;
        Globals.isSkillCreated = false;


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

    IEnumerator PlayTimeCounter()
    {
        while (true)
        {
            Globals.playTime++;
            PlayerPrefs.SetInt("playtime", Globals.playTime);

            if (PlayerPrefs.GetInt("skillActive") == 1)
            {
                Globals.skillCooldown++;
                PlayerPrefs.SetInt("skillCooldown", Globals.skillCooldown);
            }

            if (Globals.skillCooldown >= 60 && !Globals.isSkillCreated)
            {
                //Globals.skillCooldown = 0;
                //PlayerPrefs.SetInt("skillCooldown", Globals.skillCooldown);

                SkillCreate();
            }
            yield return new WaitForSeconds(1);
        }
    }



    public void SkillCreate()
    {
        Globals.isSkillCreated = true;
        Globals.skillCooldown = 0;
        PlayerPrefs.SetInt("skillCooldown", Globals.skillCooldown);
        List<RewardPos> rewPosList = new List<RewardPos>();
        foreach (var pos in rewardPos)
        {
            if (PlayerPrefs.GetInt("shopindex") >= pos.levelID)
            {
                rewPosList.Add(pos);
            }
        }

        int rewPosRandomSelcet = Random.Range(0, rewPosList.Count);



        int rewardSelect = PlayerPrefs.GetInt("skill") % rewards.Length;
        GameObject newReward = Instantiate(rewards[rewardSelect], rewPosList[rewPosRandomSelcet].transform.position, Quaternion.identity);
        //newReward.transform.localScale = Vector3.one * rewardSize;
        //newReward.transform.position += new Vector3(Random.Range(-5f, 5f), 0, Random.Range(0f, 10f));

        PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 1);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardManager : MonoBehaviour
{
    private static RewardManager _instance = null;
    public static RewardManager Instance => _instance;
    [SerializeField] GameObject[] rewards;
    public HoleUpgradeSettings _holeUpgradeSettings;
    [SerializeField] float rewardSize;
    public List<RewardPos> rewardPos = new List<RewardPos>();
    public List<RewardPos> gemPos = new List<RewardPos>();


    public GameObject gemEnv;
    public int gemCreatePeriod;
    public GameObject currentReward;
    private void Awake()
    {
        _instance = this;
    }
    void Start()
    {
        //_holeUpgradeSettings = LevelManager.Instance._holeUpgradeSettings;
        //RewardActiveCheck();
    }
    public void RewardActiveCheck()
    {
        if (currentReward != null)
        {
            Destroy(currentReward);
        }

        if ((PlayerPrefs.GetInt("tryingcount")) >= 4 && (PlayerPrefs.GetInt("tryingcount") + 1) % _holeUpgradeSettings._rewardPeriod == 0)
        {
            RewardCreate();
        }

        if ((PlayerPrefs.GetInt("tryingcount")) >= 3 && (PlayerPrefs.GetInt("tryingcount") + 1) % gemCreatePeriod == 0)
        {
            GemCreate();
        }

    }
    void RewardCreate()
    {

        List<RewardPos> rewPosList = new List<RewardPos>();
        foreach (var pos in rewardPos)
        {
            if (PlayerPrefs.GetInt("envlevel") >= pos.levelID)
            {
                rewPosList.Add(pos);
            }
        }

        int rewPosRandomSelcet = Random.Range(0, rewPosList.Count);



        int rewardSelect = PlayerPrefs.GetInt("reward") % rewards.Length;
        GameObject newReward = Instantiate(rewards[rewardSelect], rewPosList[rewPosRandomSelcet].transform.position, Quaternion.identity);
        newReward.transform.localScale = Vector3.one * rewardSize;
        //newReward.transform.position += new Vector3(Random.Range(-5f, 5f), 0, Random.Range(0f, 10f));
        currentReward = newReward;
        PlayerPrefs.SetInt("reward", PlayerPrefs.GetInt("reward") + 1);
    }

    void GemCreate()
    {

        List<RewardPos> rewPosList = new List<RewardPos>();
        foreach (var pos in gemPos)
        {
            if (PlayerPrefs.GetInt("envlevel") >= pos.levelID)
            {
                rewPosList.Add(pos);
            }
        }

        int rewPosRandomSelcet = Random.Range(0, rewPosList.Count);



        GameObject newGem = Instantiate(gemEnv, rewPosList[rewPosRandomSelcet].transform.position, Quaternion.identity);
    }
}

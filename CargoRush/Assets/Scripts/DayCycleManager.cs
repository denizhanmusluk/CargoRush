using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycleManager : MonoBehaviour
{
    private static DayCycleManager _instance = null;
    public static DayCycleManager Instance => _instance;
    // Start is called before the first frame update
    [SerializeField] int firstInterstialTime = 900;
    [SerializeField] int firstInterstialTimeCounter = 0;

    [SerializeField] int dayCyclePeriod = 180;
    public int dayCycleCount = 0;
    private void Awake()
    {
        _instance = this;
    }
    void Start()
    {
        if (PlayerPrefs.GetInt("firstInterstialTimeCompleted") == 0)
        {
            StartCoroutine(FirstQuarterCounter());
        }
        else
        {
            StartCoroutine(DayCycleCounter());
        }
    }
    IEnumerator FirstQuarterCounter()
    {
        firstInterstialTimeCounter = PlayerPrefs.GetInt("firstInterstialTimeCounter");

        while (firstInterstialTimeCounter < firstInterstialTime)
        {
            firstInterstialTimeCounter++;
            PlayerPrefs.SetInt("firstInterstialTimeCounter", firstInterstialTimeCounter);
            yield return new WaitForSeconds(1);
        }
        PlayerPrefs.SetInt("firstInterstialTimeCompleted", 1);
        StartCoroutine(AdvShow());
    }
    IEnumerator DayCycleCounter()
    {
        dayCycleCount = PlayerPrefs.GetInt("dayCycleCount");

        while (dayCycleCount < dayCyclePeriod)
        {
            dayCycleCount++;
            PlayerPrefs.SetInt("dayCycleCount", dayCycleCount);
            yield return new WaitForSeconds(1);
        }
        StartCoroutine(AdvShow());
    }

    IEnumerator AdvShow()
    {
        TutorialManager.Instance.lunch_Break.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Fade.Instance.Hide();
        yield return new WaitForSeconds(0.5f);
        ADVManager.Instance.InterstialStart(AdvCompleted, "interstial");
    }
    void AdvCompleted()
    {
        dayCycleCount = 0;
        PlayerPrefs.SetInt("dayCycleCount", dayCycleCount);
        StartCoroutine(DayCycleCounter());
        Fade.Instance.Show();
    }
}

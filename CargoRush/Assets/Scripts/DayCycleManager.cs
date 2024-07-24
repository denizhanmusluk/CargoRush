using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayCycleManager : MonoBehaviour
{
    private static DayCycleManager _instance = null;
    public static DayCycleManager Instance => _instance;
    // Start is called before the first frame update
    [SerializeField] int firstInterstialTime = 900;
    [SerializeField] int firstInterstialTimeCounter = 0;

    [SerializeField] int dayCyclePeriod = 180;
    public int dayCycleCount = 0;
    public GameObject dayPanel_GO;
    public GameObject sun;
    public GameObject moon;
    public Image dayFill;

    private void Awake()
    {
        _instance = this;
    }
    void Start()
    {
        if (PlayerPrefs.GetInt("isbannerdisable") == 0)
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

        if (PlayerPrefs.GetInt("isbannerdisable") == 0)
        {
            StartCoroutine(AdvShow());
        }
        else
        {
            DayCycleRestart();
        }
    }
    IEnumerator DayCycleCounter()
    {
        dayPanel_GO.SetActive(true);
        dayCycleCount = PlayerPrefs.GetInt("dayCycleCount");

        while (dayCycleCount < dayCyclePeriod)
        {
            dayCycleCount++;
            PlayerPrefs.SetInt("dayCycleCount", dayCycleCount);
            dayFill.fillAmount = (float)dayCycleCount / (float)dayCyclePeriod;
            if (dayCycleCount < dayCyclePeriod / 2)
            {
                sun.gameObject.SetActive(true);
                moon.gameObject.SetActive(false);
            }
            else
            {
                sun.gameObject.SetActive(false);
                moon.gameObject.SetActive(true);
            }
            yield return new WaitForSeconds(1);
        }
        if (PlayerPrefs.GetInt("isbannerdisable") == 0)
        {
            StartCoroutine(AdvShow());
        }
        else
        {
            DayCycleRestart();
        }
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
    void DayCycleRestart()
    {
        dayCycleCount = 0;
        PlayerPrefs.SetInt("dayCycleCount", dayCycleCount);
        StartCoroutine(DayCycleCounter());
    }
}

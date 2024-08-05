using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HisseCompany : MonoBehaviour
{
    public List<float> shareValues = new List<float>();
    public List<float> timeStamps = new List<float>();

    public bool myCompany = false;
    [SerializeField] TextMeshProUGUI shareText;
    [SerializeField] TextMeshProUGUI companyNameText;

    public string companyName;
    [SerializeField] int firstValue;
    [SerializeField] float increaseAmount;
    [SerializeField] int incPeriod;
    [SerializeField] Vector2 increaseBeetwen;




    public int currentCompanyShare;


    [SerializeField] int timeLevel = 0;

    [SerializeField] int timeCounter = 0;
    [SerializeField] float currentShareCounter = 0;
    void Start()
    {
        timeCounter = PlayerPrefs.GetInt(companyName + "timeCounter" );
        timeLevel = PlayerPrefs.GetInt(companyName + "timeLevel" );


        timeStamps.Add(0);
        shareValues.Add(0);
        for (int i = 0; i < timeLevel + 1; i++)
        {
            timeStamps.Add(incPeriod * (i + 1) / 10);
        }


        for (int i = 0; i < timeLevel + 1; i++)
        {
            shareValues.Add((firstValue + increaseAmount * i) / 100);
        }

        companyNameText.text = companyName;
        if (myCompany)
        {
            Globals.myShareValue = PlayerPrefs.GetInt("myShareValue");
            StartCoroutine(CheckMyShare());
        }

    
        
        
        if (!myCompany)
        {
            StartCoroutine(ShareChangeStart());
            StartCoroutine(CheckMyTimer());
        }

    }
    IEnumerator ShareChangeStart()
    {
        float randomIncValue = Random.Range(increaseBeetwen.x, increaseBeetwen.y);
        timeCounter = PlayerPrefs.GetInt(companyName + "timeCounter");
        while (timeCounter < incPeriod * (timeLevel + 1))
        {
            timeCounter++;
            PlayerPrefs.SetInt(companyName + "timeCounter", timeCounter);

            currentShareCounter = Mathf.Lerp(increaseAmount * timeLevel, increaseAmount * (timeLevel + 1) + randomIncValue, ((float)(timeCounter - incPeriod * timeLevel )  / (float)(incPeriod * (timeLevel + 1) - (incPeriod * timeLevel) )  ));
            currentCompanyShare = (int)(currentShareCounter + Random.Range(-5f, 5f));
            currentCompanyShare += firstValue;
            TextInit(shareText , currentCompanyShare);
            shareValues[shareValues.Count - 1] = currentCompanyShare / 100;
            if (timeCounter >= incPeriod * (timeLevel + 1))
            {
                timeLevel++;
                PlayerPrefs.SetInt(companyName + "timeLevel", timeLevel);
                timeStamps.Add(incPeriod * timeLevel / 10);
                shareValues.Add(currentCompanyShare / 100);

            }

            yield return new WaitForSeconds(1f);
        }
    }

   void TextInit(TextMeshProUGUI txt , int value)
    {
        int value1 = currentCompanyShare / 100;
        int value2 = currentCompanyShare % 100;

        shareText.text = value1.ToString() + "." + value2.ToString() + "$";
        if (value2 < 10)
        {
            shareText.text = value1.ToString() + "." + "0" + value2.ToString() + "$";
        }

    }
    IEnumerator CheckMyTimer()
    {
        timeCounter = PlayerPrefs.GetInt(companyName + "timeCounter");
        while (timeCounter < incPeriod * (timeLevel + 1))
        {
            timeCounter++;
            PlayerPrefs.SetInt(companyName + "timeCounter", timeCounter);

            if (timeCounter >= incPeriod * (timeLevel + 1))
            {
                timeLevel++;
                PlayerPrefs.SetInt(companyName + "timeLevel", timeLevel);
                timeStamps.Add(incPeriod * timeLevel / 10);
                shareValues.Add(currentCompanyShare / 100);
            }

            yield return new WaitForSeconds(1f);
        }
    }
    IEnumerator CheckMyShare()
    {

        while (true)
        {
            currentCompanyShare = Globals.myShareValue;
            TextInit(shareText, currentCompanyShare);
            shareValues[shareValues.Count - 1] = currentCompanyShare / 100;

            if(currentCompanyShare > ShareManager.Instance.risingPerValue * (PlayerPrefs.GetInt("sharevaluelevel") + 1))
            {
                ShareManager.Instance.ShareValueReward(PlayerPrefs.GetInt("sharevaluelevel"));
                PlayerPrefs.SetInt("sharevaluelevel", PlayerPrefs.GetInt("sharevaluelevel") + 1);
            }
            yield return new WaitForSeconds(1f);
        }
    }


    public void PosSet(Transform targetPos, int companyLevel)
    {
        StartCoroutine(PosTranslate(targetPos));
        if (myCompany)
        {
            //Debug.Log("MY COMPANY LEVEL" + companyLevel);

            if (PlayerPrefs.GetInt("mycompanylevel") < companyLevel)
            {
                PlayerPrefs.SetInt("mycompanylevel", companyLevel);
                ShareManager.Instance.Share_LevelUp_TutorialStart(companyLevel);

            }
        }
    }

    IEnumerator PosTranslate(Transform targetPos)
    {
        Vector3 firstPos = transform.position;
        float counter = 0;
        while(counter < 1)
        {
            counter += 2 * Time.deltaTime;
            transform.position = Vector3.Lerp(firstPos, targetPos.position, counter);

            yield return null;
        }
        transform.position = targetPos.position;

    }
}

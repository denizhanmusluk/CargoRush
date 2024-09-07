using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BuyAreaADV : MonoBehaviour
{
    [SerializeField] string buyName;
    [SerializeField] string rewardedName;

    public string standShowName;

    public TextMeshProUGUI standShowText;
    [SerializeField] GameObject buildPrefab;
    [SerializeField] GameObject[] buyAreas;


    [SerializeField] Image imageFill;
    bool upgradeOpenActive = false;
    public bool ticketTutorialActivator = false;

    public void Start()
    {
        standShowText.text = standShowName;
        if (PlayerPrefs.GetInt(buyName + PlayerPrefs.GetInt("level")) == 1)
        {
            InstantiateBuild();
            StartCoroutine(CloseDelay());
            GetComponent<Collider>().enabled = false;
        }
    }
    void FirstOpenArea()
    {
        InstantiateBuild();
        StartCoroutine(CloseDelay());
        GetComponent<Collider>().enabled = false;
        PlayerPrefs.SetInt(buyName + PlayerPrefs.GetInt("level"), 1);
    
    }
    void InstantiateBuild()
    {
        buildPrefab.SetActive(true);
        StartCoroutine(OpenBuyAreas());
    }
    IEnumerator OpenBuyAreas()
    {
        for (int i = 0; i < buyAreas.Length; i++)
        {
            buyAreas[i].SetActive(true);

            yield return null;
        }
    }

    IEnumerator CloseDelay()
    {
        yield return new WaitForSeconds(0.5f);
        int buildChildCount = transform.childCount;
        for (int i = 0; i < buildChildCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
        if (ticketTutorialActivator)
        {
            yield return new WaitForSeconds(10);
            TutorialManager.Instance.SkinTutorialStart();

            //if (PlayerPrefs.GetInt("tickettutorial") == 0)
            //{
            //    TutorialManager.Instance.SkinTutorialStart();
            //    PlayerPrefs.SetInt("tickettutorial", 1);
            //}
        }
    }

    public void BuyAdv_CLick()
    {
        ADVManager.Instance.RewardedStart(AdvCompleteBuy, rewardedName, true);
    }
    void AdvCompleteBuy()
    {
        FirstOpenArea();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
 
            upgradeOpenActive = true;
            StartCoroutine(CooldownActive(2f));
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            GameManager.Instance.ui.joyStick.GetComponent<FloatingJoystick>().PointerUpManuel();
            GameManager.Instance.ui.joyStick.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            GameManager.Instance.ui.joyStick.SetActive(true);
            upgradeOpenActive = false;
        }
    }

    IEnumerator CooldownActive(float time)
    {
        float counter = 0f;
        while (counter < time && upgradeOpenActive)
        {
            counter += Time.deltaTime;
            imageFill.fillAmount = counter / time;
            yield return null;
        }
        if (counter >= time)
        {
            upgradeOpenActive = false;
            BuyAdv_CLick();
            //StartCoroutine(CooldownPasive());
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
}

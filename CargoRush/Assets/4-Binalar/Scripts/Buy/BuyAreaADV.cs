using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuyAreaADV : MonoBehaviour
{
    [SerializeField] string buyName;
    [SerializeField] string rewardedName;

    public string standShowName;

    public TextMeshProUGUI standShowText;
    [SerializeField] GameObject buildPrefab;
    [SerializeField] GameObject[] buyAreas;

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
    }

    public void BuyAdv_CLick()
    {
        ADVManager.Instance.RewardedStart(AdvCompleteBuy, rewardedName);
    }
    void AdvCompleteBuy()
    {
        FirstOpenArea();
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
        }
    }
}

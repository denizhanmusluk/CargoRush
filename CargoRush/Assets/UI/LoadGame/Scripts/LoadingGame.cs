using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class LoadingGame : MonoBehaviour
{
    [SerializeField] List<Image> images = new List<Image>();
    [SerializeField] Image loadBar;
    [SerializeField] float loadTime = 5f;

    [SerializeField] string[] textList;
    [SerializeField] TextMeshProUGUI loadingText;
    [SerializeField] GameObject joystickTutorialGO;
    //[SerializeField] GameObject tutorialPanelGO;
    void Start()
    {
        //if (PlayerPrefs.GetInt("gameopened") > 0)
        //{
        //    StartCoroutine(StartDelay());
        //    joystickTutorialGO.SetActive(false);
        //    //tutorialPanelGO.SetActive(false);
        //}
        //else
        //{


        //}
        if (Globals.loadingPanelActive)
        {
            loadBar.fillAmount = 0f;
            StartCoroutine(LoadinBar());
            StartCoroutine(LoadingText());
        }
        else
        {
            gameObject.SetActive(false);
            //MapManager.Instance.OpenMap();
            PlatformSwitchManager.Instance.SwitchToBottom();
        }
    }
    ////IEnumerator StartDelay()
    ////{
    ////    yield return new WaitForSeconds(0.2f);
    ////    PlatformSwitchManager.Instance.SwitchToBottom();
    ////}
    IEnumerator LoadinBar()
    {
        float counter = 0f;
        while (counter < loadTime)
        {
            counter += Time.deltaTime;
            loadBar.fillAmount = counter / loadTime;
            yield return null;
        }
        loadingText.enabled = false;
        Globals.loadingPanelActive = false;
        GameStart();
        StartCoroutine(PanelClose());
    }
    public void Tutorial_PanelClose()
    {
        //StartCoroutine(TutorialPanelClose());
    }
    //IEnumerator TutorialPanelClose()
    //{
    //    float counter = 0;
    //    float SimulationSpeed = 1f;
    //    while (counter < 1f)
    //    {
    //        counter += SimulationSpeed * Time.deltaTime;

    //        foreach (var img in tutorialPanelGO.GetComponentsInChildren<Image>())
    //        {
    //            img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.Abs(1 - counter));
    //        }
    //        foreach (var img in tutorialPanelGO.GetComponentsInChildren<TextMeshProUGUI>())
    //        {
    //            img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.Abs(1 - counter));
    //        }
    //        yield return null;
    //    }
    //    tutorialPanelGO.SetActive(false);

    //}
    IEnumerator PanelClose()
    {
        float counter = 0;
        float SimulationSpeed = 1f;
        while (counter < 1f)
        {
            counter += SimulationSpeed * Time.deltaTime;

            foreach (var img in images)
            {
                img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.Abs(1 - counter));
            }
            yield return null;
        }
        gameObject.SetActive(false);
    }
    IEnumerator LoadingText()
    {
        for (int i = 0; i < 10; i++)
        {
            loadingText.text = textList[i % textList.Length];
            yield return new WaitForSeconds(0.5f);
        }
        //loadingText.text = textList[Random.Range(0, textList.Length)].ToString();
        //yield return new WaitForSeconds(loadTime / 2f);
        //loadingText.text = textList[Random.Range(0, textList.Length)].ToString();
    }
    void GameStart()
    {
        //if (PlayerPrefs.GetInt("firstopengame") > 0)
        //{
        //    PlatformSwitchManager.Instance.SwitchToUp();
        //}
        //else
        //{
        //    PlatformSwitchManager.Instance.SwitchToBottom();
        //}
        PlayerPrefs.SetInt("firstopengame", 1);

        PlatformSwitchManager.Instance.SwitchToBottom();

        //if (PlayerPrefs.GetInt("gameopened") == 0)
        //{
        //    PlayerPrefs.SetInt("gameopened", 1);
        //    //tutorialPanelGO.SetActive(true);
        //    PlatformSwitchManager.Instance.SwitchToUp();
        //}
        //else
        //{
        //    PlatformSwitchManager.Instance.SwitchToBottom();
        //}
    }
}

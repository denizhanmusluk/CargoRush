using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    private static SettingsManager _instance = null;
    public static SettingsManager Instance => _instance;
    public Animator panelAnimator;
    public GameObject settingsButtonGO;
    public GameObject settingsPanelGO;

    public GameObject vibButtonOpener;
    public GameObject vibButtonCloser;

    public GameObject soundButtonOpener;
    public GameObject soundButtonCloser;

    public GameObject musicButtonOpener;
    public GameObject musicButtonCloser;
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        if(PlayerPrefs.GetInt("vibrationclose") == 0)
        {
            VibrationOpener_Click();
        }
        else
        {
            VibrationCloser_Click();
        }

        if (PlayerPrefs.GetInt("soundclose") == 0)
        {
            SoundOpener_Click();
        }
        else
        {
            SoundCloser_Click();
        }

        if (PlayerPrefs.GetInt("musicclose") == 0)
        {
            MusicOpener_Click();
        }
        else
        {
            MusicCloser_Click();
        }
    }
    public void SettingsOpen_Click()
    {
        OpenPanel();
    }
    public void SettingsClose_Click()
    {
        ClosePanel();
    }
    void OpenPanel()
    {
        settingsPanelGO.SetActive(true);
        settingsButtonGO.SetActive(false);
    }
    void ClosePanel()
    {
        StartCoroutine(CloseDelay());
    }
    IEnumerator CloseDelay()
    {
        panelAnimator.SetTrigger("close");
        yield return new WaitForSeconds(1f);
        settingsPanelGO.SetActive(false);
        settingsButtonGO.SetActive(true);
    }


    public void VibrationOpener_Click()
    {
        PlayerPrefs.SetInt("vibrationclose", 0);
        vibButtonOpener.SetActive(false);
        vibButtonCloser.SetActive(true);
    }
    public void VibrationCloser_Click()
    {
        PlayerPrefs.SetInt("vibrationclose", 1);
        vibButtonOpener.SetActive(true);
        vibButtonCloser.SetActive(false);
    }


    public void SoundOpener_Click()
    {
        PlayerPrefs.SetInt("soundclose", 0);
        soundButtonOpener.SetActive(false);
        soundButtonCloser.SetActive(true);
    }
    public void SoundCloser_Click()
    {
        PlayerPrefs.SetInt("soundclose", 1);
        soundButtonOpener.SetActive(true);
        soundButtonCloser.SetActive(false);
    }



    public void MusicOpener_Click()
    {
        PlayerPrefs.SetInt("musicclose", 0);
        musicButtonOpener.SetActive(false);
        musicButtonCloser.SetActive(true);
    }
    public void MusicCloser_Click()
    {
        PlayerPrefs.SetInt("musicclose", 1);
        musicButtonOpener.SetActive(true);
        musicButtonCloser.SetActive(false);
    }
}

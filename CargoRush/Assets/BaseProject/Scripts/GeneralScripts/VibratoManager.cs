using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TapticPlugin;
using Taptic;

public class VibratoManager : MonoBehaviour
{
    private static VibratoManager _instance = null;
    public static VibratoManager Instance => _instance;
    //public static VibratoManager Instance;
    bool lightVibratoActive = true;
    bool mediumVibratoActive = true;
    bool heavyVibratoActive = true;
    [SerializeField] float frequency;
    void Awake()
    {
        _instance = this;
    }
    // Update is called once per frame
    public void LightVibration()
    {
        if (lightVibratoActive && PlayerPrefs.GetInt("vibrationclose") == 0)
        {
            Vibration.Vibrate(70, 85, true);
            //TapticManager.Impact(ImpactFeedback.Light);
            StartCoroutine(LightVibratoActivator());
        }
    }
    public void MediumVibration()
    {
        if (mediumVibratoActive && PlayerPrefs.GetInt("vibrationclose") == 0)
        {
            Vibration.Vibrate(70, 170, true);
            //TapticManager.Impact(ImpactFeedback.Medium);
            StartCoroutine(MediumVibratoActivator());
        }
    }
    public void HeavyVibration()
    {
        if (heavyVibratoActive && PlayerPrefs.GetInt("vibrationclose") == 0)
        {
            Vibration.Vibrate(70, 255, true);
            //TapticManager.Impact(ImpactFeedback.Heavy);
            StartCoroutine(HeavyVibratoActivator());
        }
    }
    public void MediumMultiVibration()
    {
            StartCoroutine(MediumMultiVibrationActive());
    }
    IEnumerator MediumMultiVibrationActive()
    {
        int counter = 0;
        while(counter < 3)
        {
            Vibration.Vibrate(70, 170, true);
            counter++;
            yield return new WaitForSeconds(0.33f);
        }
    }
    IEnumerator LightVibratoActivator()
    {
        if (lightVibratoActive)
        {
            lightVibratoActive = false;
            yield return new WaitForSeconds(frequency);
            lightVibratoActive = true;
        }
    }
    IEnumerator MediumVibratoActivator()
    {
        if (mediumVibratoActive)
        {
            mediumVibratoActive = false;
            yield return new WaitForSeconds(frequency);
            mediumVibratoActive = true;
        }
    }
    IEnumerator HeavyVibratoActivator()
    {
        if (heavyVibratoActive)
        {
            heavyVibratoActive = false;
            yield return new WaitForSeconds(frequency);
            heavyVibratoActive = true;
        }
    }
}
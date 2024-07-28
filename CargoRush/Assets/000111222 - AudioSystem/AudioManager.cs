using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance = null;
    public static AudioManager Instance => _instance;
    [SerializeField] float frequency;

    public AudioSource stackTake_AS;
    public AudioSource stackDrop_AS;
    public AudioSource button_AS;
    public AudioSource upgrade_AS;
    public AudioSource payment_AS;
    public AudioSource moneyCollect_AS;
    public AudioSource openNewArea_AS;
    public AudioSource music_AS;

    bool stackTakeSoundActive = true;
    bool stackDropSoundActive = true;
    bool buttonSoundActive = true;
    bool upgradeSoundActive = true;
    bool paymentSoundActive = true;
    bool moneyCollectSoundActive = true;
    bool openNewAreaSoundActive = true;
    private void Awake()
    {
        _instance = this;
    }
 
    public void StackTakeSound()
    {
        if (stackTakeSoundActive && PlayerPrefs.GetInt("soundclose") == 0)
        {
            stackTake_AS.Play();
            StartCoroutine(StackTakeSoundActivator());
        }
    }
    public void StackDropSound()
    {
        if (stackDropSoundActive && PlayerPrefs.GetInt("soundclose") == 0)
        {
            stackDrop_AS.Play();
            StartCoroutine(StackDropSoundActivator());
        }
    }
    public void ButtonSound()
    {
        if (buttonSoundActive && PlayerPrefs.GetInt("soundclose") == 0)
        {
            button_AS.Play();
            StartCoroutine(ButtonSoundActivator());
        }
    }
    public void UpgradeSound()
    {
        if (upgradeSoundActive && PlayerPrefs.GetInt("soundclose") == 0)
        {
            upgrade_AS.Play();
            StartCoroutine(UpgradeSoundActivator());
        }
    }
    public void PaymentSound()
    {
        if (paymentSoundActive && PlayerPrefs.GetInt("soundclose") == 0)
        {
            payment_AS.Play();
            StartCoroutine(PaymentSoundActivator());
        }
    }
    public void MoneyCollectSound()
    {
        if (moneyCollectSoundActive && PlayerPrefs.GetInt("soundclose") == 0)
        {
            moneyCollect_AS.Play();
            StartCoroutine(MoneyCollectSoundActivator());
        }
    }
    public void OpenNewAreaSound()
    {
        if (openNewAreaSoundActive && PlayerPrefs.GetInt("soundclose") == 0)
        {
            openNewArea_AS.Play();
            StartCoroutine(OpenNewAreaSoundActivator());
        }
    }
    IEnumerator StackTakeSoundActivator()
    {
        if (stackTakeSoundActive)
        {
            stackTakeSoundActive = false;
            yield return new WaitForSeconds(frequency);
            stackTakeSoundActive = true;
        }
    }

  
    IEnumerator StackDropSoundActivator()
    {
        if (stackDropSoundActive)
        {
            stackDropSoundActive = false;
            yield return new WaitForSeconds(frequency);
            stackDropSoundActive = true;
        }
    }

  
    IEnumerator ButtonSoundActivator()
    {
        if (buttonSoundActive)
        {
            buttonSoundActive = false;
            yield return new WaitForSeconds(frequency);
            buttonSoundActive = true;
        }
    }


    IEnumerator UpgradeSoundActivator()
    {
        if (upgradeSoundActive)
        {
            upgradeSoundActive = false;
            yield return new WaitForSeconds(frequency);
            upgradeSoundActive = true;
        }
    }


    IEnumerator PaymentSoundActivator()
    {
        if (paymentSoundActive)
        {
            paymentSoundActive = false;
            yield return new WaitForSeconds(frequency);
            paymentSoundActive = true;
        }
    }


    IEnumerator MoneyCollectSoundActivator()
    {
        if (moneyCollectSoundActive)
        {
            moneyCollectSoundActive = false;
            yield return new WaitForSeconds(frequency);
            moneyCollectSoundActive = true;
        }
    }


    IEnumerator OpenNewAreaSoundActivator()
    {
        if (openNewAreaSoundActive)
        {
            openNewAreaSoundActive = false;
            yield return new WaitForSeconds(frequency);
            openNewAreaSoundActive = true;
        }
    }
    public void MusicOn()
    {
        music_AS.Play();
    }
    public void MusicOff()
    {
        music_AS.Stop();
    }
}

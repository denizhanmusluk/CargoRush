using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class TransUpPlatform : MonoBehaviour, BuyCamera
{
    [SerializeField] ParticleSystem blinkUpPaticle;
    [SerializeField] Transform characterTargetPosTR;
    [SerializeField] GameObject characterUpgradePanel;
    [SerializeField] Slider _slider;
    public bool transActive = false;
    public bool transOpened = false;
    public bool switchActive = true;

    bool triggerActive = true;
    public FishDropArea _FishDropArea;

    public CinemachineVirtualCamera thisBuyViewCamera;
    public CinemachineVirtualCamera buyCamera
    {
        get { return thisBuyViewCamera; }
        set { thisBuyViewCamera = value; }
    }
    void Start()
    {
        IndicatorManager.Instance._TransUpPlatform = this;
        //PlatformSwitchManager.Instance._TransUpPlatform = this;
        _slider.value = 0;
        //IndicatorManager.Instance.controlCenterTR = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && !transActive && switchActive && triggerActive)
        {
            transActive = true;
            switchActive = false;
            //StartCoroutine(Delay_TransUpPlatform(2f));
            StartCoroutine(CooldownActive(2f));
            blinkUpPaticle.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && triggerActive)
        {
            transActive = false;
            transOpened = false;
            switchActive = true;
        }
    }

    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.GetComponent<PlayerController>() != null && switchActive)
    //    {
    //        if (other.GetComponent<PlayerController>().pressJoystick == false && transActive)
    //        {
    //            StartCoroutine(Delay_TransUpPlatform(0.1f));
    //        }
    //    }
    //}
    IEnumerator CooldownActive(float time)
    {
        float counter = 0f;
        while(counter < time && transActive)
        {
            counter += Time.deltaTime;
            _slider.value = counter / time;
            yield return null;
        }
        if(counter >= time)
        {
            transActive = false;
            //StartCoroutine(TransUpPlatformOpen());
            StartCoroutine(CooldownPasive());
            blinkUpPaticle.Stop();
        }
        else
        {
            StartCoroutine(CooldownPasive());
            blinkUpPaticle.Stop();
        }
    }
    IEnumerator CooldownPasive()
    {
        float lastValue = _slider.value;
        float counter = 0f;
        while(counter < 1f)
        {
            counter += 4 * Time.deltaTime;
            _slider.value = Mathf.Lerp(lastValue, 0, counter);

            yield return null;
        }
    }
    IEnumerator Delay_TransUpPlatform(float time)
    {
        yield return new WaitForSeconds(time);
        if (transActive)
        {
            transActive = false;
            //TransUpPlatformOpen();
        }
    }
    //IEnumerator TransUpPlatformOpen()
    //{
    //    if (!transOpened)
    //    {
    //        triggerActive = false;
    //        transOpened = true;

    //        PlayerController.Instance.JumpToHoleCenter(transform);
    //        yield return new WaitForSeconds(2f);

    //        PlayerController.Instance.PlayerControlDeActive();
    //        //PlatformSwitchManager.Instance.SwitchToUp();
    //        IndicatorManager.Instance.IndicaorDeActive();





    //        StartCoroutine(SetCollider());
    //    }
    //}
    IEnumerator SetCollider()
    {
        GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(2f);
        GetComponent<Collider>().enabled = true;
        triggerActive = true;
    }
    //public void CharacterUpgradeClose()
    //{
    //    if (transOpened)
    //    {
    //        Debug.Log("Panel Close");
    //        transOpened = false;
    //        PlayerController.Instance.GameStart();
    //    }

    //}
}

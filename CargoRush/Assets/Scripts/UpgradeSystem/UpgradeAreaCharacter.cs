using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class UpgradeAreaCharacter : MonoBehaviour,BuyCamera
{
    [SerializeField] GameObject characterUpgradePanel;
    [SerializeField] Slider _slider;
    bool upgradeOpenActive = false;
    bool opened = false;
    [SerializeField] List< Animator> animators;
    public ParticleSystem sleepyParticle;

    public CinemachineVirtualCamera thisBuyViewCamera;
    public CinemachineVirtualCamera buyCamera
    {
        get { return thisBuyViewCamera; }
        set { thisBuyViewCamera = value; }
    }
    void Start()
    {
        characterUpgradePanel = CharacterUpgradeManager.Instance.characterUpgradePanel;
        CharacterUpgradeManager.Instance._upgradeAreaCharacter = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            sleepyParticle.Stop();
            upgradeOpenActive = true;
            StartCoroutine(CooldownActive(0.7f));
            foreach(var anim in animators)
            {
                anim.SetBool("getR", true);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            sleepyParticle.Play();
            upgradeOpenActive = false;
            foreach (var anim in animators)
            {
                anim.SetBool("getR", false);
            }
        }
    }

    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.GetComponent<PlayerController>() != null)
    //    {
    //        if (other.GetComponent<PlayerController>().pressJoystick == false && upgradeOpenActive)
    //        {
    //            StartCoroutine(Delay_CharacterUpgradeOpen(0.1f));
    //        }
    //    }
    //}
    IEnumerator CooldownActive(float time)
    {
        float counter = 0f;
        while (counter < time && upgradeOpenActive)
        {
            counter += Time.deltaTime;
            _slider.value = counter / time;
            yield return null;
        }
        if (counter >= time)
        {
            upgradeOpenActive = false;
            CharacterUpgradeOpen();
            StartCoroutine(CooldownPasive());
        }
        else
        {
            StartCoroutine(CooldownPasive());
        }
    }
    IEnumerator CooldownPasive()
    {
        float lastValue = _slider.value;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 4 * Time.deltaTime;
            _slider.value = Mathf.Lerp(lastValue, 0, counter);

            yield return null;
        }
    }
    IEnumerator Delay_CharacterUpgradeOpen(float time)
    {
        yield return new WaitForSeconds(time);
        if (upgradeOpenActive)
        {
            CharacterUpgradeOpen();
        }
    }
    private void CharacterUpgradeOpen()
    {
        if (!opened)
        {
            opened = true;
            characterUpgradePanel.SetActive(true);
            PlayerController.Instance.PlayerControlDeActive();
        }
    }

    public void CharacterUpgradeClose()
    {
        if (opened)
        {
            opened = false;
            upgradeOpenActive = false;
            PlayerController.Instance.PlayerControl_ReActive();
        }

    }
}

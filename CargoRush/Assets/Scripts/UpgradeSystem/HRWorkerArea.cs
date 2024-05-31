using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class HRWorkerArea : MonoBehaviour, BuyCamera
{
    [SerializeField] GameObject workerUpgradePanel;
    [SerializeField] Slider _slider;
    bool upgradeOpenActive = false;
    bool opened = false;
    [SerializeField] List<Animator> animators;
    public List<GameObject> workerList;
    //public List<BuyArea> workerBuyAreaList;
    public Transform firstCreateTR;
    public ParticleSystem sleepyParticle;
    public GameObject HRWorkerGO;
    public GameObject circleWhite;
    public GameObject circleGreen;
    public GameObject upDownAnimationGO;
    public CinemachineVirtualCamera thisBuyViewCamera;
    public CinemachineVirtualCamera buyCamera
    {
        get { return thisBuyViewCamera; }
        set { thisBuyViewCamera = value; }
    }
    void Start()
    {
        workerUpgradePanel = HRUpgradeManager.Instance.workerUpgradePanel;
        HRUpgradeManager.Instance._upgradeAreaWorkers = this;
        HRUpgradeManager.Instance.firstCreateTR = firstCreateTR;
        HRUpgradeManager.Instance.WorkerCreate();
        HRUpgradeManager.Instance.HRWorkerGO = HRWorkerGO;
        StartCoroutine(StartDelay());
       
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(1f);
        if (PlayerPrefs.GetInt("hropen") == 0)
        {
            IndicatorManager.Instance.IndicaorActive(circleWhite.transform);
            GameManager.Instance.ui.hrUpgradeTextGO.SetActive(true);
            upDownAnimationGO.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            if (sleepyParticle != null)
            {
                sleepyParticle.Stop();
            }
            upgradeOpenActive = true;
            StartCoroutine(CooldownActive(0.7f));
            foreach (var anim in animators)
            {
                anim.SetBool("getR", true);
            }
            circleWhite.SetActive(false);
            circleGreen.SetActive(true);
            if (PlayerPrefs.GetInt("hropen") == 0)
            {
                PlayerPrefs.SetInt("hropen", 1);
                IndicatorManager.Instance.IndicaorDeActive();
                GameManager.Instance.ui.hrUpgradeTextGO.SetActive(false);
                upDownAnimationGO.SetActive(false);

            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            if (sleepyParticle != null)
            {
                sleepyParticle.Play();
            }
            upgradeOpenActive = false;
            foreach (var anim in animators)
            {
                anim.SetBool("getR", false);
            }
            circleWhite.SetActive(true);
            circleGreen.SetActive(false);
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
            workerUpgradePanel.SetActive(true);
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

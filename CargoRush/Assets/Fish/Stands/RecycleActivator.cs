using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecycleActivator : MonoBehaviour
{
    [SerializeField] Image imageFill;
    bool upgradeOpenActive = false;
    public StandFishTezgah standFishTezgah;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {

            upgradeOpenActive = true;
            StartCoroutine(CooldownActive(1f));
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            if (!upgradeOpenActive)
            {
                StartCoroutine(CooldownPasive());
            }
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
            RecycleActive();
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
        RecyclePassive();
    }
    void RecycleActive()
    {
        standFishTezgah.StandReActive();
    }
    void RecyclePassive()
    {
        standFishTezgah.StandActive = false;
    }
}

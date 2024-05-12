using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CountdownToAd : MonoBehaviour
{
    [SerializeField] int time;
    Slider slider;
    TextMeshProUGUI counterText;
    void Awake()
    {
        Initial();
        CounterStart();
    }
    private void Initial()
    {
        foreach (Slider _slider in GetComponentsInChildren<Slider>())
        {
            slider = _slider;
        }
        foreach (TextMeshProUGUI _text in GetComponentsInChildren<TextMeshProUGUI>())
        {
            counterText = _text;
        }
    }
    public void CounterStart()
    {
        StartCoroutine(DigitalCounter());
        StartCoroutine(FloatingCounter());
    }
    private void OnDisable()
    {
        StopAllCoroutines();
    }
    IEnumerator DigitalCounter()
    {
        int counter = time;
        while (counter > 0)
        {
            counterText.text =($"{counter}");
            counter--;
            yield return new WaitForSeconds(1);
        }
        counterText.text = ($"{0}");
        yield return new WaitForSeconds(0.1f);
        SelfActive(false);
    }

    IEnumerator FloatingCounter()
    {
        float counter = 0;
        while (counter < time)
        {
            counter += Time.deltaTime;
            slider.value = (1 - counter / (float)time);
            yield return null;
        }
    }
    private void SelfActive(bool active)
    {
        this.gameObject.SetActive(active);
    }
}

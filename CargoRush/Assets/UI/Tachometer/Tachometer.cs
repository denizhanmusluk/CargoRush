using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class Tachometer : MonoBehaviour
{
    private static Tachometer _instance = null;
    public static Tachometer Instance => _instance;
    [SerializeField] Image[] gearBG;
    public GameObject tachoMeterPanel;
    public Transform needle;
    [SerializeField] public float minAngle, perfectShiftAngle, goodShiftAngle, maxAngle, lastAngle;
    public TextMeshProUGUI speedText, gearText;


    public GameObject counterGO;
    public TextMeshProUGUI counterText;
    [SerializeField] int counter;
    public TextMeshProUGUI speedPlayerTextTemp;
    public TextMeshProUGUI speedAITextTemp;

    [SerializeField] GameObject perfectText, goodText, badText;
    bool gearShiftPressed = false;

    [SerializeField] Color whiteColor, greenColor, greenTrns, yellowColor, redColor, redTrns;
    [SerializeField] GameObject lightPanelGO;
    [SerializeField] GameObject[] light;
    void Awake()
    {
        _instance = this;
    }
    public void Counter()
    {
        counterGO.SetActive(true);
        StartCoroutine(CounterSet());
    }
    IEnumerator CounterSet()
    {
        lightPanelGO.SetActive(true);
        for (int i = 0; i < counter; i++)
        {
            ScaleEffectTR(counterText.transform, 0.5f, 1f, 1f, Ease.OutElastic);
            counterText.text = (counter - i).ToString();
            light[i].SetActive(true);
            yield return new WaitForSeconds(1f);
        }

        CarManager.Instance.StartGo();
        counterText.text = "GO";
        yield return new WaitForSeconds(1f);
        counterGO.SetActive(false);
        lightPanelGO.SetActive(false);

    }

    public Tween ScaleEffectTR(Transform prt, float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                prt.localScale = Vector3.one * value;
            }).OnComplete(delegate ()
            {

            });
        return tween;
    }

    public void OpenGearShiftCanvas()
    {
        GameManager.Instance.ui.gearShiftTapGO.SetActive(true);
    }
    public void ShiftText(float currentAngle)
    {
        gearShiftPressed = true;
        if (currentAngle > perfectShiftAngle && currentAngle < goodShiftAngle)
        {
            StartCoroutine(OpenText(perfectText));
        }
        else if (currentAngle < maxAngle)
        {
            StartCoroutine(OpenText(goodText));
        }
        else
        {
            StartCoroutine(OpenText(badText));
        }
        StartCoroutine(DefaultColorAnimation());
    }
    IEnumerator OpenText(GameObject txtGO)
    {
        txtGO.SetActive(true);
        TextMeshProUGUI txt = txtGO.GetComponent<TextMeshProUGUI>();
        float counter = 0;
        float firstVal = 0f;
        float lastVal = 1f;
        float alphaValue = 0f;
        while (counter < 1f)
        {
            counter += 5 * Time.deltaTime;
            alphaValue = Mathf.Lerp(firstVal, lastVal, counter);
            //float currentAlpha = (counter / (Mathf.PI / 2));
            txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, alphaValue);
            yield return null;
        }
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(CloseText(txtGO));
    }
    IEnumerator CloseText(GameObject txtGO)
    {
        TextMeshProUGUI txt = txtGO.GetComponent<TextMeshProUGUI>();
        float counter = 0;
        float firstVal = 1f;
        float lastVal = 0f;
        float alphaValue = 0f;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            alphaValue = Mathf.Lerp(firstVal, lastVal, counter);
            //float currentAlpha = (counter / (Mathf.PI / 2));
            txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, alphaValue);
            yield return null;
        }
        txtGO.SetActive(false);
    }
    public void GreenBGAnimationStart()
    {
        StartCoroutine(GreenColorAnimation());
    }
    IEnumerator GreenColorAnimation()
    {
        //Color whiteColor = Color.white;
        //Color greenColor = Color.green;
        float counter = 0f;
        while (counter < 1f && !gearShiftPressed)
        {
            counter += 4 * Time.deltaTime;
            foreach (var gears in gearBG)
            {
                gears.color = Color.Lerp(whiteColor, greenColor, counter);
            }
            yield return null;
        }
        // // //
        while (needle.eulerAngles.z < goodShiftAngle && !gearShiftPressed)
        {
            yield return null;
        }
        // // //

        counter = 0f;
        float angle = 0f;
        while (needle.eulerAngles.z < maxAngle && !gearShiftPressed)
        {
            counter += 4 * Time.deltaTime;
            angle = Mathf.Abs(Mathf.Sin(counter));
            foreach(var gears in gearBG)
            {
                gears.color = Color.Lerp(greenColor, greenTrns, angle);
            }
            yield return null;
        }


        Color firstColor = gearBG[0].color;
        counter = 0f;
        while (counter < 1f && !gearShiftPressed)
        {
            counter += 6 * Time.deltaTime;
            foreach (var gears in gearBG)
            {
                gears.color = Color.Lerp(firstColor, greenColor, counter);
            }
            yield return null;
        }



        counter = 0f;
        while (counter < 1f && !gearShiftPressed)
        {
            counter += 2 * Time.deltaTime;
            foreach (var gears in gearBG)
            {
                gears.color = Color.Lerp(greenColor, yellowColor, counter);
            }
            yield return null;
        }

        counter = 0f;
        while (counter < 1f && !gearShiftPressed)
        {
            counter += 2 * Time.deltaTime;
            foreach (var gears in gearBG)
            {
                gears.color = Color.Lerp(yellowColor, redColor, counter);
            }
            yield return null;
        }


        counter = 0f;
        while (needle.eulerAngles.z < lastAngle && !gearShiftPressed)
        {
            counter += 4 * Time.deltaTime;
            angle = Mathf.Abs(Mathf.Sin(counter));
            foreach (var gears in gearBG)
            {
                gears.color = Color.Lerp(redColor, redTrns, angle);
            }
            yield return null;
        }
    }
    IEnumerator DefaultColorAnimation()
    {
        //Color whiteColor = Color.white;
        Color firstColor = gearBG[0].color;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            foreach (var gears in gearBG)
            {
                gears.color = Color.Lerp(firstColor, whiteColor, counter);
            }
            yield return null;
        }
        gearShiftPressed = false;
    }
    public void GearBGClose()
    {
        foreach (var gears in gearBG)
        {
            gears.gameObject.SetActive(false);
        }
    }
}
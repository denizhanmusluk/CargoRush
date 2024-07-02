using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopupAnimation : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(OpenAnim());
    }

    IEnumerator OpenAnim()
    {

        float counter = 0;
        float SimulationSpeed = 1f;
        while (counter < 1f)
        {
            counter += SimulationSpeed * Time.deltaTime;

            foreach (var img in gameObject.GetComponentsInChildren<Image>())
            {
                img.color = Color.Lerp(img.color, new Color(img.color.r, img.color.g, img.color.b, 1), counter);
                //img.color = new Color(img.color.r, img.color.g, img.color.b,  counter);
            }
            foreach (var txt in gameObject.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.color = Color.Lerp(txt.color, new Color(txt.color.r, txt.color.g, txt.color.b, 1), counter);
                //txt.color = new Color(txt.color.r, txt.color.g, txt.color.b,  counter);
            }
            yield return null;
        }
        foreach (var img in gameObject.GetComponentsInChildren<Image>())
        {
            img.color = new Color(img.color.r, img.color.g, img.color.b, 1);
        }
        foreach (var txt in gameObject.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, 1);
        }


        yield return new WaitForSeconds(4f);

        counter = 0;

        while (counter < 1f)
        {
            counter += SimulationSpeed * Time.deltaTime;

            foreach (var img in gameObject.GetComponentsInChildren<Image>())
            {
                img.color = Color.Lerp(img.color, new Color(img.color.r, img.color.g, img.color.b, 0), counter);
            }
            foreach (var txt in gameObject.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.color = Color.Lerp(txt.color, new Color(txt.color.r, txt.color.g, txt.color.b, 0), counter);
                //txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, 1f - counter);
            }
            yield return null;
        }
        foreach (var img in gameObject.GetComponentsInChildren<Image>())
        {
            img.color = new Color(img.color.r, img.color.g, img.color.b, 0);
        }
        foreach (var txt in gameObject.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, 0);
        }

        gameObject.SetActive(false);
    }
}

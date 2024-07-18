using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorAnimation : MonoBehaviour
{
    public Color firstColor, lastColor;
    public TextMeshProUGUI txt;
    public Image img;
    public float simulateSpeed = 1f;
    float counter = 0f;
    float value = 0f;
    void Update()
    {
        counter += simulateSpeed * Time.deltaTime;
        value = Mathf.Abs(Mathf.Sin(Mathf.PI * 0.5f * counter));
        if (txt != null)
        {
            txt.color = Color.Lerp(firstColor, lastColor, value);
        }
        if (img != null)
        {
            img.color = Color.Lerp(firstColor, lastColor, value);
        }
    }
}

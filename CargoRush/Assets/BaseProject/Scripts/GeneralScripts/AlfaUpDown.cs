using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AlfaUpDown : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] Color firstColor, lastColor;
    [SerializeField] float duringTime;
    [SerializeField] float speed;
    private void OnEnable()
    {
        StartCoroutine(AlphaUpDown());
    }
    IEnumerator AlphaUpDown()
    {
        float counter = 0f;
        float angle = 0f;
        while(counter < duringTime * speed)
        {
            counter += speed * Time.deltaTime;
            angle = 1f - Mathf.Abs( Mathf.Cos(counter));
            text.color = Color.Lerp(firstColor, lastColor, angle);
            yield return null;
        }
    }
}

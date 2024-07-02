using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextAnimation : MonoBehaviour
{
    [SerializeField] string dialog;
    public TextMeshProUGUI targetText;
    public float delay = 0.1f; // Her bir harfin yazýlma aralýðý

    public string fullText;
    private string currentText = "";

    void Start()
    {
        // Hedef metni al
        //fullText = targetText.text;
        targetText.text = ""; // Metni temizle
    }
    private void OnEnable()
    {
        Text_Write(dialog);
    }
    private void OnDisable()
    {
        ResetText();
    }
    private void ResetText()
    {
        fullText = "";
        currentText = "";
    }
    public void Text_Write(string txt)
    {
        ResetText();
        fullText = txt;
        StartCoroutine(TextWrite());
    }
    IEnumerator TextWrite()
    {
        int counter = 0;
        while (counter < fullText.Length)
        {
            counter++;

            currentText += fullText[currentText.Length];
            targetText.text = currentText;

            yield return new WaitForSeconds(delay);
        }
    }
}

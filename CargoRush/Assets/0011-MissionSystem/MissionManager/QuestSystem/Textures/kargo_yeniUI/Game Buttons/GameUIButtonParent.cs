using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUIButtonParent : MonoBehaviour
{
    public int scaleFactor = 230;
    public float widthValue = 200f;
    public Image buttonBG_Image;
    public int openButtonCount = 0;
    public void SetBGSize()
    {
        buttonBG_Image.rectTransform.sizeDelta = new Vector2(widthValue, openButtonCount * scaleFactor);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BoxSellingInfo : MonoBehaviour
{
    public string productName;
    public int sellingBoxCount;
    public TextMeshProUGUI boxCountText;
    public float openDelayTime = 0f;
    public List<Sprite> spriteList = new List<Sprite>();
    public Image boxImg;
    private void OnEnable()
    {
        if (boxImg != null)
        {
            boxImg.sprite = spriteList[PlayerPrefs.GetInt("level")];
        }
    }
    public void TextSet()
    {
        StartCoroutine(TextLerp());
    }

    IEnumerator TextLerp()
    {
        yield return new WaitForSeconds(openDelayTime);
        float sellingCounter = 0;
        float counter = 0f;
        while(counter < 1f)
        {
            counter += Time.deltaTime;
            sellingCounter = Mathf.Lerp(0, sellingBoxCount, counter);
            boxCountText.text = productName + " x" + ((int)sellingCounter).ToString();
            yield return null;
        }
        boxCountText.text = productName + " x" + sellingBoxCount.ToString();

    }

    public void TextSet2()
    {
        StartCoroutine(TextLerp2());
    }
    IEnumerator TextLerp2()
    {
        yield return new WaitForSeconds(openDelayTime);
        float sellingCounter = 0;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += Time.deltaTime;
            sellingCounter = Mathf.Lerp(0, sellingBoxCount, counter);
            boxCountText.text = ((int)sellingCounter).ToString();
            yield return null;
        }
        boxCountText.text = sellingBoxCount.ToString();

    }

}

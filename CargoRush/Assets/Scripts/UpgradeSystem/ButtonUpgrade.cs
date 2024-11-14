using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonUpgrade : MonoBehaviour
{
    public Button _button;
    Vector3 defaultLocalPos;
    Vector3 targetUpPos;
    private void Awake()
    {
        defaultLocalPos = transform.localPosition;
        targetUpPos = transform.localPosition + Vector3.up * 50;
        if (!_button.interactable)
        {
            transform.localPosition = targetUpPos;
        }
    }
    public void MoveButtonUp()
    {
        _button.interactable = false;
        StartCoroutine(MoveButton(targetUpPos));
    }
    public void MoveButtonDefaultPos()
    {
        _button.interactable = true;
        StartCoroutine(MoveButton(defaultLocalPos));
    }
    IEnumerator MoveButton(Vector3 _targetPos)
    {
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 4 * Time.deltaTime;

            transform.localPosition = Vector3.Lerp(transform.localPosition, _targetPos, Time.deltaTime * 15);
            yield return null;
        }
    }
    //IEnumerator MoveUp()
    //{
    //    float counter = 0f;
    //    while(counter < 1f)
    //    {
    //        counter += 4 * Time.deltaTime;

    //        transform.localPosition = Vector3.Lerp(defaultLocalPos, targetPos, counter);
    //        yield return null;
    //    }
    //}
    //IEnumerator MoveDef()
    //{
    //    float counter = 0f;
    //    while (counter < 1f)
    //    {
    //        counter += 2 * Time.deltaTime;

    //        transform.localPosition = Vector3.Lerp(targetPos, defaultLocalPos, counter);
    //        yield return null;
    //    }
    //}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollDetect : MonoBehaviour
{
    [SerializeField]
    private Vector2 thresholds = new Vector2(0.1f,0.9f);
    private ScrollRect _rect;
    [SerializeField] private GameObject[] leftScroll,rightScroll;
    void Start()
    {
        _rect = GetComponent<ScrollRect>();
        _rect.onValueChanged.AddListener(OnValueChange);
        Activator(_rect.horizontalNormalizedPosition);
    }
    private void Activator(float value)
    {
        foreach (var l in leftScroll)
            l.SetActive(!(value <= thresholds.x));
        foreach (var r in rightScroll)
            r.SetActive(!(value >= thresholds.y));
    }
    private void OnValueChange(Vector2 value)
    {
        Activator(value.y);
        // Debug.Log(value.x);
    }
}

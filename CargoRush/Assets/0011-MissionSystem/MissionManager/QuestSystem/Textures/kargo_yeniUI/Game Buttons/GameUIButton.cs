using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIButton : MonoBehaviour
{
    [SerializeField] GameUIButtonParent gameUIButtonParent;

    private void OnEnable()
    {
        gameUIButtonParent.openButtonCount++;
        gameUIButtonParent.SetBGSize();
    }
    private void OnDisable()
    {
        gameUIButtonParent.openButtonCount--;
        gameUIButtonParent.SetBGSize();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CollectProgressManager : MonoBehaviour
{
    private static CollectProgressManager _instance = null;
    public static CollectProgressManager Instance => _instance;




    public GameObject shopProgresGO;
    public Image shopProgresFill;
    public Image shopProgresFillBG;
    public Image shopFirstIcon, shopTargetIcon;
    public GameObject questMarkImgGO;


    public Image errorFill;
    public GameObject dirtyProgressPanelGo;
    public GameObject dirtyProgressPanelBGGo;
    public GameObject dirtyActiveImgGO;
    private void Awake()
    {
        _instance = this;
    }
}

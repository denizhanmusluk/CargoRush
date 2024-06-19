using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTutorialPanel : MonoBehaviour
{
    private static BossTutorialPanel _instance = null;
    public static BossTutorialPanel Instance => _instance;
    public NewLevelBoss newLevelBoss;
    public GameObject tap1ImgGO;
    public GameObject tap2ImgGO;

    private void Awake()
    {
        _instance = this;
    }
    void Start()
    {
        
    }

    public void Tap1Screen()
    {
        tap1ImgGO.SetActive(false);
        tap2ImgGO.SetActive(true);
        newLevelBoss.PopUp2_Open();
    }
    public void Tap2Screen()
    {
        tap2ImgGO.SetActive(false);
        newLevelBoss.BossFinish();
    }
}

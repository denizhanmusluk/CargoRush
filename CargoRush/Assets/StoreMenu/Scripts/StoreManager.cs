using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    public static StoreManager Instance;
    public GameObject storePanel, storeButton;
    [SerializeField] GameObject newPanel, popularPanel, starPanel, exclusivePanel;
    //[SerializeField] GameObject LevelTXTPanel;
    [SerializeField] List<RectTransform> Buttons;
    public GameObject closeAndNextLevel;
    public GameObject storeButtonGlimmerGO;
    public GameObject storeButtonTapTutorialGO;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    void Start()
    {
        //LevelTXTPanel.SetActive(true);
        newPanel.SetActive(false);
        popularPanel.SetActive(false);
        starPanel.SetActive(false);
        exclusivePanel.SetActive(false);
        if (PlayerPrefs.GetInt("skinactive") == 1)
        {
            storeButton.SetActive(true);
            //GameManager.Instance.ui.gemPanel.SetActive(true);
        }
    }

    public void StoreButton()
    {
        //LevelTXTPanel.SetActive(false);

        storePanel.SetActive(true);
        StarButton();
        storeButton.SetActive(false);
        NewPanelManager.Instance.NewPanelActive();
        StarPanelManager.Instance.StarPAnelActive();
        //PopularPanelManager.Instance.popularPAnelActive();
        //MissionManager.Instance.SkinMissionStart();
        storeButtonTapTutorialGO.SetActive(false);
        PlayerController.Instance.PlayerControlDeActive();
        AudioManager.Instance.ButtonSound();
    }

    public void newButton()
    {
        newPanel.SetActive(true);
        popularPanel.SetActive(false);
        starPanel.SetActive(false);
        exclusivePanel.SetActive(false);
        buttonSetPos(Buttons[0]);
    }

    public void popularButton()
    {
        newPanel.SetActive(false);
        popularPanel.SetActive(true);
        starPanel.SetActive(false);
        exclusivePanel.SetActive(false);
        buttonSetPos(Buttons[1]);

    }

    public void StarButton()
    {
        newPanel.SetActive(false);
        popularPanel.SetActive(false);
        starPanel.SetActive(true);
        exclusivePanel.SetActive(false);
        buttonSetPos(Buttons[2]);

    }

    public void exclusiveButton()
    {
        newPanel.SetActive(false);
        popularPanel.SetActive(false);
        starPanel.SetActive(false);
        exclusivePanel.SetActive(true);
        buttonSetPos(Buttons[3]);

    }
    public void closeButton()
    {
        //LevelTXTPanel.SetActive(true);
        storePanel.SetActive(false);
        newPanel.SetActive(false);
        popularPanel.SetActive(false);
        starPanel.SetActive(false);
        exclusivePanel.SetActive(false);
        storeButton.SetActive(true);
        PlayerController.Instance.PlayerControl_ReActive();

    }

    public void buttonSetPos(RectTransform btn)
    {
        float firstPosY = 9.5f;
        float lastPos = 30f;
        float firstX = btn.anchoredPosition.x;
        for (int i = 0; i< Buttons.Count; i++)
        {
            //Buttons[i].transform.position = new Vector3(Buttons[i].transform.position.x, firstPosY, Buttons[i].transform.position.z);
        }
   
        LeanTween.value(firstPosY, lastPos, 0.2f).setOnUpdate((float val) =>
        {
            btn.anchoredPosition = new Vector3(firstX,((float)val));
        });
    }
}

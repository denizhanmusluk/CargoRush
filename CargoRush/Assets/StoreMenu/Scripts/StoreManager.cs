using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    public static StoreManager Instance;
    public GameObject storePanel, storeButton;
    [SerializeField] GameObject   starPanel;
    //[SerializeField] GameObject LevelTXTPanel;
    [SerializeField] List<RectTransform> Buttons;
    public GameObject closeAndNextLevel;
    public GameObject storeButtonGlimmerGO;
    public GameObject storeButtonTapTutorialGO;
    public GameObject storeButtonTapTutorialGO2;

    public GameObject selectSkinTicketTut_Tap;
    public GameObject buySkinTicketTut_Tap;
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
        starPanel.SetActive(false);
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
        StarPanelManager.Instance.StarPAnelActive();
        //PopularPanelManager.Instance.popularPAnelActive();
        //MissionManager.Instance.SkinMissionStart();
        storeButtonTapTutorialGO.SetActive(false);
        PlayerController.Instance.PlayerControlDeActive();
        AudioManager.Instance.ButtonSound();
        if (PlayerPrefs.GetInt("tickettutorial") == 2)
        {
            PlayerPrefs.SetInt("tickettutorial", 3);
            selectSkinTicketTut_Tap.SetActive(true);
            buySkinTicketTut_Tap.SetActive(true);
        }
    }

    public void newButton()
    {
        starPanel.SetActive(false);
        buttonSetPos(Buttons[0]);
    }

    public void popularButton()
    {
        starPanel.SetActive(false);
        buttonSetPos(Buttons[1]);

    }

    public void StarButton()
    {
        starPanel.SetActive(true);
        buttonSetPos(Buttons[2]);

    }

    public void exclusiveButton()
    {
        starPanel.SetActive(false);
        buttonSetPos(Buttons[3]);

    }
    public void closeButton()
    {
        //LevelTXTPanel.SetActive(true);
        storePanel.SetActive(false);
        starPanel.SetActive(false);
        storeButton.SetActive(true);
        PlayerController.Instance.PlayerControl_ReActive();
        if (PlayerPrefs.GetInt("tickettutorial") == 3)
        {
            PurchaseManager.Instance.SpecialOffer_PopUp_Open();
            //PurchaseManager.Instance.ButtonOpen();
            PlayerPrefs.SetInt("tickettutorial", 4);
        }

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

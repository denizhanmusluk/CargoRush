using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using Global;

public class StarPanelManager : MonoBehaviour
{
    public static StarPanelManager Instance;
    [SerializeField] List<ModelButton> modelButtons;
    //[SerializeField] List<Button> starButtons;
    [SerializeField] List<BuyButtons> buyButtons;
    [SerializeField] ModelScriptable playerModels;

    public Image storeButtonImage;
    public List<Sprite> skinSpriteList = new List<Sprite>();
    public GameObject skinBuyTutorialGO;
    public Animator skillAnim;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    public void MoneyEnoughCheck()
    {
        for (int i = 0; i < buyButtons.Count; i++)
        {
            if (buyButtons[i]._moneyType == MoneyType.Money)
            {
                if (Globals.moneyAmount >= playerModels._starModelCost[i])
                {
                    buyButtons[i].button.interactable = true;
                    if (buyButtons[i].gameObject.activeInHierarchy && PlayerPrefs.GetInt("shopindex") >= modelButtons[i + 1].shopLevel)
                    {
                        StoreManager.Instance.storeButtonGlimmerGO.SetActive(true);
                    }
                }
                else
                {
                    buyButtons[i].button.interactable = false;
                }
            }
            else
            {
                if (Globals.gemAmount >= playerModels._starModelCost[i])
                {
                    buyButtons[i].button.interactable = true;
                    if (buyButtons[i].gameObject.activeInHierarchy && PlayerPrefs.GetInt("shopindex") >= modelButtons[i + 1].shopLevel)
                    {
                        StoreManager.Instance.storeButtonGlimmerGO.SetActive(true);
                    }
                }
                else
                {
                    buyButtons[i].button.interactable = false;
                }
            }
        }
    }
    public void Start()
    {
        for (int i = 0; i < modelButtons.Count; i++)
        {
            if (modelButtons[i].GetComponent<Button>().interactable)
            {
                modelButtons[i].selectedOutline.enabled = false;
            }
        }
        if (PlayerPrefs.GetInt("category") == 0)
        {
            modelButtons[PlayerPrefs.GetInt("starmodel")].selectedOutline.enabled = true;
            storeButtonImage.sprite = skinSpriteList[PlayerPrefs.GetInt("starmodel")];
        }
        BuyButtonsInit();
    }
    void BuyButtonsInit()
    {
        for(int i = 0; i < buyButtons.Count; i++)
        {
            buyButtons[i].CostTextInit(playerModels._starModelCost[i]);
        }
    }

    public void StarPAnelActive()
    {
        CheckButtons();
        //SkinLevelCheck();
        if(PlayerPrefs.GetInt("buyskinactive") == 0)
        {
            skinBuyTutorialGO.SetActive(true);
            PlayerPrefs.SetInt("buyskinactive", 1);
        }
    }
    
    void CheckButtons()
    {
        for (int i = 0; i < modelButtons.Count; i++)
        {
            if (modelButtons[i].GetComponent<Button>().interactable)
            {
                modelButtons[i].selectedOutline.enabled = false;
            }
        }
        if (PlayerPrefs.GetInt("category") == 0)
        {
            modelButtons[PlayerPrefs.GetInt("starmodel")].selectedOutline.enabled = true;
            storeButtonImage.sprite = skinSpriteList[PlayerPrefs.GetInt("starmodel")];
        }
        for (int i = 0; i < modelButtons.Count; i++)
        {
            modelButtons[i].OpenedCheck();
        }
        //for (int i = 0; i < buyButtons.Count; i++)
        //{

        //    if (PlayerPrefs.GetInt("adv" + i) == 1)
        //    {
        //        buyButtons[i].gameObject.SetActive(false);
        //        buyButtons[i].button.interactable = false;
        //        ButtonActivation(modelButtons[i + 1], true);

        //    }
        //    else
        //    {
        //        ButtonActivation(modelButtons[i + 1], false);

        //    }
        //}
        MoneyEnoughCheck();
    }
    void ButtonActivation(ModelButton button, bool active)
    {
        //button.OpenedCheck(active);
    }
    void SkinLevelCheck()
    {
        //for(int i = 0; i < modelButtons.Count; i++)
        //{
        //    modelButtons[i].BuyableCheck();
        //}
    }
    public void BuyClick(int buttonId , MoneyType mnyType)
    {
        skinBuyTutorialGO.SetActive(false);

        StoreManager.Instance.storeButtonGlimmerGO.SetActive(false);
        //MissionManager.Instance.SkinMissionStart();

        //if (MissionManager.Instance.skinMission.gameObject.activeInHierarchy)
        //{
        //    MissionManager.Instance.skinMission.MissionUpdate();
        //}
        buyButtons[buttonId].button.interactable = false;
        buyButtons[buttonId].button.interactable = true;
        PlayerPrefs.SetInt("adv" + buttonId.ToString(), PlayerPrefs.GetInt("adv" + buttonId.ToString()) + 1);
        CheckButtons();

        switch (mnyType)
        {
            case MoneyType.Money:
                {
                    GameManager.Instance.ui.MoneyUpdate(-playerModels._starModelCost[buttonId]);
                }
                break;
            case MoneyType.Gem:
                {
                    GameManager.Instance.ui.GemUpdate(-playerModels._starModelCost[buttonId]);
                }
                break;
        }

    }

    public GameObject extraSpeedGO;
    public GameObject extraStackGO;
    public GameObject extraMoneyGO;
    public GameObject machineSpeedGO;

    public TextMeshProUGUI extraSpeedText;
    public TextMeshProUGUI extraStackText;
    public TextMeshProUGUI extraMoneyText;
    public TextMeshProUGUI machineSpeedText;
    public void SelectClick(int buttonId)
    {
        PlayerPrefs.SetInt("starmodel", buttonId);
        PlayerPrefs.SetInt("category", 0);

        CreateModel();

        SelectCheckButton(modelButtons[buttonId]);

        storeButtonImage.sprite = skinSpriteList[PlayerPrefs.GetInt("starmodel")];
        skillAnim.SetTrigger("open");
        float speed = playerModels._newModels[PlayerPrefs.GetInt("starmodel")].GetComponent<Player>().extraSpeed;
        int stack = playerModels._newModels[PlayerPrefs.GetInt("starmodel")].GetComponent<Player>().extraStack;
        int extrMoney = playerModels._newModels[PlayerPrefs.GetInt("starmodel")].GetComponent<Player>().extraMoney;
        float machineSpeed = playerModels._newModels[PlayerPrefs.GetInt("starmodel")].GetComponent<Player>().machineSpeed;
        if (speed > 1)
        {
            extraSpeedGO.SetActive(true);
            extraSpeedText.text = "+%" + (5 * ((int)(100 * speed) - 100)).ToString() + " Move Speed";
        }
        else
        {
            extraSpeedGO.SetActive(false);
        }

        if (stack > 0)
        {
            extraStackGO.SetActive(true);
            extraStackText.text = "+" + stack.ToString() + " Extra Capacity";
        }
        else
        {
            extraStackGO.SetActive(false);
        }

        if (extrMoney > 0)
        {
            extraMoneyGO.SetActive(true);
            extraStackText.text = "+" + extrMoney.ToString() + " Income Per Production";
        }
        else
        {
            extraMoneyGO.SetActive(false);
        }
        if (machineSpeed > 1)
        {
            machineSpeedGO.SetActive(true);
            extraSpeedText.text = "+%" + ((int)(100 * machineSpeed) - 100).ToString() + " Production Speed";
        }
        else
        {
            machineSpeedGO.SetActive(false);
        }
    }

    void CreateModel()
    {
        ModelSelector.Instance.CreatePlayer();
    }

    void SelectCheckButton(ModelButton button)
    {
        for (int i = 0; i < modelButtons.Count; i++)
        {
            if (modelButtons[i].GetComponent<Button>().interactable)
            {
                modelButtons[i].selectedOutline.enabled = false;
            }
        }
        //if (PlayerPrefs.GetInt("category") == 0)
        {
            button.selectedOutline.enabled = true;
        }



        NewPanelManager.Instance.Start();
    }
}

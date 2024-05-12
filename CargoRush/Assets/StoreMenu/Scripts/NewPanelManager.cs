//using Global;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewPanelManager : MonoBehaviour
{
    public static NewPanelManager Instance;

    [SerializeField] RectTransform moneyTargetIcon;
    [SerializeField] Image moneyIconFirstPoint;

    [SerializeField] RectTransform randomButton, getfreeButton;
    [SerializeField] Button newButtonsDefault;
    [SerializeField] List<Button> newButtons;
    [SerializeField] List<GameObject> newButtonEffect;
    [SerializeField] Button unlockModelButton;
    bool RandomSelector = true;
    public GameObject tapTutorialGO;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            ModelOpener();
        }
    }
    public void Start()
    {
        for (int i = 0; i < newButtons.Count; i++)
        {
            if (newButtons[i].interactable)
            {
                newButtons[i].transform.parent.GetComponent<Image>().enabled = false;
            }
        }
        newButtonsDefault.transform.parent.GetComponent<Image>().enabled = false;

        if (PlayerPrefs.GetInt("category") == 2)
        {
            if (PlayerPrefs.GetInt("newmodel") == 0)
            {
                newButtonsDefault.transform.parent.GetComponent<Image>().enabled = true;
            }
            else
            {
                newButtons[PlayerPrefs.GetInt("newmodel") - 1].transform.parent.GetComponent<Image>().enabled = true;
            }
        }
    }
    void CheckButtons()
    {
        int moneyAmount = 0;
        moneyAmount = Globals.moneyAmount;
        int j = 0;
        for (int i = 0; i < newButtons.Count; i++)
        {
            if (PlayerPrefs.GetInt("newbutton" + i) == 1)
            {
                j++;
                ButtonActivation(newButtons[i], true);
            }
            else
            {
                ButtonActivation(newButtons[i], false);

            }
        }
        if (j == newButtons.Count - 1)
        {
            unlockModelButton.gameObject.SetActive(false);
        }
        if (moneyAmount < 3000)
        {
            unlockModelButton.interactable = false;
        }
        else
        {
            unlockModelButton.interactable = true;

        }
    }
    public void ModelClaimButton()
    {
        StartCoroutine(ModelOpenDelay());
    }
    IEnumerator ModelOpenDelay()
    {
        yield return new WaitForSeconds(1f);
        ModelOpener();
    }
    public void ModelOpener()
    {

        //Globals.years = PlayerPrefs.GetInt("years");

        int moneyAmount = 0;
        moneyAmount = Globals.moneyAmount;

        randomButton.GetComponent<Button>().interactable = false;
        //unlockModelButton.gameObject.SetActive(true);
        CheckButtons();

        if (PlayerPrefs.GetInt("newmodel") == 0)
        {
            SelectCheckButton(newButtonsDefault);
        }
        else
        {
            SelectCheckButton(newButtons[PlayerPrefs.GetInt("newmodel") - 1]);
        }


        int selectIndex = 0;
        int j = 0;
        for (int i = 0; i < newButtons.Count; i++)
        {
            if (!newButtons[i].interactable)
            {

                break;
            }
            else if (i == newButtons.Count - 2)
            {
                RandomSelector = false;
                unlockModelButton.gameObject.SetActive(false);

            }
        }

        //for (int i = 0; i < newButtons.Count; i++)
        //{
        //    if (!newButtons[i].interactable)
        //    {
        //        selectIndex = i;
        //        break;
        //    }
        //}
        //selectIndex = ProgressManager.Instance.pngIndex;
        ButtonActivation(newButtons[selectIndex], true);
        newButtonEffect[selectIndex].SetActive(true);
        //PlayerPrefs.SetInt("newbutton" + selectIndex, 1);
        if (selectIndex == 0)
        {
            tapTutorialGO.SetActive(true);
        }

    }
    public void RandomOpennewPanel()
    {
        int moneyAmount = 0;
        moneyAmount = Globals.moneyAmount;

        randomButton.GetComponent<Button>().interactable = false;
        unlockModelButton.gameObject.SetActive(true);
        CheckButtons();

        if (PlayerPrefs.GetInt("newmodel") == 0)
        {
            SelectCheckButton(newButtonsDefault);
        }
        else
        {
            SelectCheckButton(newButtons[PlayerPrefs.GetInt("newmodel") - 1]);
        }


        if (moneyAmount >= 3000)
        {
            GameManager.Instance.MoneyUpdate(-3000);
            int randomSelect = Random.Range(0, newButtons.Count);
            int j = 0;
            for (int i = 0; i < newButtons.Count; i++)
            {
                if (!newButtons[i].interactable)
                {

                    break;
                }
                else if (i == newButtons.Count - 2)
                {
                    RandomSelector = false;
                    unlockModelButton.gameObject.SetActive(false);

                }
            }
            while (newButtons[randomSelect].interactable && RandomSelector)
            {
                randomSelect = Random.Range(0, newButtons.Count);
            }
          
            ButtonActivation(newButtons[randomSelect], true);
            PlayerPrefs.SetInt("newbutton" + randomSelect, 1);

            if (moneyAmount < 3000)
            {
                unlockModelButton.interactable = false;
            }

            if (!RandomSelector)
            {
                unlockModelButton.gameObject.SetActive(false);

            }
        }
        RandomSelectorButtonCheck();
    }
    void RandomSelectorButtonCheck()
    {
        for (int i = 0; i < newButtons.Count; i++)
        {
            if (PlayerPrefs.GetInt("newbutton" + i) == 1)
            {
                if (i == newButtons.Count - 1)
                {
                    unlockModelButton.gameObject.SetActive(false);
                }
            }
            else
            {
                break;
            }
        }
    }
    void ButtonActivation(Button button, bool active)
    {
        button.interactable = active;
        button.transform.GetChild(0).gameObject.SetActive(!active);
        button.transform.GetChild(1).gameObject.SetActive(active);
    }
    public void NewPanelActive()
    {
        CheckButtons();
        RandomSelectorButtonCheck();
    }

    public void Button1()
    {
        PlayerPrefs.SetInt("newmodel", 0);
        PlayerPrefs.SetInt("category", 2);

        CreateModel();

        SelectCheckButton(newButtonsDefault);

    }
    public void Button2()
    {
        tapTutorialGO.SetActive(false);

        PlayerPrefs.SetInt("newmodel", 1);
        PlayerPrefs.SetInt("category", 2);

        CreateModel();

        SelectCheckButton(newButtons[0]);

    }
    public void Button3()
    {
        PlayerPrefs.SetInt("newmodel", 2);
        PlayerPrefs.SetInt("category", 2);

        CreateModel();

        SelectCheckButton(newButtons[1]);

    }
    public void Button4()
    {
        PlayerPrefs.SetInt("newmodel", 3);
        PlayerPrefs.SetInt("category", 2);

        CreateModel();

        SelectCheckButton(newButtons[2]);

    }
    public void Button5()
    {
        PlayerPrefs.SetInt("newmodel", 4);
        PlayerPrefs.SetInt("category", 2);

        CreateModel();

        SelectCheckButton(newButtons[3]);

    }
    public void Button6()
    {
        PlayerPrefs.SetInt("newmodel", 5);
        PlayerPrefs.SetInt("category", 2);

        CreateModel();

        SelectCheckButton(newButtons[4]);

    }
    void CreateModel()
    {
        ModelSelector.Instance.CreatePlayer();

        //PlayerBehaviour.Instance.playerController.CharacterUpgrade(Globals.knifeLevel);
    }
    void SelectCheckButton(Button button)
    {
        for (int i = 0; i < newButtons.Count; i++)
        {
            if (newButtons[i].interactable)
            {
                newButtons[i].transform.parent.GetComponent<Image>().enabled = false;
            }
        }
        newButtonsDefault.transform.parent.GetComponent<Image>().enabled = false;

        if (PlayerPrefs.GetInt("category") == 2)
        {
            button.transform.parent.GetComponent<Image>().enabled = true;
        }



        StarPanelManager.Instance.Start();
        //PopularPanelManager.Instance.Start();

    }

    IEnumerator _MoneyMoveCallingGetFree()
    {
        for (int i = 0; i < 70; i++)
        {
            StartCoroutine(MoneyMoveTarget());
            yield return new WaitForSeconds(0.01f);
        }
    }
    IEnumerator MoneyMoveTarget()
    {
        var moneyicon = Instantiate(moneyIconFirstPoint, moneyIconFirstPoint.transform.position, Quaternion.identity, getfreeButton.transform);
        while (Vector3.Distance(moneyicon.transform.position, moneyTargetIcon.position) > 10)
        {
            moneyicon.transform.position = Vector3.MoveTowards(moneyicon.transform.position, moneyTargetIcon.position, 5000 * Time.deltaTime);

            yield return null;

        }
        Destroy(moneyicon.gameObject);
    }
    public void FreeMoneyButton()
    {
        getfreeButton.GetComponent<Button>().interactable = false;
        //GameManager.Rewarded_Event += _freeMoneyButton;
        //GameManager.Instance.FreeMoneyButtonStarRewarded();

        _FreeMoneyButton(); // temp
    }
    public void _FreeMoneyButton()
    {
        //GameManager.Instance.MoneyUpdate(1000);
        StartCoroutine(_MoneyMoveCallingGetFree());
        getfreeButton.GetComponent<Button>().interactable = true;
    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;

public class ShareManager : MonoBehaviour
{
    private static ShareManager _instance = null;
    public static ShareManager Instance => _instance;
    public event Action popUpEvent;
    public event Action shareValueRewardPopUp;
    public event Action goToCeo;

    public List<HisseCompany> hisseCompanies = new List<HisseCompany>();
    public List<Transform> hisseCompanyPosList = new List<Transform>();

    public Animator graphAnim;
    public GameObject graphButton;
    public GameObject cancelButton;
    public GraphManager graphManager;
    public GameObject exclamation_GO;
    //public List<HisseCompany> hisseCompaniesSequence = new List<HisseCompany>();
    public GameObject sharerisingTut_GO;
    public GameObject shareFallingTut_GO;
    public GameObject checkShareTut_GO;

    public GameObject repairPopUp_GO;
    public GameObject moneyPopUp_GO;

    public GameObject capacityPopUp_GO;
    public GameObject doubleIncomePopUp_GO;
    public GameObject speedPopUp_GO;
    public TextMeshProUGUI moneyText;


    //public List<GameObject> rewardPool = new List<GameObject>();
    public int risingPerValue = 2500;
    private void Awake()
    {
        _instance = this;
    }
    public void ShareButtonOpen()
    {
        PlayerPrefs.SetInt("sharebuttonopen", 1);
        graphButton.SetActive(true);
    }
    private void Start()
    {
        StartCoroutine(CompaniesPosSet());

        if (PlayerPrefs.GetInt("sharebuttonopen") == 1)
        {
            ShareButtonOpen();
        }
    }
    IEnumerator CompaniesPosSet()
    {
        yield return new WaitForSeconds(5f);
        while (true)
        {

            List<HisseCompany> sortedList = hisseCompanies.OrderByDescending(x => (x.currentCompanyShare)).ToList();
            hisseCompanies = sortedList;
            for(int i = 0; i < hisseCompanies.Count;i++)
            {
                hisseCompanies[i].PosSet(hisseCompanyPosList[i] , (hisseCompanies.Count - 1) - i);
            }
            yield return new WaitForSeconds(1f);
        }

    }
    public void OpenGraph()
    {
        graphButton.SetActive(false);
        cancelButton.SetActive(true);
        graphAnim.SetBool("openactive", true);
        PlayerController.Instance.PlayerControlDeActive();
        graphManager.openedShareUI = true;
        ShareRisingTutorialStart_2();
        ShareFallingTutorialStart_2();
        CheckShareTutorialStart_2();
        AudioManager.Instance.ButtonSound();
    }
    public void CloseGraph()
    {
        graphButton.SetActive(true);
        cancelButton.SetActive(false);
        graphAnim.SetBool("openactive", false);
        PlayerController.Instance.PlayerControl_ReActive();
        graphManager.openedShareUI = false;
        ShareRisingTutorial_End();
        ShareFallingTutorial_End();
        CheckShareTutorial_End();
        //popUpEvent?.Invoke();
        //popUpEvent = null;
        goToCeo?.Invoke();
        goToCeo = null;

        shareValueRewardPopUp?.Invoke();
        shareValueRewardPopUp = null;
        exclamation_GO.SetActive(false);

    }

    public bool shareRisingActive = false;
    public bool shareFallingActive = false;
    public bool checkShareActive = false;
    public void ShareRisingTutorialStart()
    {
        exclamation_GO.SetActive(true);
        shareRisingActive = true;
    }
    void ShareRisingTutorialStart_2()
    {
        if (shareRisingActive)
        {
            exclamation_GO.SetActive(false);
            sharerisingTut_GO.SetActive(true);
        }
    }
    void ShareRisingTutorial_End()
    {
        shareRisingActive = false;
        sharerisingTut_GO.SetActive(false);
    }



    public void ShareFallingTutorialStart()
    {
        exclamation_GO.SetActive(true);
        shareFallingActive = true;
    }
    void ShareFallingTutorialStart_2()
    {
        if (shareFallingActive)
        {
            exclamation_GO.SetActive(false);
            shareFallingTut_GO.SetActive(true);
        }
    }
    void ShareFallingTutorial_End()
    {
        shareFallingActive = false;
        shareFallingTut_GO.SetActive(false);
    }
    int companyLevel = 0;
    public void Share_LevelUp_TutorialStart(int _companyLevel)
    {
        ShareButtonOpen();
        companyLevel = _companyLevel;
        checkShareTut_GO.SetActive(true);
        exclamation_GO.SetActive(true);
        checkShareActive = true;
        popUpEvent = null;
        if (_companyLevel == 1)
        {
            if (PlayerPrefs.GetInt("purchaserepairboost") == 0)
            {
                popUpEvent += RepairPopUp_Open;
            }
            else
            {
                popUpEvent += MoneyPopUp_Open;
            }
        }
        else if (_companyLevel == 2)
        {
            popUpEvent += MoneyPopUp_Open;
        }
        else
        {
            if (PlayerPrefs.GetInt("purchaserepairboost") == 0)
            {
                popUpEvent += RepairPopUp_Open;
            }
            else
            {
                popUpEvent += MoneyPopUp_Open;
            }
        }

        goToCeo = null;
        goToCeo += GoToCeoNear;
    }
    void GoToCeoNear()
    {
        ShareCeo.Instance.CeoActive();
    }
    public void ShareLevelUp_PopUp()
    {
        popUpEvent?.Invoke();
        popUpEvent = null;
    }
    void CheckShareTutorialStart_2()
    {
        if (checkShareActive)
        {
            exclamation_GO.SetActive(false);
        }
    }
    void CheckShareTutorial_End()
    {
        checkShareActive = false;
        checkShareTut_GO.SetActive(false);
    }

    int shareValueLevel = 0;
    public void ShareValueReward(int _shareValueLevel)
    {
        exclamation_GO.SetActive(true);
        shareValueLevel = _shareValueLevel;
        if (shareValueLevel % 5 == 0)
        {
            if (Globals.extraStack == 0)
            {
                shareValueRewardPopUp += CapacityPopUpOpen;
            }
            else
            {
                shareValueRewardPopUp += MoneyPopUp_Open;
            }
        }
        if (shareValueLevel % 5 == 1)
        {
            shareValueRewardPopUp += MoneyPopUp_Open;
        }
        if (shareValueLevel % 5 == 2)
        {
            if (PlayerPrefs.GetInt("purchasedoubleincomeboost") == 0)
            {
                shareValueRewardPopUp += DoubleIncomePopUpOpen;
            }
            else
            {
                shareValueRewardPopUp += MoneyPopUp_Open;
            }
        }
        if (shareValueLevel % 5 == 3)
        {
            shareValueRewardPopUp += MoneyPopUp_Open;
        }
        if (shareValueLevel % 5 == 4)
        {
            if (PlayerPrefs.GetInt("purchasespeedboost") == 0)
            {
                shareValueRewardPopUp += SpeedPopUpOpen;
            }
            else
            {
                shareValueRewardPopUp += MoneyPopUp_Open;
            }
        }

    }

    int orderCount = 0;
    int errorCount = 0;

    [SerializeField] int risingTutPerOrder = 10;
    [SerializeField] int fallingTutPerError = 10;
    public void VehicleOrderComplete()
    {
        orderCount++;
        if(orderCount % risingTutPerOrder == 0)
        {
            ShareRisingTutorialStart();
        }
    }

   

    public void ErrorCounter()
    {
        errorCount++;
        if(errorCount % fallingTutPerError == 0)
        {
            ShareFallingTutorialStart();
        }
    }

    void CapacityPopUpOpen()
    {
        capacityPopUp_GO.SetActive(true);
        PlayerController.Instance.PlayerControlDeActive();
    }
    public void CapacityRewardClick()
    {
        SkillManager.Instance.CapacityActive();
        PlayerController.Instance.PlayerControl_ReActive();
        capacityPopUp_GO.SetActive(false);
    }
    void DoubleIncomePopUpOpen()
    {
        doubleIncomePopUp_GO.SetActive(true);
        PlayerController.Instance.PlayerControlDeActive();
    }
    public void DoubleIncomeRewardClick()
    {
        SkillManager.Instance.DoubleIncomeActive();
        PlayerController.Instance.PlayerControl_ReActive();
        doubleIncomePopUp_GO.SetActive(false);
    }
    void SpeedPopUpOpen()
    {
        speedPopUp_GO.SetActive(true);
        PlayerController.Instance.PlayerControlDeActive();
    }
    public void SpeedRewardClick()
    {
        SkillManager.Instance.HoverboardActive();
        PlayerController.Instance.PlayerControl_ReActive();
        speedPopUp_GO.SetActive(false);
    }
    void MoneyPopUp_Open()
    {
        moneyPopUp_GO.SetActive(true);
        moneyText.text = "$" + CoefficientTransformation.Converter((Globals.collectableLevel * 300) + (Globals.openedCarSlotCount * 200) * (PlayerPrefs.GetInt("level") + 1));
    }
    public void MoneyRewardClick()
    {
        GameManager.Instance.ui.FreeMoneyPopUp();
        moneyPopUp_GO.SetActive(false);

    }

    void RepairPopUp_Open()
    {
        repairPopUp_GO.SetActive(true);

    }
    public void RepairClick()
    {
        RepairManager.Instance.repairWorker.showBuyRapairReward.RepairImmediate();
        repairPopUp_GO.SetActive(false);
        PlayerController.Instance.PlayerControl_ReActive();
    }
 

}

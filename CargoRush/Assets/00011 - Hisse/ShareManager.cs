using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ShareManager : MonoBehaviour
{
    private static ShareManager _instance = null;
    public static ShareManager Instance => _instance;

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
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        StartCoroutine(CompaniesPosSet());
    }
    IEnumerator CompaniesPosSet()
    {

        while (true)
        {

            List<HisseCompany> sortedList = hisseCompanies.OrderByDescending(x => (x.currentCompanyShare)).ToList();
            hisseCompanies = sortedList;
            for(int i = 0; i < hisseCompanies.Count;i++)
            {
                hisseCompanies[i].PosSet(hisseCompanyPosList[i] , i - (hisseCompanies.Count - 1));
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

    public void CheckShareTutorialStart()
    {
        checkShareTut_GO.SetActive(true);
        exclamation_GO.SetActive(true);
        checkShareActive = true;

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
}

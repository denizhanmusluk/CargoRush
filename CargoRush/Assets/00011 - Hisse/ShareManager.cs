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
    //public List<HisseCompany> hisseCompaniesSequence = new List<HisseCompany>();

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
                hisseCompanies[i].PosSet(hisseCompanyPosList[i]);
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
    }
    public void CloseGraph()
    {
        graphButton.SetActive(true);
        cancelButton.SetActive(false);
        graphAnim.SetBool("openactive", false);
        PlayerController.Instance.PlayerControl_ReActive();
        graphManager.openedShareUI = false;
    }
}

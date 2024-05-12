using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeoManager : MonoBehaviour
{
    private static CeoManager _instance = null;
    public static CeoManager Instance => _instance;
    public CEOCharacter ceoCharacter;
    public List<Transform> ceoCreatePosList = new List<Transform>();
    //public List<Transform> ceoTargetPosList = new List<Transform>();
    public List<BuyArea> targetBuyAreaList = new List<BuyArea>();
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        for(int i = 0; i < PlayerPrefs.GetInt("ceolevel"); i++)
        {
            targetBuyAreaList[i].gameObject.SetActive(true);
            targetBuyAreaList[i].OpenButDeactive();
        }
    }
    public void CeoStart()
    {
        ceoCharacter.gameObject.SetActive(true);
        ceoCharacter.transform.position = ceoCreatePosList[PlayerPrefs.GetInt("ceolevel")].position;
        ceoCharacter.targetBuyArea = targetBuyAreaList[PlayerPrefs.GetInt("ceolevel")];


        PlayerPrefs.SetInt("ceolevel", PlayerPrefs.GetInt("ceolevel") + 1);
        ceoCharacter.GoToPlayer();
    }

    public void AcceptButtonClick()
    {
        ceoCharacter.GoToBuy_Area();
    }

    public void YesSirButtonClick()
    {
        ceoCharacter.Go_Exit();
    }

}
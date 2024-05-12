using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MarketCustomerManager : MonoBehaviour
{
    private static MarketCustomerManager _instance = null;
    public static MarketCustomerManager Instance => _instance;

    //public List<CollectProduct> collectAreaList;

    //public List<AIMarketCustomer> characterList;
    public GameObject[] characterPrefab;
    public GameObject vipCharacterPrefab;
    [SerializeField] float creatingPeriod;
    [SerializeField] public int maxCharacterCount = 0;

    [SerializeField] int focusCycle;
    public List<AIMarketCustomer> characterList_Electronics;
    public List<AIMarketCustomer> characterList_Sports;
    public List<AIMarketCustomer> characterList_Toys;

    public List<CollectProduct> collectAreaList_Electroincs;
    public List<CollectProduct> collectAreaList_Sports;
    public List<CollectProduct> collectAreaList_Toys;

    public int maxCharacterCount_Electronics = 0;
    public int maxCharacterCount_Sports = 0;
    public int maxCharacterCount_Toys = 0;

    public int[] vipPerCount;
    public int currentCustomerCount = 0;
    public ProcessMachine phoneMachine;
    private void Awake()
    {
        maxCharacterCount = 0;
        maxCharacterCount_Electronics = 0;
        maxCharacterCount_Sports = 0;
        maxCharacterCount_Toys = 0;
    _instance = this;
    }
    void Start()
    {
        StartCoroutine(CreatorElectronicsCustomer());
        StartCoroutine(CreatorSportsCustomer());
        StartCoroutine(CreatorToysCustomer());
    }
    IEnumerator CreatorElectronicsCustomer()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            while (characterList_Electronics.Count >= maxCharacterCount_Electronics || characterList_Electronics.Count >= Globals.extraCustomerCount_Electronics)
            {
                yield return null;
            }
            float offSetTime = Random.Range(0f, 1f);
            yield return new WaitForSeconds(creatingPeriod + offSetTime);
            Creating(MarketType.Electronics);
        }
    }
    IEnumerator CreatorSportsCustomer()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            while (characterList_Sports.Count >= maxCharacterCount_Sports || characterList_Sports.Count >= Globals.extraCustomerCount_Sports)
            {
                yield return null;
            }
            float offSetTime = Random.Range(0f, 1f);
            yield return new WaitForSeconds(creatingPeriod + offSetTime);
            Creating(MarketType.Sports);
        }
    }
    IEnumerator CreatorToysCustomer()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            while (characterList_Toys.Count >= maxCharacterCount_Toys || characterList_Toys.Count >= Globals.extraCustomerCount_Toys)
            {
                yield return null;
            }
            float offSetTime = Random.Range(0f, 1f);
            yield return new WaitForSeconds(creatingPeriod + offSetTime);
            Creating(MarketType.Toys);
        }
    }
    void Creating(MarketType marketType)
    {
        int chaarcterSelect = Random.Range(0, characterPrefab.Length);
        AIMarketCustomer character;

        if (!Globals.vipActive && PlayerPrefs.GetInt("vipActive") == 1)
        {
            currentCustomerCount++;
        }

        switch (marketType)
        {
            case MarketType.Electronics:
                {
                    if (PlayerPrefs.GetInt("vipActive") == 1 && currentCustomerCount >= vipPerCount[PlayerPrefs.GetInt("shopindex")] && !Globals.vipActive && !Globals.holePlatformActive && !Globals.popUpActive)
                    {
                        Globals.vipActive = true;
                        currentCustomerCount = 0;

                        VipCustomer vipCust = Instantiate(vipCharacterPrefab, ElectronicsCaseManager.Instance.customerCreateTR.position, Quaternion.identity).GetComponent<VipCustomer>();
                        vipCust.waitPosTR = ElectronicsCaseManager.Instance.vipWaitingPosTR;
                        vipCust.exitPosTR = ElectronicsCaseManager.Instance.exit;
                        ElectronicsCaseManager.Instance.vipCustomer = vipCust;
                        for (int i = 0; i < collectAreaList_Electroincs.Count; i++)
                        {
                            if (collectAreaList_Electroincs[i].machineActive)
                            {
                                vipCust.collectAreaList.Add(collectAreaList_Electroincs[i]);
                            }
                        }

                        vipCust.marketType = MarketType.Electronics;
                        currentVipCustomer = vipCust;
                
                    }
                    else
                    {

                        character = Instantiate(characterPrefab[chaarcterSelect], ElectronicsCaseManager.Instance.customerCreateTR.position, Quaternion.identity).GetComponent<AIMarketCustomer>();
                        character.marketType = marketType;

                        CustomerAddList(character, marketType);
                        //Shuffle(collectAreaList_Electroincs);
                        SortedCollectElectronicList(collectAreaList_Electroincs);
                        for (int i = 0; i < collectAreaList_Electroincs.Count; i++)
                        {
                            character.collectAreaList.Add(collectAreaList_Electroincs[i]);
                        }
                
                    }
                }
                break;

            case MarketType.Sports:
                {
                    if (PlayerPrefs.GetInt("vipActive") == 1 && currentCustomerCount >= vipPerCount[PlayerPrefs.GetInt("shopindex")] && !Globals.vipActive && !Globals.holePlatformActive && !Globals.popUpActive)
                    {
                        Globals.vipActive = true;
                        currentCustomerCount = 0;


                        VipCustomer vipCust = Instantiate(vipCharacterPrefab, SportsCaseManager.Instance.customerCreateTR.position, Quaternion.identity).GetComponent<VipCustomer>();
                        vipCust.waitPosTR = SportsCaseManager.Instance.vipWaitingPosTR;
                        vipCust.exitPosTR = SportsCaseManager.Instance.exit;
                        SportsCaseManager.Instance.vipCustomer = vipCust;
                        for (int i = 0; i < collectAreaList_Sports.Count; i++)
                        {
                            if (collectAreaList_Sports[i].machineActive)
                            {
                                vipCust.collectAreaList.Add(collectAreaList_Sports[i]);
                            }
                        }

                        vipCust.marketType = MarketType.Sports;
                        currentVipCustomer = vipCust;

               

                    }
                    else
                    {

                        character = Instantiate(characterPrefab[chaarcterSelect], SportsCaseManager.Instance.customerCreateTR.position, Quaternion.identity).GetComponent<AIMarketCustomer>();

                        character.marketType = marketType;

                        CustomerAddList(character, marketType);
                        //Shuffle(collectAreaList_Sports);
                        SortedCollectSportsList(collectAreaList_Sports);
                        for (int i = 0; i < collectAreaList_Sports.Count; i++)
                        {
                            character.collectAreaList.Add(collectAreaList_Sports[i]);
                        }
                  
                    }
                }
                break;

            case MarketType.Toys:
                {
                    if (PlayerPrefs.GetInt("vipActive") == 1 && currentCustomerCount >= vipPerCount[PlayerPrefs.GetInt("shopindex")] && !Globals.vipActive && !Globals.holePlatformActive && !Globals.popUpActive)
                    {
                        Globals.vipActive = true;
                        currentCustomerCount = 0;


                        VipCustomer vipCust = Instantiate(vipCharacterPrefab, ToysCaseManager.Instance.customerCreateTR.position, Quaternion.identity).GetComponent<VipCustomer>();
                        vipCust.waitPosTR = ToysCaseManager.Instance.vipWaitingPosTR;
                        vipCust.exitPosTR = ToysCaseManager.Instance.exit;
                        ToysCaseManager.Instance.vipCustomer = vipCust;
                        for (int i = 0; i < collectAreaList_Toys.Count; i++)
                        {
                            if (collectAreaList_Toys[i].machineActive)
                            {
                                vipCust.collectAreaList.Add(collectAreaList_Toys[i]);
                            }
                        }
                        vipCust.marketType = MarketType.Toys;
                        currentVipCustomer = vipCust;

            
                    }
                    else
                    {
                        character = Instantiate(characterPrefab[chaarcterSelect], ToysCaseManager.Instance.customerCreateTR.position, Quaternion.identity).GetComponent<AIMarketCustomer>();

                        character.marketType = marketType;

                        CustomerAddList(character, marketType);
                        //Shuffle(collectAreaList_Toys);
                        SortedCollectToysList(collectAreaList_Toys);

                        for (int i = 0; i < collectAreaList_Toys.Count; i++)
                        {
                            character.collectAreaList.Add(collectAreaList_Toys[i]);
                        }
                    
                    }
                }
                break;
        }
    }
    public void ReInit(AIMarketCustomer character, MarketType marketType)
    {
        character.collectAreaList.Clear();
        character.collectAreaTarget.Clear();
        //CustomerRemoveList(character, marketType);


        character.marketType = marketType;
        switch (marketType)
        {
            case MarketType.Electronics:
                {
                    CustomerAddList(character, marketType);

                    ElectronicsCaseManager.Instance.extraCustomerList.Add(character);
                    //Shuffle(collectAreaList_Electroincs);
                    SortedCollectElectronicList(collectAreaList_Electroincs);
                    for (int i = 0; i < collectAreaList_Electroincs.Count; i++)
                    {
                        character.collectAreaList.Add(collectAreaList_Electroincs[i]);
                    }
                   
                }
                break;

            case MarketType.Sports:
                {
                    CustomerAddList(character, marketType);
                    SportsCaseManager.Instance.extraCustomerList.Add(character);
                    //Shuffle(collectAreaList_Sports);
                    SortedCollectSportsList(collectAreaList_Sports);
                    for (int i = 0; i < collectAreaList_Sports.Count; i++)
                    {
                        character.collectAreaList.Add(collectAreaList_Sports[i]);
                    }
              
                }
                break;

            case MarketType.Toys:
                {
                    CustomerAddList(character, marketType);
                    ToysCaseManager.Instance.extraCustomerList.Add(character);
                    //Shuffle(collectAreaList_Toys);
                    SortedCollectToysList(collectAreaList_Toys);
                    for (int i = 0; i < collectAreaList_Toys.Count; i++)
                    {
                        character.collectAreaList.Add(collectAreaList_Toys[i]);
                    }
            
                }
                break;
        }
        character.ReStart();
    }
    private System.Random rng = new System.Random();
    public void Shuffle<T>(List<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
    private void SortedCollectElectronicList(List<CollectProduct> CollectProductList)
    {
        List<CollectProduct> sortedList = CollectProductList.OrderByDescending(x => (x.ratio)).ToList();
        collectAreaList_Electroincs = sortedList;
    }
    private void SortedCollectSportsList(List<CollectProduct> CollectProductList)
    {
        List<CollectProduct> sortedList = CollectProductList.OrderByDescending(x => (x.ratio)).ToList();
        collectAreaList_Sports = sortedList;
    }
    private void SortedCollectToysList(List<CollectProduct> CollectProductList)
    {
        List<CollectProduct> sortedList = CollectProductList.OrderByDescending(x => (x.ratio)).ToList();
        collectAreaList_Toys = sortedList;
    }
    public void CustomerAddList(AIMarketCustomer character, MarketType marketType)
    {
        switch (marketType)
        {
            case MarketType.Electronics:
                {
                    characterList_Electronics.Add(character);
                }
                break;

            case MarketType.Sports:
                {
                    characterList_Sports.Add(character);
                }
                break;

            case MarketType.Toys:
                {
                    characterList_Toys.Add(character);
                }
                break;
        }
        //characterList.Add(character);
    }
    public void CustomerRemoveList(AIMarketCustomer character, MarketType marketType)
    {
        switch (marketType)
        {
            case MarketType.Electronics:
                {
                    characterList_Electronics.Remove(character);
                }
                break;

            case MarketType.Sports:
                {
                    characterList_Sports.Remove(character);
                }
                break;

            case MarketType.Toys:
                {
                    characterList_Toys.Remove(character);
                }
                break;
        }
        //characterList.Remove(character);
    }
    public VipCustomer currentVipCustomer;
    //public void VipTutorialStart()
    //{
    //    PlayerController.Instance.FollowVipCustomer();
    //}
}

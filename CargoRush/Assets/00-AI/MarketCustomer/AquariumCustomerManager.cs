using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AquariumCustomerManager : MonoBehaviour
{
    private static AquariumCustomerManager _instance = null;
    public static AquariumCustomerManager Instance => _instance;

    public List<CollectProduct> collectAreaList1;
    public List<CollectProduct> collectAreaList2;

    public List<AquariumCustomer> characterList;
    public GameObject[] characterPrefab;
    [SerializeField] float creatingPeriod;
    [SerializeField] public int maxCharacterCount = 0;

    [SerializeField] int focusCycle;
    private void Awake()
    {
        maxCharacterCount = 0;
        _instance = this;
    }
    void Start()
    {
        StartCoroutine(Creator());
    }
    IEnumerator Creator()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            while (characterList.Count >= maxCharacterCount)
            {
                yield return null;
            }
            yield return new WaitForSeconds(creatingPeriod);
            Creating();
        }
    }
    void Creating()
    {
        int chaarcterSelect = Random.Range(0, characterPrefab.Length);
        AquariumCustomer character = Instantiate(characterPrefab[chaarcterSelect], transform.position, Quaternion.identity).GetComponent<AquariumCustomer>();
        CustomerAddList(character);

        int collectAreaSelect1 = (PlayerPrefs.GetInt("focuscounter") / focusCycle) % collectAreaList1.Count;
        int collectAreaSelect2 = (PlayerPrefs.GetInt("focuscounter") / focusCycle) % collectAreaList2.Count;



        character.collectAreaList_1.Add(collectAreaList1[collectAreaSelect1]);

        for (int i = 0; i < collectAreaList1.Count; i++)
        {
            if (i != collectAreaSelect1)
            {
                character.collectAreaList_1.Add(collectAreaList1[i]);
            }
        }



        character.collectAreaList_2.Add(collectAreaList2[collectAreaSelect2]);

        for (int i = 0; i < collectAreaList2.Count; i++)
        {
            if (i != collectAreaSelect2)
            {
                character.collectAreaList_2.Add(collectAreaList2[i]);
            }
        }
        //...
        //List<CollectProduct> sortedList = collectAreaList.OrderBy(x => x.collectables.Count).ToList();

        //foreach(var lst in sortedList)
        //{
        //    character.collectAreaList.Add(lst);

        //}
    }
    public void CustomerAddList(AquariumCustomer character)
    {
        characterList.Add(character);
    }
    public void CustomerRemoveList(AquariumCustomer character)
    {
        characterList.Remove(character);
    }
}

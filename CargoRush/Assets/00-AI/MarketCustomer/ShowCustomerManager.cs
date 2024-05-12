using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCustomerManager : MonoBehaviour
{
    private static ShowCustomerManager _instance = null;
    public static ShowCustomerManager Instance => _instance;

    public List<CollectProduct> collectAreaList;

    public List<ShowCustomer> characterList;
    public GameObject[] characterPrefab;
    [SerializeField] float creatingPeriod;
    [SerializeField] public int maxCharacterCount = 0;
    private void Awake()
    {
        maxCharacterCount = 0;
        _instance = this;
    }
    public void Start()
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
        ShowCustomer character = Instantiate(characterPrefab[chaarcterSelect], transform.position, Quaternion.identity).GetComponent<ShowCustomer>();
        CustomerAddList(character);

        //...

        //List<CollectProduct> sortedList = collectAreaList.OrderBy(x => x.collectables.Count).ToList();
        for (int i = 0; i < collectAreaList.Count; i++)
        {
            if (!collectAreaList[i].isFull)
            {
                collectAreaList[i].isFull = true;
                character.targetCollect = collectAreaList[i];
                break;
            }
        }
    }
    public void CustomerAddList(ShowCustomer character)
    {
        characterList.Add(character);
    }
    public void CustomerRemoveList(ShowCustomer character)
    {
        characterList.Remove(character);
    }
}

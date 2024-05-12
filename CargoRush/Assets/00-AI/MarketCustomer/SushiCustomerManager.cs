using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiCustomerManager : MonoBehaviour
{
    private static SushiCustomerManager _instance = null;
    public static SushiCustomerManager Instance => _instance;

    public List<CollectProduct> collectAreaList;

    public List<AISushiCustomer> characterList;
    public GameObject[] characterPrefab;
    [SerializeField] float creatingPeriod;
    [SerializeField] public int maxCharacterCount = 0;
    private void Awake()
    {
        maxCharacterCount = 0;
        _instance = this;
    }
    private void Start()
    {
        StartCoroutine(Creator());
    }
    public void CustomerStart()
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
    void Creating()
    {
        int chaarcterSelect = Random.Range(0, characterPrefab.Length);
        AISushiCustomer character = Instantiate(characterPrefab[chaarcterSelect], transform.position, Quaternion.identity).GetComponent<AISushiCustomer>();
        CustomerAddList(character);

        //...

        //List<CollectProduct> sortedList = collectAreaList.OrderBy(x => x.collectables.Count).ToList();
        for(int i = 0; i < collectAreaList.Count; i++)
        {
            if (!collectAreaList[i].isFull)
            {
                collectAreaList[i].isFull = true;
                character.targetCollect = collectAreaList[i];
                break;
            }
        }
        Shuffle(collectAreaList);
    }
    public void CustomerAddList(AISushiCustomer character)
    {
        characterList.Add(character);
    }
    public void CustomerRemoveList(AISushiCustomer character)
    {
        characterList.Remove(character);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class StandCabin : MonoBehaviour
{
    public List<Collectable> droppedCollectionList = new List<Collectable>();
    public int hangerCountTotal;
    public int hangerCountCurrent;
    public TextMeshProUGUI hangerCountText;

    [SerializeField] CollectProduct _CollectProduct;

    public Transform[] productPosTR;
    public CollectType collectTypeMachine;
    public Collectable[] productsPrefab;
    public int[] sportsIDs;
    public List<Transform> targetPointList;
    public bool cabineActive = true;
    public bool cabineCollectableFull = false;
    public Transform targetInPoinTR;
    List<AIMarketCustomer> marketCustomers = new List<AIMarketCustomer>();
    public GameObject fullTextGO;
    [SerializeField] SpriteRenderer cabineFadeImg;
    public GameObject door;
    Vector3 doorColliderFirstSize;
    public GameObject obstacleDoor;
    public List<WorkArea> workAreaList;
    public Transform hangerTrash;
    public int customerCount = 0;
    public void Start()
    {
        doorColliderFirstSize = door.GetComponent<BoxCollider>().size;
        hangerCountText.text = (hangerCountCurrent).ToString() + "/" + (hangerCountTotal).ToString();

        //SportsCaseManager.Instance.standCabins.Add(this);
        fullTextGO.SetActive(false);
        StartCoroutine(WaitingCustomersCheck());
        _CollectProduct.collectables = droppedCollectionList;

    }
  

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<StackCollectMarketCustomer>() != null && cabineActive && other.GetComponent<StackCollectMarketCustomer>().cabinActive)
        {
            other.GetComponent<StackCollectMarketCustomer>().cabinActive = false;
            CollectionChecking(other.GetComponent<StackCollect>());
            cabineActive = false;


        }
    }
    
    void CollectionChecking(StackCollect _stackCollect)
    {
        int collectedNo = 0;
        foreach (var collects in _stackCollect.collectionTrs)
        {
            foreach (int cltId in sportsIDs)
            {
                if (collects.collectID == cltId)
                {
                    collectedNo++;
                    break;
                }
            }
        }
        Debug.Log("collectedNo" + collectedNo);

        if (collectedNo > 0)
        {
            if (collectedNo <= hangerCountTotal - hangerCountCurrent)
            {

                StartCoroutine(HangerCreator(collectedNo));

            }
            else
            {
                StartCoroutine(HangerCreator(hangerCountTotal - hangerCountCurrent));

             
            }
        }
    }





 
    public void ManuealGemCreate()
    {
    }
    IEnumerator HangerCreator(int createCount)
    {
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < createCount; i++)
        {
            GameObject newProduct = Instantiate(productsPrefab[0].gameObject);
            newProduct.GetComponent<Collectable>().collectActive = false;

            newProduct.GetComponent<Collectable>().fishCollectable = droppedCollectionList;

            droppedCollectionList.Add(newProduct.GetComponent<Collectable>());


            float deltaY = 0;
            Transform targetTR;

            deltaY = (droppedCollectionList.Count - 1) / productPosTR.Length;
            targetTR = productPosTR[(droppedCollectionList.Count - 1) % productPosTR.Length];

            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);
            Quaternion targetRot = targetTR.transform.rotation;

            //newProduct.transform.parent = targetTR.parent;


            newProduct.transform.position = dropPos;
            newProduct.transform.rotation = targetRot;

            hangerCountCurrent += 1;
            hangerCountText.text = (hangerCountCurrent).ToString() + "/" + (hangerCountTotal).ToString();
            //yield return new WaitForSeconds(0.2f);
            newProduct.GetComponent<Collectable>().productCollectActive = true;
            yield return null;
        }
    }
    public void CustomerArrived(AIMarketCustomer customer)
    {
        customer.aiStackCollect.GetComponent<StackCollectMarketCustomer>().cabinActive = true;
        marketCustomers.Add(customer);
    }
    IEnumerator WaitingCustomersCheck()
    {
        while (true)
        {
            if (cabineActive && marketCustomers.Count > 0 && !cabineCollectableFull)
            {
                marketCustomers[0].GoCabinInside(targetInPoinTR);
            }

            yield return new WaitForSeconds(1f);
        }
    }
    public void CustomerArrivedInside(AIMarketCustomer customer)
    {
        StartCoroutine(WaitingInside(customer));
    }
    IEnumerator WaitingInside(AIMarketCustomer customer)
    {
        obstacleDoor.SetActive(true);
        door.GetComponent<BoxCollider>().size = Vector3.zero;
        cabineFadeImg.DOFade(1, 1);

        yield return new WaitForSeconds(4f);

        if(PlayerPrefs.GetInt("cabinetutorial") == 0)
        {
            PlayerPrefs.SetInt("cabinetutorial", 1);
            IndicatorManager.Instance.IndicaorActive(transform);
        }
        obstacleDoor.SetActive(false);

        door.GetComponent<BoxCollider>().size = doorColliderFirstSize;
        cabineFadeImg.DOFade(0, 1);

        marketCustomers.Remove(customer);
        customer.CaseWaitListAdd();
        yield return new WaitForSeconds(1f);
        cabineActive = true;
        if (droppedCollectionList.Count >= hangerCountTotal)
        {
            cabineCollectableFull = true;
            fullTextGO.SetActive(true);
        }
        customerCount--;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public enum MarketType
{
    Electronics,
    Sports,
    Toys,
    Null
}
public abstract class Stand : MonoBehaviour
{
    public string machineName;
    public MarketType marketType;

    public CollectType collectType;
    public CollectType collectType2;

    public int cannedCount = 0;

    //public Transform aiTargetPosTR;
    public Transform[] aiTargetPosList;
    public int[] aiTargetPosListCheck;

    public TextMeshProUGUI fishCountText;
    public GameObject woodCountTextArea;
    public int fishCountTotal;
    public int fishCountCurrent;
    public int productCountTotal;

    public int collectID;

    public int[] collectIDList;
    public bool dropActive = true;
    public bool dropActiveAI = true;
    bool woodSetActive;
    public bool StandActive = false;
    public List<Collectable> droppedCollectionList = new List<Collectable>();
    public bool targetActive = true;
    public List<WorkArea> workAreaList;
    public bool productGoActive = true;

    public bool resetActive = false;
    public float waitTime = 1f;
    public bool customerCar = false;
    public abstract void SpecificStart();
    public abstract void SpecificReset();
    public abstract void DropCollection(int collectAmount, StackCollect _stackCollect);
    public abstract void CollectableCountSet();


    [SerializeField] bool onetoOneDropActive;
    public bool machineActive = false;
    private void Start()
    {
        aiTargetPosListCheck = new int[aiTargetPosList.Length];

        SpecificStart();

        TextInit();
        //CarCreate();
        //FishCountInit();
        //if (_FishDropArea != null)
        //{
        //    _FishDropArea.requirementCount += fishCountTotal;
        //}
    }

    public void TextInit()
    {
        fishCountCurrent = fishCountTotal;
        if (fishCountText != null)
        {
            fishCountText.text = (0).ToString() + "/" + (fishCountTotal).ToString();
        }
    }
    //void FishCountInit()
    //{
    //    FishManager.Instance.fishCount += fishCountTotal * 5;
    //}


    private void OnTriggerEnter(Collider other)
    {
        //if (other.GetComponent<PlayerController>() != null && StandActive)
        //{
        //    if (dropActive)
        //    {

        //        dropActive = false;
        //    }
        //}

        //if (other.GetComponent<AIWorker>() != null && StandActive)
        //{
        //    if (other.GetComponent<AIWorker>().aiDropActive)
        //    {

        //        other.GetComponent<AIWorker>().aiDropActive = false;
        //    }
        //}
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && StandActive)
        {
            if (other.GetComponent<PlayerController>().dropActive)
            {
                other.GetComponent<PlayerController>().DropActivator();
                CollectionChecking(other.GetComponent<PlayerController>()._stackCollect);
                StartCoroutine(ColliderReset());
            }
        }
        if (other.GetComponent<AIWorker>() != null && StandActive)
        {
            if (other.GetComponent<AIWorker>().aiDropActive && other.GetComponent<AIWorker>().aiStackActive)
            {
                other.GetComponent<AIWorker>().DropActivator();
                CollectionChecking(other.GetComponent<AIWorker>().aiStackCollect);
                StartCoroutine(ColliderReset());
            }
        }

        if (other.GetComponent<AIGarbageWorker>() != null && StandActive)
        {
            if (other.GetComponent<AIGarbageWorker>().aiDropActive)
            {
                other.GetComponent<AIGarbageWorker>().DropActivator();
                CollectionChecking(other.GetComponent<AIGarbageWorker>().aiStackCollect);
                StartCoroutine(ColliderReset());
            }
        }

      
    }
    IEnumerator ColliderReset()
    {
        GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(Time.deltaTime * 1);
        GetComponent<Collider>().enabled = true;
    }

    void CollectionChecking(StackCollect _stackCollect)
    {

        int collectedNo = 0;
        foreach (var collects in _stackCollect.collectionTrs)
        {
            foreach (int cltId in collectIDList)
            {
                if (collects.collectID == cltId)
                {

                    if (customerCar)
                    {
                        if (fishCountCurrent > 0)
                        {
                            collectedNo++;
                            break;
                        }
                    }
                    else
                    {
                        if (collectType2 == CollectType.All || collectType == CollectType.All || collects.collectType == collectType || collects.collectType == collectType2)
                        {
                            collectedNo++;
                            break;
                        }
                    }
                }
            }
          
        }

        _stackCollect.ReverseCollectedList();
        _stackCollect.CollectedListReset();

        if (customerCar && collectedNo > 0)
        {
            DropCollection(fishCountCurrent, _stackCollect);
        }
        else
        {
            if (collectedNo > 0 && fishCountCurrent > 0)
            {
                if (collectedNo <= fishCountCurrent)
                {
                    DropCollection(collectedNo, _stackCollect);
                    StartCoroutine(SetFishAmount(-collectedNo));
                }
                else
                {
                    DropCollection(fishCountCurrent, _stackCollect);
                    StartCoroutine(SetFishAmount(-fishCountCurrent));
                }
            }
        }
    }



    IEnumerator SetFishAmount(int amount)
    {
        int Old = fishCountCurrent;
        if (onetoOneDropActive)
        {
            fishCountCurrent -= 1;
        }
        else
        {
            fishCountCurrent += amount;
        }

        woodSetActive = false;
        yield return null;
        yield return null;
        woodSetActive = true;
        float counter = 0f;
        while (counter < 1f && woodSetActive)
        {
            counter += Time.deltaTime;
            float value = Mathf.Lerp((float)Old, (float)fishCountCurrent, counter);

            fishCountText.text = (fishCountTotal - (int)value).ToString() + "/" + (fishCountTotal).ToString();


            yield return null;
        }

        fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();

        if (fishCountCurrent == 0 && !resetActive)
        {
            resetActive = true;
            SpecificReset();
        }
    }


    public void TargetArrived(AIWorker aiWorker)
    {
        StartCoroutine(Staying(aiWorker));
    }
    IEnumerator Staying(AIWorker character)
    {
        bool newTargetSelected = false;
        yield return new WaitForSeconds(0.5f);
        bool goOut = false;
        while (!goOut)
        {
            goOut = true;
            foreach (var sk in character.aiStackCollect.collectionTrs)
            {
                goOut = true;
                foreach (var clListId in collectIDList)
                {
                    if (sk.collectID == clListId)
                    {
                        goOut = false;
                        if (character.NewSameTargetStand())
                        {
                            newTargetSelected = true;
                            goOut = true;
                        }
                        break;
                    }               
                }
                if (newTargetSelected)
                {
                    break;
                }
            }
            yield return null;
        }
        if (character.followActive && !newTargetSelected)
        {
            character.TargetFishAreaSelect();
        }
        yield return new WaitForSeconds(0.2f);
    }


    public void TargetCustomerArrived(AIMarketCustomer aiCustomer)
    {
        aiCustomer.Customer_Staying(collectIDList);
        //StartCoroutine(CustomerStaying(aiCustomer));
    }
    IEnumerator CustomerStaying(AIMarketCustomer aiCustomer)
    {
        int selectAreaCountPre = aiCustomer.selectAreaCountCurrent;
        bool newTargetSelected = false;
        yield return new WaitForSeconds(2f);
        bool goOut = false;
        while (!goOut && selectAreaCountPre == aiCustomer.selectAreaCountCurrent && aiCustomer != null)
        {
            goOut = true;
            //foreach (var sk in aiCustomer.aiStackCollect.collectionTrs)
            {
                goOut = true;
                foreach (var clListId in collectIDList)
                {
                    if (aiCustomer.aiStackCollect.GetComponent<StackCollectMarketCustomer>().targetId == clListId)
                    {
                        goOut = false;
                        Debug.Log("check active");
                        if (aiCustomer.NewSameTargetStand())
                        {
                            newTargetSelected = true;
                            goOut = true;
                        }
                        break;
                    }
                }
                if (newTargetSelected)
                {
                    break;
                }
            }
            yield return null;
        }

        yield return new WaitForSeconds(0.2f);
    }
    public void StandReActive()
    {
        StandActive = true;
        GetComponent<Collider>().enabled = true;
    }
}

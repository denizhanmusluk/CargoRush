using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectProduct : MonoBehaviour
{
    public enum WorkType { player_worker, customer, sushiCustomer }
    public WorkType Type;

    public Vector2 customerMinMax;
    public int CollectId;
    public List<Collectable> collectables;
    public Transform[] aiCollectTargetTR;
    public int[] aiCollectTargetCheck;
    public Stand _stand;
    public Sprite standSprite;
    public bool isFull = false;
    public bool aliveFishActive;
    public bool machineActive;
    public int customerCount = 0;
    public WorkArea _FishDropArea;
    public CollectType collectableType;
    public AquariumCar aquariumCar;
    public bool collectActive = true;

    public StandFishCar carSlot;
    public GameObject noneCollectGO;

    public float ratio;
    public Transform boxPosTR;

    public List<Transform> bandPosList;
    public ProcessMachine processMachine;
    private void Awake()
    {
        //if (processMachine != null)
        //{
        //    processMachine.collectProducts.Add(this);
        //    if (processMachine.machineErrored)
        //    {
        //        collectActive = false;
        //    }
        //}
     
    }
    private void Start()
    {
        aiCollectTargetCheck = new int[aiCollectTargetTR.Length];
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() || other.GetComponent<StackCollectWorker>())
        {
            if (_stand != null)
            {
                _stand.productGoActive = true;
            }
            if (noneCollectGO != null)
            {
                noneCollectGO.SetActive(false);
            }
        }
    }
    IEnumerator ColliderReset()
    {
        GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(Time.deltaTime * 2);
        GetComponent<Collider>().enabled = true;
    }
    private void OnTriggerStay(Collider other)
    {
        switch (Type)
        {
            case WorkType.player_worker:
                {
                    if (other.GetComponent<PlayerController>() != null && collectables.Count > 0)
                    {
                        int loopCount = other.GetComponent<PlayerController>()._stackCollect.collectionTrs.Count;

                        bool collectingActive = false;

                        bool isThereProduct = false;
                        bool isThereTrash = false;
                        for (int i = 0; i < loopCount; i++)
                        {
                            if (other.GetComponent<PlayerController>()._stackCollect.collectionTrs[i].collectID == 50)
                            {
                                isThereTrash = true;
                            }
                            else
                            {
                                isThereProduct = true;
                            }
                        }

                        if (collectables[collectables.Count - 1].collectID == 50 && !isThereProduct)
                        {
                            collectingActive = true;
                        }
                        if (collectables[collectables.Count - 1].collectID != 50 && !isThereTrash)
                        {
                            collectingActive = true;
                        }

                        if ((collectingActive) && Globals.playerStackActive && collectables[collectables.Count - 1].productCollectActive && other.GetComponent<PlayerController>()._stackCollect.collectionTrs.Count < (Globals.stackFactor  * other.GetComponent<PlayerController>()._characterUpgradeSettings.stackCapacity[Globals.stackCapacityLevel] + Globals.extraStackSkin + Globals.extraStack))
                        {
                            if(noneCollectGO != null)
                            {
                                if ((collectableType == CollectType.Type1 && Globals.productType1) || (collectableType == CollectType.Type2 && Globals.productType2) || (collectableType == CollectType.Type3 && Globals.productType3) || (collectableType == CollectType.Type4 && Globals.productType4) || (collectableType == CollectType.Type5 && Globals.productType5))
                                {
                                    //if (!processMachine.machineErrored)
                                    {
                                        collectables[collectables.Count - 1].productCollectActive = false;

                                        other.GetComponent<PlayerController>()._stackCollect.Collecting(collectables[collectables.Count - 1]);
                                        StartCoroutine(ColliderReset());
                                        if (_stand != null)
                                        {
                                            _stand.cannedCount--;
                                            _stand.CollectableCountSet();
                                        }
                                      

                                    }
                                    //else
                                    //{
                                    //    noneCollectGO.SetActive(true);
                                    //}
                                }
                         

                            }
                            else
                            {
                                if (PlayerPrefs.GetInt("viptutorial") == 1)
                                {
                                    PlayerPrefs.SetInt("viptutorial", 2);
                                    IndicatorManager.Instance.IndicaorActive(MarketCustomerManager.Instance.currentVipCustomer.playerFollowPosTR);
                                }
                                collectables[collectables.Count - 1].productCollectActive = false;

                                other.GetComponent<PlayerController>()._stackCollect.Collecting(collectables[collectables.Count - 1]);
                                StartCoroutine(ColliderReset());
                                if (_stand != null)
                                {
                                    _stand.cannedCount--;
                                    _stand.CollectableCountSet();
                                }
                                if (carSlot != null)
                                {
                                    carSlot.CollectTrash();
                                }
                            }
                        }
                        if(other.GetComponent<PlayerController>()._stackCollect.collectionTrs.Count >= (Globals.stackFactor * other.GetComponent<PlayerController>()._characterUpgradeSettings.stackCapacity[Globals.stackCapacityLevel] + Globals.extraStackSkin + Globals.extraStack))
                        {
                            //StartCoroutine(FullCapacity());
                        }
                    }

                    if (other.GetComponent<StackCollectWorker>() != null && collectables.Count > 0 && CollectId == other.GetComponent<StackCollectWorker>().targetId && collectableType == other.GetComponent<StackCollectWorker>().collectableType && other.GetComponent<StackCollectWorker>().collectActive)
                    {
                        if (collectables[collectables.Count - 1].productCollectActive && other.GetComponent<StackCollectWorker>().collectionTrs.Count < (other.GetComponent<StackCollectWorker>().baseStackCapacity + other.GetComponent<StackCollectWorker>().characterUpgradeSettings.workerCapacity[Globals.workerCapacityLevel] * Globals.workerStackFactor))
                        {

                            int loopCount = other.GetComponent<StackCollectWorker>().collectionTrs.Count;

                            bool collectingActive = false;

                            bool isThereProduct = false;
                            bool isThereTrash = false;
                            //for (int i = 0; i < loopCount; i++)
                            //{
                            //    if (other.GetComponent<StackCollectWorker>().collectionTrs[i].collectID == 50)
                            //    {
                            //        isThereTrash = true;
                            //    }
                            //    else
                            //    {
                            //        isThereProduct = true;
                            //    }
                            //}

                            if (collectables[collectables.Count - 1].collectID == 50 && !isThereProduct)
                            {
                                collectingActive = true;
                            }
                            if (collectables[collectables.Count - 1].collectID != 50 && !isThereTrash)
                            {
                                collectingActive = true;
                            }


                            if (collectingActive && other.GetComponent<StackCollectWorker>().collectionTrs.Count < other.GetComponent<StackCollectWorker>().currentCapacity)
                            {
                                collectables[collectables.Count - 1].productCollectActive = false;
                                other.GetComponent<StackCollectWorker>().Collecting(collectables[collectables.Count - 1]);
                                StartCoroutine(ColliderReset());
                                if (_stand != null)
                                {
                                    _stand.cannedCount--;
                                    _stand.CollectableCountSet();
                                }

                            }
                        }
                    }
                }
                break;
            case WorkType.customer:
                {
                    if (other.GetComponent<OnlineWorker>() != null)
                    {
                        if (other.GetComponent<OnlineWorker>().stackCollect.collectionTrs.Count < other.GetComponent<OnlineWorker>().stackCollect.baseStackCapacity)
                        {
                            if (collectables.Count > 0 && collectables[collectables.Count - 1].productCollectActive)
                            {
                                other.GetComponent<OnlineWorker>().stackCollect.Collecting(collectables[collectables.Count - 1]);
                                _stand.fishCountCurrent++;
                                StartCoroutine(ColliderReset());

                            }
                        }
                    }
                    if (other.GetComponent<StackCollectMarketCustomer>() != null && CollectId == other.GetComponent<StackCollectMarketCustomer>().targetId && other.GetComponent<StackCollectMarketCustomer>()._aiCustomer.currentTarget.collectableType == collectableType)
                    {
                        if (other.GetComponent<StackCollectMarketCustomer>()._aiCustomer.shoppingActive)
                        {
                            if (other.GetComponent<StackCollectMarketCustomer>().collectionTrs.Count < other.GetComponent<StackCollectMarketCustomer>().stackCapacity)
                            {
                                if (collectables.Count > 0 && collectables[collectables.Count - 1].productCollectActive)
                                {
                                    collectables[collectables.Count - 1].productCollectActive = false;
                                    if(collectables[collectables.Count - 1].GetComponent<TShirt>() != null)
                                    {
                                        collectables[collectables.Count - 1].GetComponent<TShirt>().HangerClose();
                                    }
                                    other.GetComponent<StackCollectMarketCustomer>().Collecting(collectables[collectables.Count - 1]);

                                    //collectables.Remove(collectables[collectables.Count - 1]);
                                    _stand.fishCountCurrent++;
                                    other.GetComponent<StackCollectMarketCustomer>()._aiCustomer.currentCountStack++;
                                    other.GetComponent<StackCollectMarketCustomer>()._aiCustomer.StackTextInit();
                                    StartCoroutine(ColliderReset());
                                    if (_stand != null)
                                    {
                                        //_stand.cannedCount--;
                                        _stand.CollectableCountSet();
                                    }
                                }

                            }
                            else
                            {
                                other.GetComponent<StackCollectMarketCustomer>()._aiCustomer.NextTarget();
                                customerCount--;
                            }
                        }
                    }


                }
                break;
        }
    }


    bool fullTextActive = true;
    IEnumerator FullCapacity()
    {

        if (fullTextActive)
        {
            GameManager.Instance.ui.fullCapacityText.SetActive(true);
            fullTextActive = false;
            float counter = 0f;
            while (counter < 2f)
            {
                counter += Time.deltaTime;
                yield return null;
            }
            fullTextActive = true;
            GameManager.Instance.ui.fullCapacityText.SetActive(false);
        }
        yield return null;

    }
}

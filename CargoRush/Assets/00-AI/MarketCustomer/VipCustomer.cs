using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

public class VipCustomer : MonoBehaviour
{
    public MarketType marketType;

    public event Action following;
    public StackCollect aiStackCollect;
    public NavMeshAgent navMeshAgent;
    public Animator animator;
    public float AImoveSpeed;
    public Transform canvasProduactTR;
    public GameObject smileyGO;
    public GameObject emojiAngryGO;
    [SerializeField] Image[] _image = new Image[3];
    [SerializeField] Image[] _imageBG = new Image[3];
    public TextMeshProUGUI[] stackText = new TextMeshProUGUI[3];
    public int extraPrice;
    public Transform waitPosTR;
    public Transform exitPosTR;
    public List<CollectProduct> collectAreaList;
    public List<CollectProduct> collectAreaList_Temp;

    public List<Vector2> collectIdListR;
    public List<int> collectIdList;

    bool moveActive = true;

    public bool characterStayActive = false;
    public bool isStayHoldActive = false;

    public bool itsOk = false;

    public List<int> totalProductCount;
    public List<int> currentProductCount;
    int randomSelectTypeCount;

    public Transform playerFollowPosTR;
    public bool vipStackActive = false;
    void Start()
    {
        collectAreaList_Temp.Add(collectAreaList[0]);

        for (int i = 1; i < collectAreaList.Count; i++)
        {
            bool addActive = true;
            for(int j = 0; j < collectAreaList_Temp.Count; j++)
            {
                if(collectAreaList[i].CollectId == collectAreaList_Temp[j].CollectId)
                {
                    addActive = false;
                }
            }
            if (addActive && collectAreaList[i].machineActive)
            {
                collectAreaList_Temp.Add(collectAreaList[i]);
            }
        }
        for(int i = 0; i < 3; i++)
        {
            _image[i].gameObject.SetActive(false);
            _imageBG[i].gameObject.SetActive(false);
            stackText[i].gameObject.SetActive(false);
        }
        following = null;
        following += GoToWaitingPos;
        if (PlayerPrefs.GetInt("viptutorial") == 0)
        {
            int randomSelectCount = 10;
            for (int t = 0; t < randomSelectCount; t++)
            {
                collectIdListR.Add(new Vector2((int)collectAreaList[0].CollectId, 0));
                collectIdList.Add(collectAreaList[0].CollectId);
            }

            _image[0].gameObject.SetActive(true);
            _imageBG[0].gameObject.SetActive(true);
            stackText[0].gameObject.SetActive(true);

            _image[0].sprite = collectAreaList[0].standSprite;
            stackText[0].text = "0/" + randomSelectCount.ToString();
            totalProductCount.Add(randomSelectCount);
            currentProductCount.Add(0);
        }
        else
        {
            int totalTypeCount = collectAreaList_Temp.Count;
            if (totalTypeCount > 3)
            {
                totalTypeCount = 3;
            }
            randomSelectTypeCount = UnityEngine.Random.Range(1, totalTypeCount + 1);
            for (int i = 0; i < randomSelectTypeCount; i++)
            {

                Shuffle(collectAreaList_Temp);
                int randomSelectCount = UnityEngine.Random.Range(5, 11);
                for (int t = 0; t < randomSelectCount; t++)
                {
                    collectIdListR.Add(new Vector2((int)collectAreaList_Temp[0].CollectId, i));
                    collectIdList.Add(collectAreaList_Temp[0].CollectId);
                }

                _image[i].gameObject.SetActive(true);
                _imageBG[i].gameObject.SetActive(true);
                stackText[i].gameObject.SetActive(true);

                _image[i].sprite = collectAreaList_Temp[0].standSprite;
                stackText[i].text = "0/" + randomSelectCount.ToString();
                totalProductCount.Add(randomSelectCount);
                currentProductCount.Add(0);
                collectAreaList_Temp.Remove(collectAreaList_Temp[0]);
            }
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
    // Update is called once per frame
    void Update()
    {
        following?.Invoke();
        canvasProduactTR.rotation = Quaternion.Euler(canvasProduactTR.eulerAngles.x, 42.038f, canvasProduactTR.eulerAngles.z);
    }

    void GoToWaitingPos()
    {
        if (moveActive && Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(waitPosTR.position.x, waitPosTR.position.z)) > 0.6f)
        {
            characterStayActive = false;

            Vector3 targetPos = new Vector3(waitPosTR.position.x, transform.position.y, waitPosTR.position.z);
            animator.SetBool("walk", true);
            navMeshAgent.SetDestination(targetPos);
            if (navMeshAgent.isStopped)
            {
                moveActive = false;
            }
        }
        else
        {

            if (!characterStayActive)
            {
                characterStayActive = true;
            }
            if (!isStayHoldActive)
            {
                isStayHoldActive = true;
                animator.SetBool("walk", false);
                following = null;

                // waiting start
                switch (marketType)
                {
                    case MarketType.Electronics:
                        {
                            ElectronicsCaseManager.Instance.VipWaitStart();
                        }
                        break;

                    case MarketType.Sports:
                        {
                            SportsCaseManager.Instance.VipWaitStart();
                        }
                        break;

                    case MarketType.Toys:
                        {
                            ToysCaseManager.Instance.VipWaitStart();
                        }
                        break;
                }
                vipStackActive = true;

                if (PlayerPrefs.GetInt("viptutorial") == 0)
                {
                    PlayerController.Instance.PlayerRotReset();
                    PlayerController.Instance.PlayerControlDeActive();
                    //MarketCustomerManager.Instance.phoneMachine.ManuealProductCreateTutorial();
                    IndicatorManager.Instance.IndicaorDeActive();
                    StartCoroutine(WaitingArrived());
                }

            }
        }
    }
    IEnumerator WaitingArrived()
    {
        yield return new WaitForSeconds(1f);
        PlayerController.Instance.FollowVipCustomer();

    }
    public void AllTheNeedsCompleteCheck()
    {
        if (!itsOk)
        {
            itsOk = true;
        }
    }
    public void GoExit()
    {
        RewardPanel.Instance.vipPanelGO.SetActive(false);
        if (PlayerPrefs.GetInt("viptutorial") == 2)
        {
            PlayerPrefs.SetInt("viptutorial", 3);
            IndicatorManager.Instance.IndicaorDeActive();
        }
        Globals.vipActive = false;
        isStayHoldActive = false;
        following = null;
        following += GoToExitPos;
    }

    void GoToExitPos()
    {
        if (moveActive && Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(exitPosTR.position.x, exitPosTR.position.z)) > 0.6f)
        {
            characterStayActive = false;

            Vector3 targetPos = new Vector3(exitPosTR.position.x, transform.position.y, exitPosTR.position.z);
            animator.SetBool("walk", true);
            navMeshAgent.SetDestination(targetPos);
            if (navMeshAgent.isStopped)
            {
                moveActive = false;
            }
        }
        else
        {

            if (!characterStayActive)
            {
                characterStayActive = true;
            }
            if (!isStayHoldActive)
            {
                isStayHoldActive = true;
                animator.SetBool("walk", false);
                following = null;
                ArrivedToExitPos();
            }
        }
    }

    void ArrivedToExitPos()
    {
        Globals.vipActive = false;
        MarketCustomerManager.Instance.currentCustomerCount = 0;

        foreach (var clt in aiStackCollect.collectionTrs)
        {
            Destroy(clt.gameObject);
        }
        aiStackCollect.collectionTrs.Clear();
        Destroy(gameObject, 0.1f);
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && characterStayActive && vipStackActive && collectIdList.Count > 0)
        {
            if (other.GetComponent<PlayerController>().dropActive)
            {
                other.GetComponent<PlayerController>().DropActivator();
                CollectionChecking(other.GetComponent<PlayerController>()._stackCollect);
                StartCoroutine(ColliderReset());
            }
        }
    }
    void CollectionChecking(StackCollect _stackCollect)
    {
        Collectable droppingCollection = null;
        foreach (var collects in _stackCollect.collectionTrs)
        {
            bool breakActive = false;
            for (int i = 0; i < collectIdList.Count;i++)
            {
                if (collects.collectID == collectIdList[i])
                {
                    for(int t = 0; t < collectIdListR.Count; t++)
                    {
                        if((int)collectIdListR[t].x == collectIdList[i])
                        {
                            currentProductCount[(int)collectIdListR[t].y]++;
                            break;
                        }
                    }
                    
                    droppingCollection = collects;
                    _stackCollect.collectionTrs.Remove(droppingCollection);
                    collectIdList.Remove(collectIdList[i]);
                    collectIdListR.Remove(collectIdListR[i]);

                    aiStackCollect.Collecting(droppingCollection);
                    droppingCollection.gameObject.SetActive(false);
                    breakActive = true;
                    break;
                }
            }
            if (breakActive)
            {
                break;
            }
        }

        if (collectIdList.Count == 0)
        {
            itsOk = true;
        }
        TextInit();
        _stackCollect.ReverseCollectedList();
        _stackCollect.CollectedListReset();
    }
    void TextInit()
    {
        for(int i = 0; i < totalProductCount.Count; i++)
        {
            stackText[i].text = currentProductCount[i].ToString() + "/" + totalProductCount[i].ToString();
        }
    }

    IEnumerator ColliderReset()
    {
        GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(Time.deltaTime * 4);
        GetComponent<Collider>().enabled = true;
    }
}

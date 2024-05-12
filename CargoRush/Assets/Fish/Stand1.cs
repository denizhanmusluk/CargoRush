using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Stand1 : MonoBehaviour
{
    [SerializeField] MoneyArea moneyArea;

    [SerializeField] Transform carCreateTR, carStandTR, carGoTR;
    [SerializeField] TextMeshProUGUI fishCountText;
    [SerializeField] GameObject woodCountTextArea;
    [SerializeField] int fishCountTotal;
    [SerializeField] public int fishCountCurrent;
    [SerializeField] int collectID;
    public bool dropActive = true;
    public bool dropActiveAI = true;
    bool woodSetActive;
    [SerializeField] string currentFish;
    [SerializeField] GameObject carPrefab;
    GameObject currentCar;
    public bool StandActive = false;


    [SerializeField] List<Collectable> droppedCollectionList = new List<Collectable>();
    public bool targetActive = true;

    private void Start()
    {
        //StandManager.Instance.standList.Add(this);

        TextInit();
        CarCreate();
        //FishCountInit();
    }
    //void FishCountInit()
    //{
    //    FishManager.Instance.fishCount += fishCountTotal * 20;
    //}
    void CarCreate()
    {
        currentCar = Instantiate(carPrefab, carCreateTR.position, Quaternion.identity);
        //currentCar.GetComponent<FishCar>().stand = this;
        currentCar.GetComponent<FishCar>().standPos = carStandTR;
        currentCar.GetComponent<FishCar>().carGoPos = carGoTR;
    }
    void TextInit()
    {
        fishCountCurrent = fishCountTotal;
        fishCountText.text = (0).ToString() + "/" + (fishCountTotal).ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && StandActive)
        {
            if (dropActive)
            {
                Debug.Log("OnTriggerEnter");

                //CollectionChecking(other.GetComponent<PlayerController>()._stackCollect);
                dropActive = false;
            }
        }

        if (other.GetComponent<AIWorker>() != null && StandActive)
        {
            if (dropActiveAI)
            {
                Debug.Log("OnTriggerEnter");

                //CollectionChecking(other.GetComponent<PlayerController>()._stackCollect);
                dropActiveAI = false;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && StandActive)
        {
            if (!dropActive)
            {
                Debug.Log("collect check");

                CollectionChecking(other.GetComponent<PlayerController>()._stackCollect);
                dropActive = true;
            }
        }
        if (other.GetComponent<AIWorker>() != null && StandActive)
        {
            if (!dropActiveAI)
            {
                Debug.Log("collect check");

                CollectionChecking(other.GetComponent<AIWorker>().aiStackCollect);
                dropActiveAI = true;
            }
        }
    }
    void CollectionChecking(StackCollect _stackCollect)
    {

        int collectedNo = 0;
        foreach (var collects in _stackCollect.collectionTrs)
        {
            if (collects.collectID == collectID)
            {
                collectedNo++;
            }
        }

        _stackCollect.ReverseCollectedList();
        _stackCollect.CollectedListReset();

        if (collectedNo <= fishCountCurrent)
        {
            DropCollection( 0, collectedNo , _stackCollect);
            StartCoroutine(SetWoodAmount(-collectedNo));
        }
        else
        {
            DropCollection(0, fishCountCurrent, _stackCollect);
            StartCoroutine(SetWoodAmount(-fishCountCurrent));
        }
    }

    IEnumerator SetWoodAmount(int amount)
    {
        int Old = fishCountCurrent;
        fishCountCurrent += amount;
        //PlayerPrefs.SetInt(currentFish, fishCountCurrent);
        //if (fishCountCurrent == 0)
        //{
        //    PlayerPrefs.SetInt(currentFish, -1);
        //}

        woodSetActive = false;
        yield return null;
        yield return null;
        woodSetActive = true;
        float counter = 0f;
        while (counter < 1f && woodSetActive)
        {
            counter += Time.deltaTime;
            float value = Mathf.Lerp((float)Old, (float)fishCountCurrent, counter);
            //fishCountText.text = ((int)value).ToString();

            fishCountText.text = (fishCountTotal - (int)value).ToString() + "/" + (fishCountTotal).ToString();

            //woodCountText.text = (woodCountTotal - (int)value).ToString() + "/" + woodCountTotal.ToString();

            yield return null;
        }
        //fishCountText.text = (fishCountCurrent).ToString();

        fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();

        if (fishCountCurrent == 0)
        {
            //woodCountTextArea.SetActive(false);
            ResetStand();
        }
        //woodCountText.text = (woodCountTotal - woodCountCurrent).ToString() + "/" + woodCountTotal.ToString();
    }
    void ResetStand()
    {
        StartCoroutine(ResetDelay());
        Debug.Log("reset");
    }
    IEnumerator ResetDelay()
    {
        //DropMoney();
        StandActive = false;
        yield return new WaitForSeconds(0.4f);
        droppedCollectionList.Clear();
        GetComponent<Collider>().enabled = false;
        currentCar.GetComponent<FishCar>().CarGoOut();
        yield return new WaitForSeconds(0.1f);
        TextInit();
        CarCreate();
    }
    public void StandReActive()
    {
        StandActive = true;
        GetComponent<Collider>().enabled = true;
    }




    public void DropCollection(int collectID, int collectAmount, StackCollect _stackCollect)
    {
        if (collectAmount > 0)
        {
            //VibratoManager.Instance.MediumMultiVibration();
            _stackCollect.collectActive = false;
        }
        StartCoroutine(DropSequantial(collectID, collectAmount, _stackCollect));
    }

    IEnumerator DropSequantial(int collectID, int collectAmount, StackCollect _stackCollect)
    {
        yield return null;

        List<Collectable> droppingCollectionList = new List<Collectable>();

        int amount = collectAmount;
        int loopCount = _stackCollect.collectionTrs.Count;
        for (int i = 0; i < loopCount; i++)
        {
            if (_stackCollect.collectionTrs[i].collectID == collectID && amount > 0)
            {
                droppingCollectionList.Add(_stackCollect.collectionTrs[i]);

                amount--;
            }
        }


        for (int i = 0; i < droppingCollectionList.Count; i++)
        {
            Collectable deletedCollect = droppingCollectionList[i];

            _stackCollect.collectionTrs.Remove(deletedCollect);
            //Destroy(deletedCollect.gameObject,4f);
        }
        for (int i = 0; i < droppingCollectionList.Count; i++)
        {
            droppedCollectionList.Add(droppingCollectionList[i]);
            //yield return null;

            float deltaY = 0;
            deltaY = (droppedCollectionList.Count - 1)/ currentCar.GetComponent<FishCar>().fishPosTR.Length;
            Transform targetTR = currentCar.GetComponent<FishCar>().fishPosTR[(droppedCollectionList.Count - 1)% currentCar.GetComponent<FishCar>().fishPosTR.Length];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);
            StartCoroutine(Drop(targetTR, dropPos, droppingCollectionList[i], i * 0.05f));

            //yield return null;
        }

        if (_stackCollect.collectionTrs.Count == 0)
        {
            //PlayerController.Instance.animator.SetBool("carrying", false);
        }
        _stackCollect.collectActive = true;
        DropMoney(droppingCollectionList);
    }

    IEnumerator Drop(Transform dropPosTR, Vector3 dropPos, Collectable collectable,float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Vector3 firstPos = collectable.transform.position;
        Quaternion firstRot = collectable.transform.rotation;
        if (collectable.gameObject != null)
        {
            collectable.CollectSave();
            collectable.transform.parent = null;
            firstPos = collectable.transform.position;
            firstRot = collectable.transform.rotation;
        }

        float timeCounter = 0;
        Vector3 tempPosition = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(1f, 2f), Random.Range(-0.5f, 0.5f));
        Quaternion tempAngle = Quaternion.Euler(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180));
        while (timeCounter < 1f)
        {
            timeCounter += 4 * Time.deltaTime;


            if (collectable.gameObject != null)
            {
                collectable.transform.position = Vector3.Lerp(firstPos, transform.position + tempPosition, timeCounter);
                collectable.transform.rotation = Quaternion.Lerp(firstRot, tempAngle, timeCounter);
            }
            yield return null;
        }
        if (collectable.gameObject != null)
        {
            firstPos = collectable.transform.position;
            firstRot = collectable.transform.rotation;
        }
        yield return new WaitForSeconds(0.1f);
        timeCounter = 0f;


        Quaternion targetAngle = Quaternion.Euler(dropPosTR.eulerAngles.x, dropPosTR.eulerAngles.y + Random.Range(-30f, 30f), dropPosTR.eulerAngles.z + Random.Range(-30f, 30f));

        while (timeCounter < 1f)
        {
            timeCounter += 4 * Time.deltaTime;
            if (collectable.gameObject != null)
            {
                collectable.transform.position = Vector3.Lerp(firstPos, dropPos, timeCounter);
                collectable.transform.rotation = Quaternion.Lerp(firstRot, targetAngle, timeCounter);
            }
            else
            {
                Debug.Log("NULLLLLLLLLL");
            }
            yield return null;
        }
        if (collectable.gameObject != null)
        {
            collectable.transform.parent = currentCar.GetComponent<FishCar>().fishPosParent;

            //collectable.gameObject.SetActive(false);
        }
    }
    //void DropMoney()
    //{
    //    StartCoroutine(DroppingMoney());
    //}
    //IEnumerator DroppingMoney()
    //{
    //    int moneyListCount = moneyArea.moneyList.Count;
    //    for (int i = 0; i < fishCountTotal; i++)
    //    {
    //        float deltaY = 0;
    //        deltaY = (moneyListCount + i) / moneyArea.dropMoneyPosList.Count;
    //        Transform targetTR = moneyArea.dropMoneyPosList[(moneyListCount + i) % moneyArea.dropMoneyPosList.Count];
    //        Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.2f, 0);
    //        BanknotMoney banknot = Instantiate(moneyArea.moneyPrefab, moneyArea.firstMoneyCreatePosTR.position, Quaternion.identity).GetComponent<BanknotMoney>();
    //        banknot.MovingMoney(moneyArea.firstMoneyCreatePosTR.position, dropPos);
    //        moneyArea.moneyList.Add(banknot);
    //        yield return null;
    //    }
    //}

    void DropMoney(List<Collectable> droppingCollectionList)
    {
        StartCoroutine(DroppingMoney(droppingCollectionList));
    }
    IEnumerator DroppingMoney(List<Collectable> droppingCollectionList)
    {
        int moneyListCount = moneyArea.moneyList.Count;
        for (int i = 0; i < droppingCollectionList.Count; i++)
        {
            float deltaY = 0;
            deltaY = (moneyListCount + i) / moneyArea.dropMoneyPosList.Count;
            Transform targetTR = moneyArea.dropMoneyPosList[(moneyListCount + i) % moneyArea.dropMoneyPosList.Count];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.2f, 0);
            BanknotMoney banknot = Instantiate(moneyArea.moneyPrefab, moneyArea.firstMoneyCreatePosTR.position, Quaternion.identity).GetComponent<BanknotMoney>();
            banknot.MovingMoney(moneyArea.firstMoneyCreatePosTR.position, dropPos);
            banknot.banknotValue = droppingCollectionList[i].price;
            moneyArea.moneyList.Add(banknot);
            yield return null;
        }
    }







    public void TargetArrived(AIWorker aiWorker)
    {
        StartCoroutine(Staying(aiWorker));
    }
    IEnumerator Staying(AIWorker character)
    {
        //character.aiPopUp.OpenOperationPopUp(5);
        yield return new WaitForSeconds(Random.Range(1f, 2f));
        //character.aiPopUp.ClosedAllPopUp();
        if (character.followActive)
        {
            character.TargetFishAreaSelect();
        }
        yield return new WaitForSeconds(1f);

        //targetActive = true;
    }
}

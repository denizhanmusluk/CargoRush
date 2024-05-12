using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiDesk : Stand
{
    [SerializeField] CollectProduct _CollectProduct;

    public Transform[] fishPosTR;
    [SerializeField] int customerCount;
    [SerializeField] int fishCountHole;
    [SerializeField] int holeFishID;
    public override void CollectableCountSet()
    {

    }
    public override void SpecificStart()
    {
        _CollectProduct.collectables = droppedCollectionList;

        //StandManager.Instance.standList.Add(this);
        //_FishDropArea.standList.Add(this);

        StandReActive();
        FishCountInit();

        SushiCustomerManager.Instance.collectAreaList.Add(_CollectProduct);
        SushiCustomerManager.Instance.maxCharacterCount += customerCount;
    }
    void FishCountInit()
    {
        FishManager.Instance.fishCount[holeFishID] += fishCountHole;
    }
    public override void SpecificReset()
    {
        //ResetStand();
    }





    public override void DropCollection(int collectAmount, StackCollect _stackCollect)
    {
        if (collectAmount > 0)
        {
            //VibratoManager.Instance.MediumMultiVibration();
            _stackCollect.collectActive = false;
        }
        StartCoroutine(DropSequantial(collectAmount, _stackCollect));
    }

    IEnumerator DropSequantial(int collectAmount, StackCollect _stackCollect)
    {
        yield return null;

        List<Collectable> droppingCollectionList = new List<Collectable>();

        int amount = collectAmount;
        int loopCount = _stackCollect.collectionTrs.Count;
        for (int i = 0; i < loopCount; i++)
        {
            foreach (var clListId in collectIDList)
            {
                if (_stackCollect.collectionTrs[i].collectID == clListId && amount > 0)
                {
                    droppingCollectionList.Add(_stackCollect.collectionTrs[i]);

                    amount--;
                    break;
                }
            }
        }


        for (int i = 0; i < droppingCollectionList.Count; i++)
        {
            droppingCollectionList[i].productCollectActive = true;
            droppingCollectionList[i].fishCollectable = droppedCollectionList;

            Collectable deletedCollect = droppingCollectionList[i];

            _stackCollect.collectionTrs.Remove(deletedCollect);
            //Destroy(deletedCollect.gameObject,4f);
        }
        for (int i = 0; i < droppingCollectionList.Count; i++)
        {
            droppedCollectionList.Add(droppingCollectionList[i]);
            //yield return null;

            float deltaY = 0;
            deltaY = (droppedCollectionList.Count - 1) / fishPosTR.Length;
            Transform targetTR = fishPosTR[(droppedCollectionList.Count - 1) % fishPosTR.Length];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);
            StartCoroutine(Drop(targetTR, dropPos, droppingCollectionList[i], i * 0.05f));
            if (_stackCollect.player)
            {
                VibratoManager.Instance.LightVibration();
            }
            //yield return null;
        }

        if (_stackCollect.collectionTrs.Count == 0)
        {
            //PlayerController.Instance.animator.SetBool("carrying", false);
        }
        yield return new WaitForSeconds(0.5f);
        _stackCollect.collectActive = true;
        //_FishDropArea.ShuffleList();
    }

    IEnumerator Drop(Transform dropPosTR, Vector3 dropPos, Collectable collectable, float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        collectable.transform.parent = null;
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
        //Vector3 tempPosition = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(1f, 2f), Random.Range(-0.5f, 0.5f));
        //Quaternion tempAngle = Quaternion.Euler(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180));
        //while (timeCounter < 1f)
        //{
        //    timeCounter += 4 * Time.deltaTime;


        //    if (collectable.gameObject != null)
        //    {
        //        collectable.transform.position = Vector3.Lerp(firstPos, transform.position + tempPosition, timeCounter);
        //        collectable.transform.rotation = Quaternion.Lerp(firstRot, tempAngle, timeCounter);
        //    }
        //    yield return null;
        //}
        //if (collectable.gameObject != null)
        //{
        //    firstPos = collectable.transform.position;
        //    firstRot = collectable.transform.rotation;
        //}
        //yield return new WaitForSeconds(0.1f);

        float angle = 0f;
        float posY = 0f;
        float posY_Factor = 2f;
        timeCounter = 0f;


        Quaternion targetAngle = dropPosTR.rotation;
        //Quaternion targetAngle = Quaternion.Euler(dropPosTR.eulerAngles.x, dropPosTR.eulerAngles.y + Random.Range(-30f, 30f), dropPosTR.eulerAngles.z + Random.Range(-30f, 30f));

        while (timeCounter < 1f)
        {
            timeCounter += 4 * Time.deltaTime;
            angle = timeCounter * Mathf.PI;
            posY = posY_Factor * Mathf.Sin(angle);


            if (collectable.gameObject != null)
            {
                collectable.transform.position = Vector3.Lerp(firstPos, new Vector3(dropPos.x, dropPos.y + posY, dropPos.z), timeCounter);
                collectable.transform.rotation = Quaternion.Lerp(firstRot, targetAngle, timeCounter);
            }
            yield return null;
        }
        collectable.transform.position = dropPos;

      
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
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(1f);
        droppedCollectionList.Clear();
        yield return new WaitForSeconds(0.1f);
        TextInit();
    }
}

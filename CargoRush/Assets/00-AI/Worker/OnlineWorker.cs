using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlineWorker : MonoBehaviour
{
    public Animator workerAnimator;
    public AIMoving aiMoving;
    public StandFishTezgah stand;
    public StackCollectWorker stackCollect;
    public Transform waitingPos;

    public Transform boxCollectPos;
    public Transform boxDropPos;
    public Transform boxPos;

    public Animator tableAnim;
    bool collectCheckActive = true;
    public GameObject fireGO;
    private void Start()
    {
        StartCoroutine(CheckStandCollection());
    }

    IEnumerator CheckStandCollection()
    {
        while (true)
        {
            if (collectCheckActive)
            {
                CheckBoxCount();
            }
            yield return new WaitForSeconds(3f);
        }
    }
    void CheckBoxCount()
    {
        if(stand.droppedCollectionList.Count > 0)
        {
            collectCheckActive = false;
            GoToBoxCollect();
        }
    }
    public void GoToBoxCollect()
    {
        aiMoving.GoTargetStart(boxCollectPos);
        aiMoving.BehaviourInit(GoToBoxDrop);
    }
    public void GoToBoxDrop()
    {
        aiMoving.GoTargetStart(boxDropPos);
        aiMoving.BehaviourInit(StackDrop);
    }
    public void StackDrop()
    {
        if (stackCollect.collectionTrs.Count > 0)
        {
            Collectable droppingCollection = stackCollect.collectionTrs[0];
            stackCollect.collectionTrs.Remove(droppingCollection);

            StartCoroutine(Drop(boxPos, droppingCollection));
        }
        else
        {
            GoToWaitPos();
        }
    }


    IEnumerator Drop(Transform dropPosTR, Collectable collectable)
    {
        fireGO.SetActive(true);
        tableAnim.SetTrigger("open");
        collectable.isCollected = false;

        //yield return new WaitForSeconds(waitTime);
        collectable.transform.parent = null;
        Vector3 firstPos = collectable.transform.position;
        Quaternion firstRot = collectable.transform.rotation;
        if (collectable.gameObject != null)
        {
            collectable.transform.parent = null;
            firstPos = collectable.transform.position;
            firstRot = collectable.transform.rotation;
        }

        float timeCounter = 0;
        float angle = 0f;
        float posY = 0f;
        float posY_Factor = 2f;
        timeCounter = 0f;


        Quaternion targetAngle = dropPosTR.rotation;

        while (timeCounter < 1f)
        {
            timeCounter += 4 * Time.deltaTime;
            angle = timeCounter * Mathf.PI;
            posY = posY_Factor * Mathf.Sin(angle);


            if (collectable.gameObject != null)
            {
                collectable.transform.position = Vector3.Lerp(firstPos, new Vector3(dropPosTR.position.x, dropPosTR.position.y + posY, dropPosTR.position.z), timeCounter);
                collectable.transform.rotation = Quaternion.Lerp(firstRot, targetAngle, timeCounter);
            }
            yield return null;
        }
        collectable.transform.position = dropPosTR.position;
        collectable.productCollectActive = true;
        collectable.transform.parent = dropPosTR;

        stand.DropMoney(collectable);


        stackCollect.CollectedListReset();
        GoToWaitPos();
        yield return new WaitForSeconds(1f);
        fireGO.SetActive(false);
        Destroy(collectable.gameObject);
    }

    void GoToWaitPos()
    {
        aiMoving.GoTargetStart(waitingPos);
        aiMoving.BehaviourInit(WaitAreaArrived);
    }
    public void WaitAreaArrived()
    {
        collectCheckActive = true;
    }
}

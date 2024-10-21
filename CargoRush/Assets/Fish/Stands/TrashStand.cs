using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashStand : Stand
{
    public Animator animator;
    [SerializeField] Transform trashTargetTR;
    public override void CollectableCountSet()
    {

    }

    public override void DropCollection(int collectAmount, StackCollect _stackCollect)
    {
        if (collectAmount > 0)
        {
            //VibratoManager.Instance.MediumMultiVibration();
            _stackCollect.collectActive = false;
        }
        _stackCollect.collectActive = false;
        StartCoroutine(DropSequantial(collectAmount, _stackCollect));
    }

    public override void SpecificReset()
    {

    }

    public override void SpecificStart()
    {
        foreach (var wrkArea in workAreaList)
        {
            wrkArea.standList.Add(this);
        }
        if (PlayerPrefs.GetInt("trashtutorial") == 0)
        {
            collectType = CollectType.Type1;
            collectType2 = CollectType.Type1;
        }
        else
        {
            collectType = CollectType.All;
            collectType2 = CollectType.All;
        }

    }

    IEnumerator DropSequantial(int collectAmount, StackCollect _stackCollect)
    {
        if (PlayerPrefs.GetInt("trashtutorial") == 2)
        {
            PlayerPrefs.SetInt("trashtutorial", 3);
            IndicatorManager.Instance.IndicaorDeActive();
            IndicatorManager.Instance.TutorialStepCompleted();
            collectType = CollectType.All;
            collectType2 = CollectType.All;
        }
        animator.SetBool("trashactive", true);

        yield return null;

        List<Collectable> droppingCollectionList = new List<Collectable>();

        int amount = collectAmount;
        int loopCount = _stackCollect.collectionTrs.Count;

        if (_stackCollect.GetComponent<StackCollectPlayer>() != null)
        {
            for (int i = 0; i < loopCount; i++)
            {
                droppingCollectionList.Add(_stackCollect.collectionTrs[i]);
            }
        }
        else
        {
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
        }

        for (int i = 0; i < droppingCollectionList.Count; i++)
        {
            droppingCollectionList[i].fishCollectable = droppedCollectionList;

            Collectable deletedCollect = droppingCollectionList[i];

            _stackCollect.collectionTrs.Remove(deletedCollect);
            Destroy(deletedCollect.gameObject,4f);
        }
        for (int i = 0; i < droppingCollectionList.Count; i++)
        {
            //droppedCollectionList.Add(droppingCollectionList[i]);

            Vector3 dropPos = trashTargetTR.position;
            StartCoroutine(Drop(trashTargetTR, dropPos, droppingCollectionList[i], i * 0.05f));
            if (_stackCollect.player)
            {
                VibratoManager.Instance.LightVibration();
            }
        }

        yield return new WaitForSeconds(0.5f);
        _stackCollect.collectActive = true;
        yield return new WaitForSeconds(2f);
        animator.SetBool("trashactive", false);
    }

    IEnumerator Drop(Transform dropPosTR, Vector3 dropPos, Collectable collectable, float waitTime)
    {
        fishCountCurrent++;
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
                collectable.transform.position = Vector3.Lerp(firstPos, new Vector3(dropPos.x, dropPos.y + posY, dropPos.z), timeCounter);
                collectable.transform.rotation = Quaternion.Lerp(firstRot, targetAngle, timeCounter);
            }
            yield return null;
        }
        collectable.transform.position = dropPos;
        collectable.productCollectActive = true;


    }
}

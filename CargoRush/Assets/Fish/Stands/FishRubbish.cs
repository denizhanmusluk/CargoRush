using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishRubbish : MonoBehaviour
{
    public Animator animator;
    public int collectID;
    public bool dropActive = true;
    public bool StandActive = false;
    public Transform fishPosTR;






    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && StandActive)
        {
            if (dropActive)
            {
                cooldowner = true;
                dropActive = false;
                StartCoroutine(CooldownActive(0.5f));
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && StandActive)
        {
            cooldowner = false;
            rubbishActive = false;
            dropActive = true;
            animator.SetBool("trashactive", false);
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && StandActive)
        {
            if (!dropActive && rubbishActive)
            {
                Debug.Log("collect check");

                CollectionChecking(other.GetComponent<PlayerController>()._stackCollect);
                dropActive = true;
            }
        }
    }

    void CollectionChecking(StackCollect _stackCollect)
    {

        int collectedNo = 0;
        foreach (var collects in _stackCollect.collectionTrs)
        {
          


            if (0 == collectID)
            {
                collectedNo++;

            }
            else if (collects.collectID == collectID)
            {
                collectedNo++;
                if (PlayerPrefs.GetInt("cabinetutorial") == 2)
                {
                    PlayerPrefs.SetInt("cabinetutorial", 3);
                    IndicatorManager.Instance.IndicaorDeActive();
                }
            }
        }

        _stackCollect.ReverseCollectedList();
        _stackCollect.CollectedListReset();

        if (collectedNo > 0)
        {
            DropCollection(collectID, collectedNo, _stackCollect);
        }
    }


    public void StandReActive()
    {
        StandActive = true;
        GetComponent<Collider>().enabled = true;
    }
    void Start()
    {
        StandReActive();
    }





    public void DropCollection(int collectID, int collectAmount, StackCollect _stackCollect)
    {
        //StartCoroutine(AnimatorSetter());
        if (collectAmount > 0)
        {
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
            //if (_stackCollect.collectionTrs[i].collectID == collectID && amount > 0)
            if (collectID == 0)
            {
                if (amount > 0)
                {
                    droppingCollectionList.Add(_stackCollect.collectionTrs[i]);

                    amount--;
                }
            }else if (_stackCollect.collectionTrs[i].collectID == collectID && amount > 0)
            {
                if (amount > 0)
                {
                    droppingCollectionList.Add(_stackCollect.collectionTrs[i]);

                    amount--;
                }
            }
        }


        for (int i = 0; i < droppingCollectionList.Count; i++)
        {
            Collectable deletedCollect = droppingCollectionList[i];

            _stackCollect.collectionTrs.Remove(deletedCollect);
        }
        for (int i = 0; i < droppingCollectionList.Count; i++)
        {

            Vector3 dropPos = fishPosTR.position;
            StartCoroutine(Drop(fishPosTR, dropPos, droppingCollectionList[i], i * 0.05f));

        }
        _stackCollect.collectActive = true;
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

        Destroy(collectable.gameObject);
    }


    bool cooldowner = false;
    bool rubbishActive = false;
    IEnumerator CooldownActive(float time)
    {
        cooldowner = true;
        rubbishActive = false;
        animator.SetTrigger("trashshake");
        float counter = 0f;
        while (counter < time && cooldowner)
        {
            counter += Time.deltaTime;
            yield return null;
        }
        if (counter >= time)
        {
            cooldowner = false;
            rubbishActive = true;
            animator.SetBool("trashactive", true);
            //StartCoroutine(CooldownPasive());
        }

    }
}

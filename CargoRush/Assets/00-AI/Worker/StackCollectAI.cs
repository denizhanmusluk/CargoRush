using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackCollectAI : MonoBehaviour
{
    public int stackCapacity;
    [Range(1.0f, 100.0f)]
    [SerializeField] float oscillationHalfLife = 10f;
    [SerializeField] float turnSpeed = 100f;

    [SerializeField] public List<Collectable> collectionTrs = new List<Collectable>();
    [SerializeField] float stackStepOffset;
    [SerializeField] AIWorker _aiWorker;
    bool stackFollowing = true;
    int currentStackCount = 0;
    public bool collectActive = true;
    bool scallingEffectActive = true;

    [Range(1.0f, 5.0f)]
    [SerializeField] float scaleRatio;
    [Range(1.0f, 10.0f)]
    [SerializeField] float scaleFrequency;

    [Range(1.0f, 30.0f)]
    [SerializeField] float scaleDamping;


    Vector3 firstSize;

    public void DisperseCollected(Transform impulseTR)
    {
        for (int i = 0; i < collectionTrs.Count; i++)
        {
            collectionTrs[i].transform.parent = null;
            collectionTrs[i].DisperseCollected(impulseTR);
        }
        currentStackCount = 0;
        collectionTrs.Clear();
    }
    public void Collecting(Collectable collectable)
    {
        if (collectActive)
        {
            firstSize = collectable.transform.localScale;
            collectable.collectActive = false;
            collectable.rotateActive = false;
            collectable.roofPushActive = false;
            collectionTrs.Add(collectable);
            //collectable.animator.SetTrigger("stop");
            currentStackCount = collectionTrs.Count;

            //_playerController.animator.SetBool("carrying", true);
            StartCoroutine(ComeToMe(collectable, currentStackCount - 1));

            if (scallingEffectActive)
            {
                StartCoroutine(scaleCalling());
            }
        }
    }
    public void ReverseCollectedList()
    {
        List<Collectable> tempCollectionList = new List<Collectable>();

        for (int i = 0; i < collectionTrs.Count; i++)
        {
            tempCollectionList.Add(collectionTrs[i]);
        }

        for (int i = 0; i < collectionTrs.Count; i++)
        {
            collectionTrs[i] = tempCollectionList[collectionTrs.Count - i - 1];
        }
        currentStackCount = collectionTrs.Count;
    }
    public void CollectedListReset()
    {
        ReverseCollectedList();
        StartCoroutine(ListPosReset());
    }

    IEnumerator ListPosReset()
    {
        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < collectionTrs.Count; i++)
        {
            StartCoroutine(CollectablePosReset(collectionTrs[i], i));
            yield return null;
        }
    }
    IEnumerator CollectablePosReset(Collectable collectable, int no)
    {
        Vector3 firstPos = collectable.transform.position;
        Quaternion firstRot = collectable.transform.rotation;
        float timeCounter = 0;

        while (timeCounter < 1f)
        {
            timeCounter += 4 * Time.deltaTime;
            collectable.transform.position = Vector3.Lerp(firstPos, transform.position + new Vector3(0, stackStepOffset * no, 0), timeCounter);
            collectable.transform.rotation = Quaternion.Lerp(firstRot, transform.rotation, timeCounter);

            yield return null;
        }
    }
    public void DropCollection(Transform targetPosTR, int collectID, int collectAmount)
    {
        if (collectAmount > 0)
        {
            VibratoManager.Instance.MediumMultiVibration();
            collectActive = false;
        }
        StartCoroutine(DropSequantial(targetPosTR, collectID, collectAmount));
    }
    IEnumerator DropSequantial(Transform targetPosTR, int collectID, int collectAmount)
    {
        yield return null;

        List<Collectable> deleteCollectionList = new List<Collectable>();

        int amount = collectAmount;
        int loopCount = collectionTrs.Count;
        for (int i = 0; i < loopCount; i++)
        {
            if (collectionTrs[i].collectID == collectID && amount > 0)
            {
                deleteCollectionList.Add(collectionTrs[i]);

                amount--;
            }
        }


        for (int i = 0; i < deleteCollectionList.Count; i++)
        {
            Collectable deletedCollect = deleteCollectionList[i];

            collectionTrs.Remove(deletedCollect);
            //Destroy(deletedCollect.gameObject,4f);
        }
        for (int i = 0; i < deleteCollectionList.Count; i++)
        {
            StartCoroutine(Drop(targetPosTR, deleteCollectionList[i]));

            yield return null;
        }

        if (collectionTrs.Count == 0)
        {
            //_playerController.animator.SetBool("carrying", false);
        }
        collectActive = true;
    }
    IEnumerator Drop(Transform dropPosTR, Collectable collectable)
    {
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
        while (timeCounter < 1f)
        {
            timeCounter += 4 * Time.deltaTime;
            if (collectable.gameObject != null)
            {
                collectable.transform.position = Vector3.Lerp(firstPos, dropPosTR.position, timeCounter);
                collectable.transform.rotation = Quaternion.Lerp(firstRot, dropPosTR.rotation, timeCounter);
            }
            else
            {
                Debug.Log("NULLLLLLLLLL");
            }
            yield return null;
        }
        if (collectable.gameObject != null)
        {
            //collectable.gameObject.SetActive(false);
        }
    }

    private IEnumerator ComeToMe(Collectable collectable, int _currentStackCount)
    {
        Vector3 firstPos = collectable.transform.position;
        Quaternion firstRot = collectable.transform.rotation;

        float timeCounter = 0;
        Vector3 tempPosition = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 1f) + stackStepOffset * _currentStackCount, Random.Range(-0.5f, 0.5f));
        Quaternion tempAngle = Quaternion.Euler(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180));
        Quaternion targetAngle = Quaternion.Euler(0, Random.Range(-15, 15), 0);
        while (timeCounter < 1f)
        {
            timeCounter += 4 * Time.deltaTime;



            collectable.transform.position = Vector3.Lerp(firstPos, transform.position + tempPosition, timeCounter);
            collectable.transform.rotation = Quaternion.Lerp(firstRot, tempAngle, timeCounter);

            yield return null;
        }
        firstPos = collectable.transform.position;
        firstRot = collectable.transform.rotation;
        Vector3 targetPos = new Vector3(0, stackStepOffset * _currentStackCount, 0);
        yield return new WaitForSeconds(0.1f);
        timeCounter = 0f;
        while (timeCounter < 1f)
        {
            timeCounter += 4 * Time.deltaTime;
            collectable.transform.position = Vector3.Lerp(firstPos, transform.position + targetPos, timeCounter);
            collectable.transform.localRotation = Quaternion.Lerp(firstRot, targetAngle, timeCounter);

            yield return null;
        }
    }

    void LateUpdate()
    {

        if (collectionTrs.Count > 0)
        {
            if (collectionTrs[0] == null)
            {
                collectionTrs.Remove(collectionTrs[0]);
            }
            followObj(transform, collectionTrs[0].transform, 0f);
        }
        for (int i = 0; i < collectionTrs.Count - 1; i++)
        {
            if (collectionTrs[i] == null)
            {
                collectionTrs.Remove(collectionTrs[i]);
            }
            if (collectionTrs[i + 1] == null)
            {
                collectionTrs.Remove(collectionTrs[i + 1]);
            }
            followObj(collectionTrs[i].transform, collectionTrs[i + 1].transform, i);
        }

    }
    float counter = 0.5f;
    Vector3 distance = Vector3.zero;
    void followObj(Transform obj1, Transform obj2, float multiply)
    {
        Vector3 targetPos = obj1.position;
        float followSpeed = (0.4f * Vector3.Distance(obj2.position, obj1.position) + 1.5f) * _aiWorker.AImoveSpeed;

        float extraSpeed = 1f;
        Vector3 factor = Vector3.zero;
        if (PlayerController.Instance.pressJoystick)
        {
            distance = -(obj2.position - obj1.position).normalized;
            counter = 0.5f;
        }
        else
        {
            extraSpeed += multiply;
            extraSpeed *= 0.25f;
            counter -= 0.2f * Time.deltaTime;
            if (counter <= 0)
            {
                counter = 0;
            }
            factor = distance * 0.25f;
            if (counter < 0.3f)
            {
                factor = -distance * 0.25f;

            }
            factor *= counter;
            factor.y = 0;
        }
        Vector3 followPosition = new Vector3(targetPos.x, obj2.position.y, targetPos.z) + factor;

        obj2.position = Vector3.MoveTowards(obj2.position, followPosition, (followSpeed - (0.1f * multiply)) * oscillationHalfLife * 0.1f * Time.deltaTime * extraSpeed);

        float deltaRotY = Quaternion.Angle(obj2.rotation, obj1.rotation);

        if (deltaRotY > 10)
        {
            deltaRotY *= 2;
        }
        obj2.rotation = Quaternion.RotateTowards(obj2.rotation, obj1.rotation, Mathf.Abs(deltaRotY) * turnSpeed * Time.deltaTime);
        //obj2.LookAt(Camera.main.transform);
    }


    IEnumerator scaleCalling()
    {
        int stackCount = collectionTrs.Count;
        for (int i = 0; i < collectionTrs.Count; i++)
        {
            StartCoroutine(throughlyScaling(collectionTrs[collectionTrs.Count - 1 - i].transform));
            yield return new WaitForSeconds(0.1f / scaleFrequency);
        }
    }
    IEnumerator throughlyScaling(Transform Tr)
    {
        float counter = 0f;
        float sizeDelta;
        while (counter < Mathf.PI)
        {
            counter += scaleDamping * Time.deltaTime;
            sizeDelta = (scaleRatio - 1) * (1f - Mathf.Abs(Mathf.Cos(counter)));
            if (Tr != null)
                Tr.localScale = firstSize + Vector3.one * sizeDelta;

            yield return null;
        }
        if (Tr != null)
            Tr.localScale = firstSize;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (Globals.stackActive && other.GetComponent<Collectable>() != null && other.GetComponent<Collectable>().collectActive)
        {
            if (collectionTrs.Count < stackCapacity)
            {
                Collecting(other.GetComponent<Collectable>());
            }
        }
    }
}
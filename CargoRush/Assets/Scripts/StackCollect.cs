using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DitzelGames.FastIK;

[System.Serializable]
public abstract class StackCollect : MonoBehaviour
{
    [Range(1.0f, 100.0f)]
    [SerializeField] float oscillationHalfLife = 10f;
    [SerializeField] float elasticRatio = 0.1f;
    [SerializeField] float turnSpeed = 100f;

    [SerializeField] public List<Collectable> collectionTrs = new List<Collectable>();
    [SerializeField] float stackStepOffset;
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

    public Transform[] stackLevel_1_PosList;
    public List<Transform> stackLevel_2_PosList;
    public Transform[] stackLevel_3_PosList;
    public int stackLevel = 0;
    public bool player;
    public FastIKFabric ikLeft;
    public FastIKFabric ikRight;

    public Transform leftIkTarget;
    public Transform rightIkTarget;

    public Transform leftProductTarget;
    public Transform rightProductTarget;

    public Transform leftBoxTarget;
    public Transform rightBoxTarget;

    public Transform leftNullTarget;
    public Transform rightNullTarget;
    public abstract void StackAnimation();
    public abstract void StackEmptyAnimation();

    public abstract float StackFollowSpeed();
    private void Start()
    {
        if (stackLevel > 0)
        {
            StackAnimation();
        }
    }
    public void DisperseCollected(Transform impulseTR)
    {
        if (disperseActive)
        {
            List<Collectable> tempColList = new List<Collectable>();

            for (int i = 0; i < collectionTrs.Count; i++)
            {
                if (collectionTrs[i].collectID == 0)
                {
                    currentStackCount--;
                    collectionTrs[i].transform.parent = null;
                    collectionTrs[i].DisperseCollected(impulseTR);
                    tempColList.Add(collectionTrs[i]);
                }
            }

            for (int i = 0; i < tempColList.Count; i++)
            {
                collectionTrs.Remove(tempColList[i]);
            }
            //currentStackCount = 0;
            //collectionTrs.Clear();

            if (collectionTrs.Count == 0)
            {
                StackEmptyAnimation();
            }
            StartCoroutine(DisperseActivator());
            StackFullCheck();

        }
    }
    bool disperseActive = true;
    IEnumerator DisperseActivator()
    {
        disperseActive = false;
        yield return new WaitForSeconds(1f);
        disperseActive = true;
    }
    public void CollectionsNullParent()
    {
        foreach(Collectable clt in collectionTrs)
        {
            clt.transform.parent = null;
        }
    }
    public void Collecting(Collectable collectable)
    {
        if (collectActive)
        {
            if (collectable.collectID == 0)
            {
                if (PlayerPrefs.GetInt("collectablecount" ) < IndicatorManager.Instance.productCountForTutorial)
                {
                    PlayerPrefs.SetInt("collectablecount", PlayerPrefs.GetInt("collectablecount") + 1);

                    IndicatorManager.Instance.gemCounter.gameObject.SetActive(true);
                    IndicatorManager.Instance.GemCounter(PlayerPrefs.GetInt("collectablecount"));

                    if (PlayerPrefs.GetInt("collectablecount") == IndicatorManager.Instance.productCountForTutorial)
                    {
                        IndicatorManager.Instance.gemCounter.gameObject.SetActive(false);
                        IndicatorManager.Instance.IndicatorTargeterActive();
                        //PlayerPrefs.GetInt("collectsection2", 1);
                    }
                }
         
            }
            if (collectable.collectID == 1)
            {

                if (PlayerPrefs.GetInt("collectablecount2") < IndicatorManager.Instance.boxCountForTutorial)
                {
                    PlayerPrefs.SetInt("collectablecount2", PlayerPrefs.GetInt("collectablecount2") + 1);

                    IndicatorManager.Instance.gemCounter2.gameObject.SetActive(true);
                    IndicatorManager.Instance.GemCounter2(PlayerPrefs.GetInt("collectablecount2"));

                    if (PlayerPrefs.GetInt("collectablecount2") == IndicatorManager.Instance.boxCountForTutorial)
                    {
                        IndicatorManager.Instance.gemCounter2.gameObject.SetActive(false);
                        IndicatorManager.Instance.IndicatorTargeterActive();
                    }
                }
                collectable.box.SetActive(false);
                collectable.boxSinglePart.SetActive(true);
            }

            if (collectable.collectID == 11)
            {

                if (PlayerPrefs.GetInt("collectablecount3") < IndicatorManager.Instance.boxpackCountForTutorial)
                {
                    PlayerPrefs.SetInt("collectablecount3", PlayerPrefs.GetInt("collectablecount3") + 1);

                    IndicatorManager.Instance.boxPackCounter.gameObject.SetActive(true);
                    IndicatorManager.Instance.BoxCounter(PlayerPrefs.GetInt("collectablecount3"));

                    if (PlayerPrefs.GetInt("collectablecount3") == IndicatorManager.Instance.boxpackCountForTutorial)
                    {
                        IndicatorManager.Instance.boxPackCounter.gameObject.SetActive(false);
                        IndicatorManager.Instance.IndicatorTargeterActive();
                    }
                }

            }
            collectable.transform.parent = null;
            //firstSize = collectable.transform.localScale;
            collectable.collectActive = false;
            collectable.rotateActive = false;
            collectable.roofPushActive = false;
            collectionTrs.Add(collectable);
            StackFullCheck();

            currentStackCount = collectionTrs.Count;
            StackAnimation();

            if (stackLevel == 0)
            {
                if(collectionTrs[0].collectID == 0)
                {
                    stackStepOffset = 0.5f;
                    stackLevel_1_PosList[0].localPosition = new Vector3(stackLevel_1_PosList[0].localPosition.x, stackLevel_1_PosList[0].localPosition.y, -0.2f);
                }
                else
                {
                    stackStepOffset = 1.25f;
                    stackLevel_1_PosList[0].localPosition = new Vector3(stackLevel_1_PosList[0].localPosition.x, stackLevel_1_PosList[0].localPosition.y, 0.1f);
                }

                Transform targetTR = stackLevel_1_PosList[(collectionTrs.Count - 1) % stackLevel_1_PosList.Length];

                float deltaY = 0;
                deltaY = (collectionTrs.Count - 1) / stackLevel_1_PosList.Length;

                StartCoroutine(ComeToMe(collectable, targetTR, deltaY,false));
            }

            if (stackLevel == 1)
            {
                if (collectionTrs[0].collectID == 0)
                {
                    stackStepOffset = 0.5f;
                }
                else
                {
                    stackStepOffset = 1.25f;
                }
                Transform targetTR = stackLevel_2_PosList[(collectionTrs.Count - 1) % stackLevel_2_PosList.Count];

                float deltaY = 0;
                deltaY = (collectionTrs.Count - 1) / stackLevel_2_PosList.Count;
                //collectable.transform.parent = stackLevel_2_PosList[0];
                StartCoroutine(ComeToMe(collectable,  targetTR, deltaY,true));
            }

            if (stackLevel == 2)
            {
                Transform targetTR = stackLevel_3_PosList[(collectionTrs.Count - 1) % stackLevel_3_PosList.Length];

                float deltaY = 0;
                deltaY = (collectionTrs.Count - 1) / stackLevel_3_PosList.Length;
                //collectable.transform.parent = stackLevel_3_PosList[0];

                StartCoroutine(ComeToMe(collectable,  targetTR, deltaY, true));
            }
            //if (collectable.collectID == 0)
            {
                collectable.fishCollectable.Remove(collectable);
            }
            //if (scallingEffectActive)
            //{
            //    scallingEffectActive = false;
            //    StartCoroutine(ScaleCalling());
            //}
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
        if(currentStackCount == 0)
        {
            if (stackLevel == 0)
            {
                StackEmptyAnimation();
            }
            if(GetComponent<StackCollectPlayer>() != null)
            {
                StackEmptyAnimation();
            }
        }
        StackFullCheck();

    }
    public void CollectedListReset()
    {
        ReverseCollectedList();
        StartCoroutine(ListPosReset(false));
    }
    public void CollectedListResetLevelUp()
    {
        ReverseCollectedList();
        StartCoroutine(ListPosReset(true));
    }
    IEnumerator ListPosReset(bool parentActive)
    {
        yield return new WaitForSeconds(0.1f);
        if (collectionTrs.Count == 0)
        {
            if (stackLevel == 0)
            {
                StackEmptyAnimation();
            }
        }
        StackFullCheck();

        yield return new WaitForSeconds(0.2f);
      
        for (int i = 0; i < collectionTrs.Count; i++)
        {


            if (stackLevel == 0)
            {
                Transform targetTR = stackLevel_1_PosList[(i) % stackLevel_1_PosList.Length];

                float deltaY = 0;
                deltaY = (i) / stackLevel_1_PosList.Length;
                StartCoroutine(CollectablePosReset(collectionTrs[i], targetTR, deltaY,false));

                //StartCoroutine(ComeToMe(collectable, dropPos));
            }

            if (stackLevel == 1)
            {
                Transform targetTR = stackLevel_2_PosList[(i) % stackLevel_2_PosList.Count];

                float deltaY = 0;
                deltaY = (i) / stackLevel_2_PosList.Count;

                //collectionTrs[i].transform.parent = stackLevel_2_PosList[0];
                StartCoroutine(CollectablePosReset(collectionTrs[i], targetTR, deltaY, true));

                //StartCoroutine(ComeToMe(collectable, dropPos));
            }

            if (stackLevel == 2)
            {
                Transform targetTR = stackLevel_3_PosList[(i) % stackLevel_3_PosList.Length];

                float deltaY = 0;
                deltaY = (i) / stackLevel_3_PosList.Length;
                //collectionTrs[i].transform.parent = stackLevel_3_PosList[0];

                StartCoroutine(CollectablePosReset(collectionTrs[i], targetTR, deltaY, parentActive));

                //StartCoroutine(ComeToMe(collectable, dropPos));
            }


            yield return null;
        }
    }
    IEnumerator CollectablePosReset(Collectable collectable, Transform targetTR, float deltaY, bool parentActive)
    {
        Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * stackStepOffset, 0);

        Vector3 firstPos = collectable.transform.position;
        Quaternion firstRot = collectable.transform.rotation;
        float timeCounter = 0;

        while (timeCounter < 1f)
        {
            timeCounter += 4 * Time.deltaTime;
            firstPos = collectable.transform.position;
            firstRot = collectable.transform.rotation;
            dropPos = targetTR.position + new Vector3(0, deltaY * stackStepOffset, 0);
            collectable.transform.position = Vector3.Lerp(firstPos, dropPos, timeCounter);
            collectable.transform.rotation = Quaternion.Lerp(firstRot, targetTR.rotation, timeCounter);

            yield return null;
        }
        collectable.transform.position = dropPos;
        if (parentActive)
        {
            collectable.transform.parent = targetTR;
            collectable.transform.localRotation = Quaternion.identity;
            collectable.transform.localPosition = new Vector3(0, collectable.transform.localPosition.y, 0);
        }

    }
    // // // // //
    #region Dropping Functions

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
   

        for (int i = 0; i < deleteCollectionList.Count;i++)
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
    #endregion

    // // // // //

    private IEnumerator ComeToMe(Collectable collectable, Transform targetTR, float deltaY, bool parentActive)
    {
        collectable.stackFollowingActive = false;

        collectable.InitNormalMaterial();
        collectable.isCollected = true;
        //foreach (var anim in collectable.GetComponentsInChildren<Animator>())
        //{
        //    anim.enabled = false;
        //}
    
        if (collectable.GetComponent<BigFish>() != null)
        {
            IndicatorManager.Instance.IndicaorActive(collectable.GetComponent<BigFish>().bigAquarium.indicatorPosTR);
        }
        Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * stackStepOffset, 0);

        Vector3 firstPos = collectable.transform.position;
        Quaternion firstRot = collectable.transform.rotation;

        float timeCounter = 0;
        //Vector3 tempPosition = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 1f) + stackStepOffset * _currentStackCount, Random.Range(-0.5f, 0.5f));
        //Quaternion tempAngle = Quaternion.Euler(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180));
        Quaternion targetAngle = Quaternion.Euler(0, Random.Range(-15, 15), 0);
        //while (timeCounter < 1f)
        //{
        //    timeCounter += 4 * Time.deltaTime;



        //    collectable.transform.position = Vector3.Lerp(firstPos, transform.position + tempPosition, timeCounter);
        //    collectable.transform.rotation = Quaternion.Lerp(firstRot, tempAngle, timeCounter);

        //    yield return null;
        //}
        //firstPos = collectable.transform.position;
        //firstRot = collectable.transform.rotation;

        if (player)
        {
            VibratoManager.Instance.LightVibration();
            AudioManager.Instance.StackTakeSound();
        }


        //Vector3 targetPos = new Vector3(0, stackStepOffset * _currentStackCount, 0);
        //Vector3 dropPos = stackLevel_1_PosList[0].position + targetPos;

        float angle = 0f;
        float posY = 0f;
        float posY_Factor = 4f;
        timeCounter = 0f;
        while (timeCounter < 1f)
        {
            timeCounter += 2 * Time.deltaTime;
            angle = timeCounter * Mathf.PI;
            posY = posY_Factor * Mathf.Sin(angle);

            dropPos = targetTR.position + new Vector3(0, deltaY * stackStepOffset, 0);
            collectable.transform.position = Vector3.Lerp(firstPos,new Vector3(dropPos.x, dropPos.y+ posY, dropPos.z), timeCounter);
            collectable.transform.localRotation = Quaternion.Lerp(firstRot, targetAngle, timeCounter);

            yield return null;
        }
        dropPos = targetTR.position + new Vector3(0, deltaY * stackStepOffset, 0);
        collectable.transform.position = dropPos;
        collectable.transform.localRotation = targetAngle;
        if (parentActive)
        {
            collectable.transform.parent = targetTR;
            //collectable.transform.localPosition = Vector3.zero;
            collectable.transform.localRotation = Quaternion.identity;
        }
        collectable.stackFollowingActive = true;


    }

    void LateUpdate()
    {
        if (stackLevel == 0)
        {
            if (collectionTrs.Count > 0)
            {
                if (collectionTrs[0] == null)
                {
                    collectionTrs.Remove(collectionTrs[0]);
                }
                if (collectionTrs[0].stackFollowingActive)
                {
                    followObj(stackLevel_1_PosList[0], collectionTrs[0].transform, 0f);
                }
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
                if (collectionTrs[i].stackFollowingActive)
                {
                    followObj(collectionTrs[i].transform, collectionTrs[i + 1].transform, i);
                }
            }
        }
    }
    float counter = 0.5f;
    Vector3 distance = Vector3.zero;

    void followObj(Transform obj1, Transform obj2, float multiply)
    {
        float angleFactor;
        if ((int)multiply % 2 == 0)
        {
            angleFactor = 10f;
        }
        else
        {
            angleFactor = -10f;
        }
        Vector3 targetPos = stackLevel_1_PosList[0].position;
        if (player == true)
        {
            if (PlayerController.Instance.pressJoystick)
            {
                targetPos = stackLevel_1_PosList[0].position - transform.forward * elasticRatio * multiply * multiply;
            }
        }
        //Vector3 targetPos = obj1.position;
        float followSpeed = (1f * Vector3.Distance(obj2.position, obj1.position) + 1.5f) * StackFollowSpeed();



        float extraSpeed = 1f;
        Vector3 factor = Vector3.zero;
        distance = -(obj2.position - obj1.position).normalized;
        counter = 0.5f;

        Vector3 followPosition = new Vector3(targetPos.x, obj2.position.y, targetPos.z) + factor;

        obj2.position = Vector3.MoveTowards(obj2.position, followPosition, followSpeed * oscillationHalfLife * 0.1f * Time.deltaTime * extraSpeed);
        //obj2.position = Vector3.MoveTowards(obj2.position, followPosition, (followSpeed - (0.1f * multiply)) * oscillationHalfLife * 0.1f * Time.deltaTime * extraSpeed - multiply * elasticRatio);

        float deltaRotY = Quaternion.Angle(obj2.rotation, obj1.rotation);

        if (deltaRotY > 10)
        {
            deltaRotY *= 2;
        }
        Quaternion targetRot = Quaternion.Euler(obj1.eulerAngles.x, obj1.eulerAngles.y + angleFactor, obj1.eulerAngles.z);
        obj2.rotation = Quaternion.RotateTowards(obj2.rotation, targetRot, Mathf.Abs(deltaRotY) * turnSpeed * Time.deltaTime);
        //obj2.LookAt(Camera.main.transform);
    }

    void followObjYedek(Transform obj1, Transform obj2, float multiply)
    {
        float angleFactor;
        if((int)multiply % 2 == 0)
        {
            angleFactor = 10f;
        }
        else
        {
            angleFactor = -10f;
        }
        Vector3 targetPos = obj1.position;
        float followSpeed = (0.4f * Vector3.Distance(obj2.position, obj1.position) + 1.5f) * StackFollowSpeed();


        float extraSpeed = 1f;
        Vector3 factor = Vector3.zero;
        distance = -(obj2.position - obj1.position).normalized;
        counter = 0.5f;
   
        Vector3 followPosition = new Vector3(targetPos.x, obj2.position.y, targetPos.z) + factor;

        obj2.position = Vector3.MoveTowards(obj2.position, followPosition, (followSpeed - (0.1f * multiply)) * oscillationHalfLife * 0.1f * Time.deltaTime * extraSpeed);

        float deltaRotY = Quaternion.Angle(obj2.rotation, obj1.rotation);

        if (deltaRotY > 10)
        {
            deltaRotY *= 2;
        }
        Quaternion targetRot = Quaternion.Euler(obj1.eulerAngles.x, obj1.eulerAngles.y + angleFactor, obj1.eulerAngles.z);
        obj2.rotation = Quaternion.RotateTowards(obj2.rotation, targetRot, Mathf.Abs(deltaRotY) * turnSpeed * Time.deltaTime);
        //obj2.LookAt(Camera.main.transform);
    }


    IEnumerator ScaleCalling()
    {
        int stackCount = collectionTrs.Count;
        for (int i = 0; i < collectionTrs.Count; i++)
        {
            StartCoroutine(ThroughlyScaling(collectionTrs[collectionTrs.Count - 1 - i]));
            yield return new WaitForSeconds(0.1f / scaleFrequency);
        }
        yield return new WaitForSeconds(0.5f);
        scallingEffectActive = true;
    }
    IEnumerator ThroughlyScaling(Collectable Collect)
    {
        float counter = 0f;
        float sizeDelta;
        while (counter < Mathf.PI)
        {
            counter += scaleDamping * Time.deltaTime;
            sizeDelta = (scaleRatio - 1) * (1f - Mathf.Abs(Mathf.Cos(counter)));
            if (Collect.transform != null)
                Collect.transform.localScale = Collect.firstSize + Vector3.one * sizeDelta;

            yield return null;
        }
        if (Collect.transform != null)
            Collect.transform.localScale = Collect.firstSize;
    }

    public void StackFullCheck()
    {
        if (player == true)
        {
            if (collectionTrs.Count > 0 && collectionTrs[0].collectID != 20 && Globals.stackFactor * PlayerController.Instance._characterUpgradeSettings.stackCapacity[Globals.stackCapacityLevel] + Globals.extraStack + Globals.extraStackSkin + Globals.trainExtraStack == collectionTrs.Count)
            {
                PlayerController.Instance.fullTextGO.SetActive(true);
            }
            else
            {
                PlayerController.Instance.fullTextGO.SetActive(false);
            }
        }
    }

    public void RemoveAll()
    {
        for(int i = 0; i < collectionTrs.Count; i++)
        {
            Destroy(collectionTrs[i].gameObject);
        }
        collectionTrs.Clear();
        StackEmptyAnimation();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
public class MineCrusher : Stand, IStandUpgrade
{
    [SerializeField] Transform inTR, convertTR, outTR;
    public Collectable[] productsPrefab;
    public Transform[] fishPosTR;


    public Transform[] ironProductPosTR;
    public Transform[] plasticProductPosTR;
    public Transform[] yarnProductPosTR;
    public Transform[] woodProductPosTR;

    public float iron_garbage_count = 0;
    public float plastic_garbage_count = 0;
    public float yarn_garbage_count = 0;
    public float wood_garbage_count = 0;

    public float iron_garbage_Precount = 0;
    public float plastic_garbage_Precount = 0;
    public float yarn_garbage_Precount = 0;
    public float wood_garbage_Precount = 0;
    //public Transform[] cannedFishPosTR;

    public List<Collectable> ironCollectionList = new List<Collectable>();
    public List<Collectable> plasticCollectionList = new List<Collectable>();

    public List<Collectable> yarnCollectionList = new List<Collectable>();
    public List<Collectable> woodCollectionList = new List<Collectable>();



    //public List<Collectable> woodCollectionList = new List<Collectable>();
    //public List<Collectable> plasticCollectionList = new List<Collectable>();
    //public List<Collectable> ironCollectionList = new List<Collectable>();
    //public List<Collectable> cannedCollectionList = new List<Collectable>();

    [SerializeField] List<CollectProduct> _CollectProducts;
    [SerializeField] List<GameObject> kizakListGO = new List<GameObject>();
    [SerializeField] List<GameObject> rawimgListGO = new List<GameObject>();
    //[SerializeField] CollectProduct _CollectProduct;
    [SerializeField] Animator machineAnimator;
    [SerializeField] CollectProduct _CollectProductRaf;
    [SerializeField] GameObject crushParticle;

    [SerializeField] GameObject fullTextGO;
    bool areaOpener_1 = true;
    bool areaOpener_2 = true;
    bool areaOpener_3 = true;
    bool areaOpener_4 = true;
    public int rawLevel;



    public int standLevel { get; set; }


    float speedFactor = 1f;
    private void Awake()
    {
        //Globals.collectableLevel = 0;
    }
    public override void CollectableCountSet()
    {
        PlayerPrefs.SetInt(machineName + "col1" + PlayerPrefs.GetInt("level"), ironCollectionList.Count);
        PlayerPrefs.SetInt(machineName + "col2" + PlayerPrefs.GetInt("level"), plasticCollectionList.Count);
        PlayerPrefs.SetInt(machineName + "col3" + PlayerPrefs.GetInt("level"), yarnCollectionList.Count);
        PlayerPrefs.SetInt(machineName + "col4" + PlayerPrefs.GetInt("level"), woodCollectionList.Count);
        ProductFullCheck();
    }

    public override void SpecificStart()
    {
        IndicatorManager.Instance.machines.Add(this);

        //PlayerPrefs.SetInt("rawlevel", rawLevel);
        _CollectProducts[0].collectables = ironCollectionList;
        _CollectProducts[1].collectables = plasticCollectionList;
        _CollectProducts[2].collectables = yarnCollectionList;
        _CollectProducts[3].collectables = woodCollectionList;


        //_CollectProduct.collectables = cannedCollectionList;
        //StandManager.Instance.standList.Add(this);
        foreach (var wrkArea in workAreaList)
        {
            wrkArea.standList.Add(this);

            for(int i = 0; i < _CollectProducts.Count;i++)
            {
                wrkArea.CollectProductList.Add(_CollectProducts[i]);
            }
            //for (int i = 0; i < wrkArea.CollectProductID.Count; i++)
            //{
            //    wrkArea.CollectProductList.Add(_CollectProducts[wrkArea.CollectProductID[i]]);
            //}
        }

        StandReActive();
        FishCountInit();
        //_CollectProductRaf.machineActive = true;
        StartCoroutine(CreatorChecking());


        ManuealRawCreate();
        CapacityInit();
    }

    void FishCountInit()
    {
        //FishManager.Instance.fishCount[1] += fishCountTotal * 2;
    }
    public override void SpecificReset()
    {
        //ResetStand();
    }
    bool creatingActive = false;
    void MachineActive()
    {
        machineAnimator.SetBool("crush", true);
        crushParticle.SetActive(true);
        machineActive = true;
    }
    void MachineStop()
    {
        machineAnimator.SetBool("crush", false);
        crushParticle.SetActive(false);
        machineActive = false;
    }
    IEnumerator CreatorChecking()
    {

        creatingActive = false;
        while (!creatingActive)
        {
            MinesDropAreaCheck();

            if (cannedCount < productCountTotal * areaCount)
            {
                //yield return new WaitForSeconds(0.1f);
                creatingActive = true;

                StartCoroutine(CannedCreator());
                fullTextGO.SetActive(false);
            }
            else
            {
                fullTextGO.SetActive(true);
            }
            if (!creatingActive)
            {

                foreach (var lst in ironCollectionList)
                {
                    lst.productCollectActive = true;
                }

                foreach (var lst in plasticCollectionList)
                {
                    lst.productCollectActive = true;
                }
               
                foreach (var lst in yarnCollectionList)
                {
                    lst.productCollectActive = true;
                }
                foreach (var lst in woodCollectionList)
                {
                    lst.productCollectActive = true;
                }
            }
            yield return new WaitForSeconds(0.1f);
        }
    }

    //public void CannedCountSet()
    //{
    //    cannedCount = cannedCollectionList.Count;
    //}
    [SerializeField] List<Transform> L2list;
    [SerializeField] List<Transform> L3list;
    [SerializeField] List<Transform> L4list;
    [SerializeField] List<Transform> L5list;

    int areaCount = 1;
    void MinesDropAreaCheck()
    {
        if (Globals.collectableLevel >= 1)
        {
            if (areaOpener_1)
            {
                areaCount = 2;
                areaOpener_1 = false;
                rawimgListGO[0].SetActive(true);
                rawimgListGO[1].SetActive(true);
                kizakListGO[0].SetActive(true);
                kizakListGO[1].SetActive(true);
                _CollectProducts[0].gameObject.SetActive(true);
                _CollectProducts[1].gameObject.SetActive(true);
                //_CollectProducts[0].transform.position = L2list[0].position;
                //_CollectProducts[1].transform.position = L2list[1].position;
                //fishCountTotal += 25;
                //fishCountCurrent += 25;
                fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();

            }
        }
        if (Globals.collectableLevel >= 2)
        {
            if (areaOpener_2)
            {
                areaCount = 3;
                areaOpener_2 = false;
                rawimgListGO[0].SetActive(true);
                rawimgListGO[1].SetActive(true);
                rawimgListGO[2].SetActive(true);
                kizakListGO[0].SetActive(true);
                kizakListGO[1].SetActive(true);
                kizakListGO[2].SetActive(true);
                _CollectProducts[0].gameObject.SetActive(true);
                _CollectProducts[1].gameObject.SetActive(true);
                _CollectProducts[2].gameObject.SetActive(true);
                //_CollectProducts[0].transform.position = L3list[0].position;
                //_CollectProducts[1].transform.position = L3list[1].position;
                //_CollectProducts[2].transform.position = L3list[2].position;
                //fishCountTotal += 25;
                //fishCountCurrent += 25;
                fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();
            }
        }

        if (Globals.collectableLevel >= 3)
        {
            if (areaOpener_3)
            {
                areaCount = 4;
                areaOpener_3 = false;
                rawimgListGO[0].SetActive(true);
                rawimgListGO[1].SetActive(true);
                rawimgListGO[2].SetActive(true);
                rawimgListGO[3].SetActive(true);
                kizakListGO[0].SetActive(true);
                kizakListGO[1].SetActive(true);
                kizakListGO[2].SetActive(true);
                kizakListGO[3].SetActive(true);
                _CollectProducts[0].gameObject.SetActive(true);
                _CollectProducts[1].gameObject.SetActive(true);
                _CollectProducts[2].gameObject.SetActive(true);
                _CollectProducts[3].gameObject.SetActive(true);
                //_CollectProducts[0].transform.position = L4list[0].position;
                //_CollectProducts[1].transform.position = L4list[1].position;
                //_CollectProducts[2].transform.position = L4list[2].position;
                //_CollectProducts[3].transform.position = L4list[3].position;
                //fishCountTotal += 50;
                //fishCountCurrent += 50;
                fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();
            }
        }


        if (PlayerPrefs.GetInt("rawlevel" + PlayerPrefs.GetInt("level")) == 4)
        {
            if (areaOpener_4)
            {
                areaOpener_4 = false;
                _CollectProducts[0].gameObject.SetActive(true);
                _CollectProducts[1].gameObject.SetActive(true);
                _CollectProducts[2].gameObject.SetActive(true);
                _CollectProducts[3].gameObject.SetActive(true);
                _CollectProducts[4].gameObject.SetActive(true);

                //_CollectProducts[0].transform.position = L5list[0].position;
                //_CollectProducts[1].transform.position = L5list[1].position;
                //_CollectProducts[2].transform.position = L5list[2].position;
                //_CollectProducts[3].transform.position = L5list[3].position;
                //_CollectProducts[4].transform.position = L5list[4].position;
            }
        }
    }
    IEnumerator CannedCreator()
    {
        MinesDropAreaCheck();

        yield return new WaitForSeconds(0.1f);
        if (droppedCollectionList.Count > 0 && cannedCount < areaCount * productCountTotal)
        {
            MachineActive();
        }

        //float waitTime = 1f;
        while (droppedCollectionList.Count > 0 && cannedCount < areaCount * productCountTotal)
        {
            if (PlayerPrefs.GetInt("tutorialcompleted") == 0)
            {
                speedFactor2 = 3f;
            }
            else
            {
                speedFactor2 = 1f;
            }

            MinesDropAreaCheck();

            //machineActive = true;
            //creatingActive = true;

            Collectable fish;
            OrderId();

            fish = droppedCollectionList[droppedCollectionList.Count - 1];
            droppedCollectionList.Remove(droppedCollectionList[droppedCollectionList.Count - 1]);

            StartCoroutine(CreateCanned(fish));
            dropActive = false;

            if (fish.collectType == CollectType.Type4)
            {
                cannedCount += 1;
            }
            if (fish.collectType == CollectType.Type2)
            {
                cannedCount += 1;
            }
            if (fish.collectType == CollectType.Type1)
            {
                cannedCount += 1;
            }

            if (fish.collectType == CollectType.Type5)
            {
                cannedCount += 1;
            }
            if (fish.collectType == CollectType.Type3)
            {
                cannedCount += 1;
            }
            if (fish.collectType == CollectType.Type6)
            {
                cannedCount += 1;
            }
            fishCountCurrent += 1;

            fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();

            //float _waitTime = waitTime - (PlayerPrefs.GetInt("envlevel") * 0.05f);

            //if(_waitTime <= 0)
            //{
            //    _waitTime = Time.deltaTime;
            //}
            yield return new WaitForSeconds(waitTime / (speedFactor2 * speedFactors[Globals.machineSpeedLevel]));
            CollectableCountSet();
        }
        MinesDropAreaCheck();
        //machineActive = false;
        yield return new WaitForSeconds(2f);
        cannedCount = woodCollectionList.Count + plasticCollectionList.Count + ironCollectionList.Count + yarnCollectionList.Count;
        MachineStop();
        //if (droppedCollectionList.Count > 0)
        {
            StartCoroutine(CreatorChecking());
        }
    }


    IEnumerator CreateCanned(Collectable fish)
    {

        foreach (var lst in ironCollectionList)
        {
            lst.productCollectActive = true;
        }
        foreach (var lst in plasticCollectionList)
        {
            lst.productCollectActive = true;
        }
        foreach (var lst in yarnCollectionList)
        {
            lst.productCollectActive = true;
        }
        foreach (var lst in woodCollectionList)
        {
            lst.productCollectActive = true;
        }
        Vector3 firstPos = fish.transform.position;
        Quaternion firstRot = fish.transform.rotation;

        Quaternion targetRot = inTR.transform.rotation;
        Vector3 dropPos = inTR.transform.position;


        int prefabSelect = 0;
        for (int i = 0; i < productsPrefab.Length; i++)
        {
            if (productsPrefab[i].collectType == fish.collectType)
            {
                prefabSelect = i;
                break;
            }
        }
        
       






        // go in position
        float angle = 0f;
        float posY = 0f;
        float psoY_Factor = 0f;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 4 * Time.deltaTime;

            angle = counter * Mathf.PI;
            posY = psoY_Factor * Mathf.Sin(angle);

            fish.transform.position = Vector3.Lerp(firstPos, new Vector3(dropPos.x, dropPos.y + posY, dropPos.z), counter);
            fish.transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);

            yield return null;
        }
        fish.transform.position = dropPos;


      // go convert position

        firstPos = fish.transform.position;
        counter = 0f;
        while (counter < 1f)
        {
            counter += 4 * Time.deltaTime;
            fish.transform.position = Vector3.Lerp(firstPos, convertTR.transform.position, counter);

            yield return null;
        }

        fish.transform.position = convertTR.transform.position;

        // converting
        //Destroy(fish.gameObject,1f);





        StartCoroutine(CreateMultiProduct(fish, prefabSelect));




    }
    public List<GameObject> productFullTextGoList = new List<GameObject>();
    void ProductFullCheck()
    {

        if (ironCollectionList.Count < productCountTotal)
        {
            productFullTextGoList[0].SetActive(false);
        }
        else
        {
            productFullTextGoList[0].SetActive(true);
        }

        if (plasticCollectionList.Count < productCountTotal)
        {
            productFullTextGoList[1].SetActive(false);
        }
        else
        {
            productFullTextGoList[1].SetActive(true);
        }

        if (yarnCollectionList.Count < productCountTotal)
        {
            productFullTextGoList[2].SetActive(false);
        }
        else
        {
            productFullTextGoList[2].SetActive(true);
        }

        if (woodCollectionList.Count < productCountTotal)
        {
            productFullTextGoList[3].SetActive(false);
        }
        else
        {
            productFullTextGoList[3].SetActive(true);
        }



        if (ironCollectionList.Count > boxCountBound)
        {
            productCount_1_GO.SetActive(true);
            productCount_1_Text.text = "+" + (ironCollectionList.Count - boxCountBound).ToString();
        }
        else
        {
            productCount_1_GO.SetActive(false);
        }

        if (plasticCollectionList.Count > boxCountBound)
        {
            productCount_2_GO.SetActive(true);
            productCount_2_Text.text = "+" + (plasticCollectionList.Count - boxCountBound).ToString();
        }
        else
        {
            productCount_2_GO.SetActive(false);
        }

        if (yarnCollectionList.Count > boxCountBound)
        {
            productCount_3_GO.SetActive(true);
            productCount_3_Text.text = "+" + (yarnCollectionList.Count - boxCountBound).ToString();
        }
        else
        {
            productCount_3_GO.SetActive(false);
        }

        if (woodCollectionList.Count > boxCountBound)
        {
            productCount_4_GO.SetActive(true);
            productCount_4_Text.text = "+" + (woodCollectionList.Count - boxCountBound).ToString();
        }
        else
        {
            productCount_4_GO.SetActive(false);
        }

    }
    int boxCountBound = 80;
    public GameObject productCount_1_GO;
    public TextMeshProUGUI productCount_1_Text;

    public GameObject productCount_2_GO;
    public TextMeshProUGUI productCount_2_Text;

    public GameObject productCount_3_GO;
    public TextMeshProUGUI productCount_3_Text;

    public GameObject productCount_4_GO;
    public TextMeshProUGUI productCount_4_Text;
    IEnumerator CreateMultiProduct(Collectable oldProduct, int prefabSelect)
    {
        bool selfDestroyActive = true;
        float counter = 0f;
        yield return null;


        float moveSpeed = 4.8f;
        float rotSpeed = 5f;
        for (int i = 0; i < _CollectProducts[prefabSelect].bandPosList.Count; i++)
        {
            while (Vector3.Distance(oldProduct.transform.position, _CollectProducts[prefabSelect].bandPosList[i].transform.position) > 0.5f)
            {
                Vector3 direction = (_CollectProducts[prefabSelect].bandPosList[i].transform.position - oldProduct.transform.position).normalized;

                Quaternion targetRotation = Quaternion.LookRotation(direction);
                oldProduct.transform.rotation = Quaternion.Slerp(oldProduct.transform.rotation, targetRotation, speedFactor2 * speedFactors[Globals.machineSpeedLevel] * rotSpeed * Time.deltaTime);

                oldProduct.transform.Translate(oldProduct.transform.forward * moveSpeed * speedFactor2 * speedFactors[Globals.machineSpeedLevel] * Time.deltaTime, Space.World);

                yield return null;
            }
        }
        GameObject _newProduct = Instantiate(productsPrefab[prefabSelect].gameObject, _CollectProducts[prefabSelect].boxPosTR.position, _CollectProducts[prefabSelect].boxPosTR.rotation);
        _newProduct.GetComponent<Collectable>().collectActive = false;

        yield return new WaitForSeconds(0.1f);

        _newProduct.GetComponent<Collectable>().anim.SetTrigger("open");
        if (prefabSelect == 0)
        {
            if (ironCollectionList.Count < productCountTotal && iron_garbage_count >= 1f)
            {
                _newProduct.GetComponent<Collectable>().fishCollectable = ironCollectionList;

                ironCollectionList.Add(_newProduct.GetComponent<Collectable>());
                selfDestroyActive = false;
                PlayerPrefs.SetInt(machineName + "col1" + PlayerPrefs.GetInt("level"), ironCollectionList.Count);
                iron_garbage_count -= 1;
            }

        }
        else if (prefabSelect == 1)
        {
            if (plasticCollectionList.Count < productCountTotal && plastic_garbage_count >= 1f)
            {
                _newProduct.GetComponent<Collectable>().fishCollectable = plasticCollectionList;

                plasticCollectionList.Add(_newProduct.GetComponent<Collectable>());
                selfDestroyActive = false;
                PlayerPrefs.SetInt(machineName + "col2" + PlayerPrefs.GetInt("level"), plasticCollectionList.Count);
                plastic_garbage_count -= 1;

            }
        }
        else if (prefabSelect == 2)
        {
            if (yarnCollectionList.Count < productCountTotal && yarn_garbage_count >= 1f)
            {
                _newProduct.GetComponent<Collectable>().fishCollectable = yarnCollectionList;

                yarnCollectionList.Add(_newProduct.GetComponent<Collectable>());
                selfDestroyActive = false;
                PlayerPrefs.SetInt(machineName + "col3" + PlayerPrefs.GetInt("level"), yarnCollectionList.Count);
                yarn_garbage_count -= 1;

            }
        }
        else
        {
            if (woodCollectionList.Count < productCountTotal && wood_garbage_count >= 1f)
            {
                _newProduct.GetComponent<Collectable>().fishCollectable = woodCollectionList;

                woodCollectionList.Add(_newProduct.GetComponent<Collectable>());
                selfDestroyActive = false;
                PlayerPrefs.SetInt(machineName + "col4" + PlayerPrefs.GetInt("level"), woodCollectionList.Count);
                wood_garbage_count -= 1;

            }
        }
        //OrderId();
        ProductFullCheck();
        if (selfDestroyActive)
        {
            Destroy(oldProduct.gameObject, 0.1f);
            Destroy(_newProduct.gameObject, 0.1f);
        }
        else
        {
           

            float deltaY = 0;
            Transform targetTR;
            if (prefabSelect == 0)
            {
                if (ironCollectionList.Count == 0)
                {
                    deltaY = 0;
                    targetTR = ironProductPosTR[0];
                }
                else
                {
                    deltaY = (ironCollectionList.Count - 1) / ironProductPosTR.Length;
                    targetTR = ironProductPosTR[(ironCollectionList.Count - 1) % ironProductPosTR.Length];

                    if (ironCollectionList.Count > boxCountBound)
                    {
                        productCount_1_GO.SetActive(true);
                        productCount_1_Text.text = "+" + (ironCollectionList.Count - boxCountBound).ToString();


                        deltaY = (boxCountBound - 1) / ironProductPosTR.Length;
                        targetTR = ironProductPosTR[ironProductPosTR.Length - 1];
                    }
                    else
                    {
                        productCount_1_GO.SetActive(false);
                    }
                }
            }
            else if (prefabSelect == 1)
            {
                if (plasticCollectionList.Count == 0)
                {
                    deltaY = 0;
                    targetTR = plasticProductPosTR[0];
                }
                else
                {
                    deltaY = (plasticCollectionList.Count - 1) / plasticProductPosTR.Length;
                    targetTR = plasticProductPosTR[(plasticCollectionList.Count - 1) % plasticProductPosTR.Length];

                    if (plasticCollectionList.Count > boxCountBound)
                    {
                        productCount_2_GO.SetActive(true);
                        productCount_2_Text.text = "+" + (plasticCollectionList.Count - boxCountBound).ToString();

                        deltaY = (boxCountBound - 1) / plasticProductPosTR.Length;
                        targetTR = plasticProductPosTR[plasticProductPosTR.Length - 1];
                    }
                    else
                    {
                        productCount_2_GO.SetActive(false);
                    }
                }
            }
            else if (prefabSelect == 2)
            {
                if (yarnCollectionList.Count == 0)
                {
                    deltaY = 0;
                    targetTR = yarnProductPosTR[0];
                }
                else
                {
                    deltaY = (yarnCollectionList.Count - 1) / yarnProductPosTR.Length;
                    targetTR = yarnProductPosTR[(yarnCollectionList.Count - 1) % yarnProductPosTR.Length];

                    if (yarnCollectionList.Count > boxCountBound)
                    {
                        productCount_3_GO.SetActive(true);
                        productCount_3_Text.text = "+" + (yarnCollectionList.Count - boxCountBound).ToString();

                        deltaY = (boxCountBound - 1) / yarnProductPosTR.Length;
                        targetTR = yarnProductPosTR[yarnProductPosTR.Length - 1];
                    }
                    else
                    {
                        productCount_3_GO.SetActive(false);
                    }
                }
            }
            else
            {
                if (woodCollectionList.Count == 0)
                {
                    deltaY = 0;
                    targetTR = woodProductPosTR[0];
                }
                else
                {
                    deltaY = (woodCollectionList.Count - 1) / woodProductPosTR.Length;
                    targetTR = woodProductPosTR[(woodCollectionList.Count - 1) % woodProductPosTR.Length];

                    if (woodCollectionList.Count > boxCountBound)
                    {
                        productCount_4_GO.SetActive(true);
                        productCount_4_Text.text = "+" + (woodCollectionList.Count - boxCountBound).ToString();

                        deltaY = (boxCountBound - 1) / woodProductPosTR.Length;
                        targetTR = woodProductPosTR[woodProductPosTR.Length - 1];
                    }
                    else
                    {
                        productCount_4_GO.SetActive(false);
                    }
                }
            }

           Vector3 firstPos = oldProduct.transform.position;
            //for (int i = 0; i < _CollectProducts[prefabSelect].bandPosList.Count; i++)
            //{
            //    firstPos = oldProduct.transform.position;
            //    counter = 0f;
            //    while (counter < 1f)
            //    {
            //        counter += 4 * Time.deltaTime;
            //        oldProduct.transform.position = Vector3.Lerp(firstPos, _CollectProducts[prefabSelect].bandPosList[i].position, counter);

            //        yield return null;
            //    }
            //}
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 1.25f, 0);
            firstPos = oldProduct.transform.position;
            counter = 0f;
            while (counter < 1f && !_newProduct.GetComponent<Collectable>().isCollected && oldProduct != null)
            {
                counter += 2 * Time.deltaTime;
                oldProduct.transform.position = Vector3.Lerp(firstPos, _CollectProducts[prefabSelect].boxPosTR.position, counter);

                yield return null;
            }

            if (!_newProduct.GetComponent<Collectable>().isCollected)
            {
                _newProduct.transform.parent = targetTR.parent;
                if(oldProduct != null)
                oldProduct.transform.parent = _newProduct.transform;
            }
            _newProduct.GetComponent<Collectable>().anim.SetTrigger("close");
            yield return new WaitForSeconds(0.25f);


            if (oldProduct != null)
            {
                Destroy(oldProduct.gameObject);
            }
            StartCoroutine(GoCannedPos(_newProduct.GetComponent<Collectable>(), targetTR, dropPos, selfDestroyActive));
        }
    }
    IEnumerator GoCannedPos(Collectable newProduct, Transform targetTR, Vector3 dropPos,bool selfDestroy)
    {
        newProduct.productCollectActive = true;

        newProduct.box.SetActive(false);
        newProduct.boxSinglePart.SetActive(true);
        Vector3 firstPos = newProduct.transform.position;
        Quaternion firstRot = newProduct.transform.rotation;

        Quaternion targetRot = targetTR.transform.rotation;

        float angle = 0f;
        float posY = 0f;
        float psoY_Factor = 1f;
        float counter = 0f;
        while (counter < 1f && !newProduct.isCollected)
        {
            counter += 2 * Time.deltaTime;

            angle = counter * Mathf.PI;
            posY = psoY_Factor * Mathf.Sin(angle);

            newProduct.transform.position = Vector3.Lerp(firstPos, new Vector3(dropPos.x, dropPos.y + posY, dropPos.z), counter);
            newProduct.transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);

            yield return null;
        }
        if (selfDestroy)
        {
            Destroy(newProduct.gameObject, 0.1f);
        }
        else
        {
            if (!newProduct.isCollected)
            {
                newProduct.transform.position = dropPos;
                newProduct.transform.rotation = targetRot;
                //newProduct.InitInstancedMaterial();
            }
            yield return new WaitForSeconds(0.2f);
            //newProduct.productCollectActive = true;
            newProduct.box.SetActive(false);
            newProduct.boxSinglePart.SetActive(true);
        }
        //icedFish.collectActive = true;

    }
    public void ManuealRawCreate()
    {
        StartCoroutine(ManuealRawCreator());
    }
    IEnumerator ManuealRawCreator()
    {
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < PlayerPrefs.GetInt(machineName + "col1" + PlayerPrefs.GetInt("level")); i++)
        {
            GameObject newProduct = Instantiate(productsPrefab[0].gameObject);
            newProduct.GetComponent<Collectable>().collectActive = false;

            newProduct.GetComponent<Collectable>().fishCollectable = ironCollectionList;
            //newProduct.GetComponent<Collectable>().InitInstancedMaterial();
            newProduct.GetComponent<Collectable>().box.SetActive(false);
            newProduct.GetComponent<Collectable>().boxSinglePart.SetActive(true);

            ironCollectionList.Add(newProduct.GetComponent<Collectable>());


            float deltaY = 0;
            Transform targetTR;

            deltaY = (ironCollectionList.Count - 1) / ironProductPosTR.Length;
            targetTR = ironProductPosTR[(ironCollectionList.Count - 1) % ironProductPosTR.Length];

            if (ironCollectionList.Count > boxCountBound)
            {
                productCount_1_GO.SetActive(true);
                productCount_1_Text.text = "+" + (ironCollectionList.Count - boxCountBound).ToString();

                deltaY = (boxCountBound - 1) / ironProductPosTR.Length;
                targetTR = ironProductPosTR[ironProductPosTR.Length - 1];
            }
            else
            {
                productCount_1_GO.SetActive(false);
            }

            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 1.25f, 0);
            Quaternion targetRot = targetTR.transform.rotation;

            newProduct.transform.parent = targetTR.parent;


            newProduct.transform.position = dropPos;
            newProduct.transform.rotation = targetRot;

            //yield return new WaitForSeconds(0.2f);
            newProduct.GetComponent<Collectable>().productCollectActive = true;
            //newProduct.GetComponent<Collectable>().productCollectActive = true;
        }
        yield return null;

        for (int i = 0; i < PlayerPrefs.GetInt(machineName + "col2" + PlayerPrefs.GetInt("level")); i++)
        {
            GameObject newProduct = Instantiate(productsPrefab[1].gameObject);
            newProduct.GetComponent<Collectable>().collectActive = false;

            newProduct.GetComponent<Collectable>().fishCollectable = plasticCollectionList;
            //newProduct.GetComponent<Collectable>().InitInstancedMaterial();

            newProduct.GetComponent<Collectable>().box.SetActive(false);
            newProduct.GetComponent<Collectable>().boxSinglePart.SetActive(true);

            plasticCollectionList.Add(newProduct.GetComponent<Collectable>());


            float deltaY = 0;
            Transform targetTR;

            deltaY = (plasticCollectionList.Count - 1) / plasticProductPosTR.Length;
            targetTR = plasticProductPosTR[(plasticCollectionList.Count - 1) % plasticProductPosTR.Length];

            if (plasticCollectionList.Count > boxCountBound)
            {
                productCount_2_GO.SetActive(true);
                productCount_2_Text.text = "+" + (plasticCollectionList.Count - boxCountBound).ToString();

                deltaY = (boxCountBound - 1) / plasticProductPosTR.Length;
                targetTR = plasticProductPosTR[plasticProductPosTR.Length - 1];
            }
            else
            {
                productCount_2_GO.SetActive(false);
            }

            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 1.25f, 0);
            Quaternion targetRot = targetTR.transform.rotation;

            newProduct.transform.parent = targetTR.parent;


            newProduct.transform.position = dropPos;
            newProduct.transform.rotation = targetRot;

            //yield return new WaitForSeconds(0.2f);
            newProduct.GetComponent<Collectable>().productCollectActive = true;
            //yield return null;
            //newProduct.GetComponent<Collectable>().productCollectActive = true;
        }
        yield return null;

        for (int i = 0; i < PlayerPrefs.GetInt(machineName + "col3" + PlayerPrefs.GetInt("level")); i++)
        {
            GameObject newProduct = Instantiate(productsPrefab[2].gameObject);
            newProduct.GetComponent<Collectable>().collectActive = false;

            newProduct.GetComponent<Collectable>().fishCollectable = yarnCollectionList;
            //newProduct.GetComponent<Collectable>().InitInstancedMaterial();

            newProduct.GetComponent<Collectable>().box.SetActive(false);
            newProduct.GetComponent<Collectable>().boxSinglePart.SetActive(true);

            yarnCollectionList.Add(newProduct.GetComponent<Collectable>());


            float deltaY = 0;
            Transform targetTR;

            deltaY = (yarnCollectionList.Count - 1) / yarnProductPosTR.Length;
            targetTR = yarnProductPosTR[(yarnCollectionList.Count - 1) % yarnProductPosTR.Length];

            if (yarnCollectionList.Count > boxCountBound)
            {
                productCount_3_GO.SetActive(true);
                productCount_3_Text.text = "+" + (yarnCollectionList.Count - boxCountBound).ToString();

                deltaY = (boxCountBound - 1) / yarnProductPosTR.Length;
                targetTR = yarnProductPosTR[yarnProductPosTR.Length - 1];
            }
            else
            {
                productCount_3_GO.SetActive(false);
            }

            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 1.25f, 0);
            Quaternion targetRot = targetTR.transform.rotation;

            newProduct.transform.parent = targetTR.parent;


            newProduct.transform.position = dropPos;
            newProduct.transform.rotation = targetRot;

            //yield return new WaitForSeconds(0.2f);
            newProduct.GetComponent<Collectable>().productCollectActive = true;
            //yield return null;
            //newProduct.GetComponent<Collectable>().productCollectActive = true;
        }
        yield return null;

        for (int i = 0; i < PlayerPrefs.GetInt(machineName + "col4" + PlayerPrefs.GetInt("level")); i++)
        {
            GameObject newProduct = Instantiate(productsPrefab[3].gameObject);
            newProduct.GetComponent<Collectable>().collectActive = false;

            newProduct.GetComponent<Collectable>().fishCollectable = woodCollectionList;
            //newProduct.GetComponent<Collectable>().InitInstancedMaterial();

            newProduct.GetComponent<Collectable>().box.SetActive(false);
            newProduct.GetComponent<Collectable>().boxSinglePart.SetActive(true);

            woodCollectionList.Add(newProduct.GetComponent<Collectable>());


            float deltaY = 0;
            Transform targetTR;

            deltaY = (woodCollectionList.Count - 1) / woodProductPosTR.Length;
            targetTR = woodProductPosTR[(woodCollectionList.Count - 1) % woodProductPosTR.Length];

            if (woodCollectionList.Count > boxCountBound)
            {
                productCount_4_GO.SetActive(true);
                productCount_4_Text.text = "+" + (woodCollectionList.Count - boxCountBound).ToString();

                deltaY = (boxCountBound - 1) / woodProductPosTR.Length;
                targetTR = woodProductPosTR[woodProductPosTR.Length - 1];
            }
            else
            {
                productCount_4_GO.SetActive(false);
            }

            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 1.25f, 0);
            Quaternion targetRot = targetTR.transform.rotation;

            newProduct.transform.parent = targetTR.parent;


            newProduct.transform.position = dropPos;
            newProduct.transform.rotation = targetRot;

            //yield return new WaitForSeconds(0.2f);
            newProduct.GetComponent<Collectable>().productCollectActive = true;
            //yield return null;
            //newProduct.GetComponent<Collectable>().productCollectActive = true;
        }
        yield return null;

        foreach (var lst in ironCollectionList)
        {
            lst.productCollectActive = true;
        }
        foreach (var lst in plasticCollectionList)
        {
            lst.productCollectActive = true;
        }
        foreach (var lst in yarnCollectionList)
        {
            lst.productCollectActive = true;
        }
        foreach (var lst in woodCollectionList)
        {
            lst.productCollectActive = true;
        }
    }
    public override void DropCollection(int collectAmount, StackCollect _stackCollect)
    {
        //if (droppedCollectionList.Count == 0)
        //{
        //    StartCoroutine(CannedCreator());
        //}
        if (collectAmount > 0 && fishCountCurrent > 0 && _stackCollect.collectionTrs[0] != null)
        {
            //VibratoManager.Instance.MediumMultiVibration();
            _stackCollect.collectActive = false;
            StartCoroutine(DropSequantial(collectAmount, _stackCollect));
        }

    }

    IEnumerator DropSequantial(int collectAmount, StackCollect _stackCollect)
    {
        Collectable droppingCollection = null;

        for (int i = 0; i < _stackCollect.collectionTrs.Count; i++)
        {
            foreach (int cltId in collectIDList)
            {
                if (_stackCollect.collectionTrs[i].collectID == cltId)
                {
                    if (collectType2 == CollectType.All || collectType == CollectType.All || _stackCollect.collectionTrs[i].collectType == collectType )
                    {
                        droppingCollection = _stackCollect.collectionTrs[i];

                        if (_stackCollect.collectionTrs[i].collectType == CollectType.Type1)
                        {
                            iron_garbage_count += _stackCollect.collectionTrs[i].rawCount;
                        }

                        if (_stackCollect.collectionTrs[i].collectType == CollectType.Type2)
                        {
                            plastic_garbage_count += _stackCollect.collectionTrs[i].rawCount;

                        }
                        if (_stackCollect.collectionTrs[i].collectType == CollectType.Type3)
                        {
                            yarn_garbage_count += _stackCollect.collectionTrs[i].rawCount;

                        }
                        if (_stackCollect.collectionTrs[i].collectType == CollectType.Type4)
                        {
                            wood_garbage_count += _stackCollect.collectionTrs[i].rawCount;

                        }

                        i = _stackCollect.collectionTrs.Count;

                        break;
                    }

                }
            }
        }
        Collectable deletedCollect = droppingCollection;

        _stackCollect.collectionTrs.Remove(deletedCollect);



        droppedCollectionList.Add(droppingCollection);
        PlayerPrefs.SetInt(machineName + "rawcount" + PlayerPrefs.GetInt("level"), droppedCollectionList.Count);

        yield return null;
        droppingCollection.collectActive = false;
        float deltaY = 0;
        int posNo = 0;
        if (droppedCollectionList.Count > 0)
        {
            posNo = droppedCollectionList.Count - 1;

        }

        deltaY = (posNo) / fishPosTR.Length;

        Transform targetTR = fishPosTR[(posNo) % fishPosTR.Length];
        Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.7f, 0);
        StartCoroutine(Drop(targetTR, dropPos, droppingCollection, Time.deltaTime));

        if (_stackCollect.player)
        {
            VibratoManager.Instance.LightVibration();
            AudioManager.Instance.StackDropSound();
        }

        if (_stackCollect.collectionTrs.Count == 0)
        {
            //PlayerController.Instance.animator.SetBool("carrying", false);
        }
        yield return new WaitForSeconds(0.5f);
        _stackCollect.collectActive = true;
        foreach (var wrkArea in workAreaList)
        {
            //wrkArea.ShuffleStandList();
            //wrkArea.ShuffleCollectProductList();
        }

        //yield return null;
    
        //List<Collectable> droppingCollectionList = new List<Collectable>();

        //int amount = collectAmount;
        //int loopCount = _stackCollect.collectionTrs.Count;
        //for (int i = 0; i < loopCount; i++)
        //{
        //    foreach (int cltId in collectIDList)
        //    {
        //        if (_stackCollect.collectionTrs[i].collectID == cltId && amount > 0)
        //        {
        //            if (collectType == CollectType.All || _stackCollect.collectionTrs[i].collectType == collectType)
        //            {
        //                droppingCollectionList.Add(_stackCollect.collectionTrs[i]);

        //                if(_stackCollect.collectionTrs[i].collectType == CollectType.Iron)
        //                {
        //                    iron_garbage_count += _stackCollect.collectionTrs[i].rawCount;
        //                }

        //                if (_stackCollect.collectionTrs[i].collectType == CollectType.Plastic)
        //                {
        //                    plastic_garbage_count += _stackCollect.collectionTrs[i].rawCount;

        //                }
        //                if (_stackCollect.collectionTrs[i].collectType == CollectType.Yarn)
        //                {
        //                    yarn_garbage_count += _stackCollect.collectionTrs[i].rawCount;

        //                }
        //                if (_stackCollect.collectionTrs[i].collectType == CollectType.Wood)
        //                {
        //                    wood_garbage_count += _stackCollect.collectionTrs[i].rawCount;

        //                }
        //                amount--;
        //                break;
        //            }
        //        }
        //    }
        //}


        //for (int i = 0; i < droppingCollectionList.Count; i++)
        //{
        //    Collectable deletedCollect = droppingCollectionList[i];

        //    _stackCollect.collectionTrs.Remove(deletedCollect);
        //}
        //for (int i = 0; i < droppingCollectionList.Count; i++)
        //{
        //    droppedCollectionList.Add(droppingCollectionList[i]);


        //    yield return null;
        //    droppingCollectionList[i].collectActive = false;
        //    float deltaY = 0;
        //    deltaY = (droppedCollectionList.Count - 1) / fishPosTR.Length;
        //    Transform targetTR = fishPosTR[(droppedCollectionList.Count - 1) % fishPosTR.Length];
        //    Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);
        //    StartCoroutine(Drop(targetTR, dropPos, droppingCollectionList[i], i * 0.05f));
        //    if (_stackCollect.player)
        //    {
        //        VibratoManager.Instance.LightVibration();
        //    }
        //}

        //yield return new WaitForSeconds(0.5f);
        //_stackCollect.collectActive = true;
    }

    IEnumerator Drop(Transform dropPosTR, Vector3 dropPos, Collectable collectable, float waitTime)
    {
        //Destroy(collectable.GetComponent<Collector>().shadowGO);
        collectable.grindActive = true;
        if (PlayerPrefs.GetInt("collectstonecount10") < 3)
        {
            PlayerPrefs.SetInt("collectstonecount10", PlayerPrefs.GetInt("collectstonecount10") + 1);

            if (PlayerPrefs.GetInt("collectstonecount10") == 3)
            {
                IndicatorManager.Instance.IndicatorTargeterActive();
            }
        }
        collectable.isCollected = false;

        //collectable.animator.SetTrigger("stop");
        yield return new WaitForSeconds(waitTime);
        collectable.transform.parent = dropPosTR.parent;

        Vector3 firstPos = collectable.transform.position;
        Quaternion firstRot = collectable.transform.rotation;
        if (collectable.gameObject != null)
        {
            collectable.CollectSave();
            //collectable.transform.parent = null;
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


        //collectable.transform.localScale *= 2f;
        Quaternion targetAngle = dropPosTR.rotation;
        //Quaternion targetAngle = Quaternion.Euler(dropPosTR.eulerAngles.x, dropPosTR.eulerAngles.y + Random.Range(-30f, 30f), dropPosTR.eulerAngles.z + Random.Range(-30f, 30f));

        while (timeCounter < 1f)
        {
            timeCounter += 2 * Time.deltaTime;

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
        //collectable.transform.localScale = new Vector3(collectable.transform.localScale.x * 0.5f, collectable.transform.localScale.y * 2f, collectable.transform.localScale.z);
        //OpenScale(collectable.transform, 1f, 2f, 1f, Ease.OutElastic);

        if (collectable.gameObject != null)
        {
            //collectable.animator.SetTrigger("stop");

        }
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


    public Tween OpenScale(Transform prt, float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Vector3 firstScale = prt.localScale;
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                prt.localScale = firstScale * value;
            }).OnComplete(delegate ()
            {

            });
        return tween;
    }

    public int[] capacities;
    public float[] speedFactors;
    float speedFactor2 = 1f;

    public void UpgradeValueInit()
    {
        CapacityInit();
    }
    void CapacityInit()
    {
        fishCountTotal = capacities[standLevel];
        productCountTotal = capacities[standLevel];
        fishCountCurrent = capacities[standLevel] - droppedCollectionList.Count;
        speedFactor = speedFactors[standLevel];
        fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();

    }
    [System.Serializable]
    public struct MyStruct
    {
        public int value;
        public CollectType collectType;
        // Constructor ile struct'a deðer atama
        public MyStruct(int _value, CollectType _collectType)
        {
            value = _value;
            collectType = _collectType;
        }
    }
    public List<MyStruct> myStruct;

    //List<CollectType> collectTypeList;
    //List<int> collectionListCount;
    int _counter = 0;
    void OrderId()
    {
        //collectTypeList.Clear();

        myStruct.Clear();
        for (int i = 0; i <= Globals.collectableLevel; i++)
        {
            if (i == 0)
            {
                myStruct.Add(new MyStruct(ironCollectionList.Count, CollectType.Type1));
            }
            if (i == 1)
            {
                myStruct.Add(new MyStruct(plasticCollectionList.Count, CollectType.Type2));
            }
            if (i == 2)
            {
                myStruct.Add(new MyStruct(yarnCollectionList.Count, CollectType.Type3));
            }
            if (i == 3)
            {
                myStruct.Add(new MyStruct(woodCollectionList.Count, CollectType.Type4));
            }
        }

        myStruct.Sort((x, y) => x.value.CompareTo(y.value));

        for (int i = 0; i <= Globals.collectableLevel; i++)
        {
            Collectable clt;
            bool breakActive = false;
            for(int c = 0; c < droppedCollectionList.Count; c++)
            {
                clt = droppedCollectionList[droppedCollectionList.Count - 1 - c];
                if (clt.collectType == myStruct[i].collectType)
                {
                    Vector3 lastIndexPos;
                    Vector3 selectedIndexPos;
                    lastIndexPos = droppedCollectionList[droppedCollectionList.Count - 1].transform.localPosition;
                    selectedIndexPos = clt.transform.localPosition;

                    clt.transform.localPosition = lastIndexPos;
                    droppedCollectionList[droppedCollectionList.Count - 1].transform.localPosition = selectedIndexPos;

                    droppedCollectionList.Remove(clt);
                    droppedCollectionList.Add(clt);
                    breakActive = true;
                    break;
                }
            }
            if (breakActive)
            {
                break;
            }
        }
        //collectionListCount.Sort();
        //for(int i = 0; i < collectionListCount.Count; i++)
        //{

        //}
        _counter++;

        if (_counter % fishPosTR.Length == 0)
        {
            for (int i = 0; i < droppedCollectionList.Count; i++)
            {
                float deltaY = 0;
                int posNo = i;
                deltaY = (posNo) / fishPosTR.Length;
                Transform targetTR = fishPosTR[(posNo) % fishPosTR.Length];
                Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.7f, 0);

                droppedCollectionList[i].transform.position = dropPos;
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandStock : Stand
{

    public Collectable[] productPrefabs;

    //public Transform[] fishPosTR;


    public Transform[] productPosTR;
    public CollectProduct _CollectProducts;
    public List<Collectable> productCollectionList = new List<Collectable>();
    public StandRaw standRaw;
    public override void CollectableCountSet()
    {
        if (PlayerPrefs.GetInt("bandstocktutorial") == 0)
        {
            PlayerPrefs.SetInt("bandstocktutorial", 1);
            TutorialManager.Instance.bandTut_1.SetActive(false);
            TutorialManager.Instance.bandTut_2.SetActive(true);

            IndicatorManager.Instance.TutorialStepCompleted();
            IndicatorManager.Instance.TutorialStepStart(52);

        }
        if (PlayerPrefs.GetInt("bandstocktutorial") == 1 && productCollectionList.Count == 0)
        {
            PlayerPrefs.SetInt("bandstocktutorial", 2);
            TutorialManager.Instance.bandTut_2.SetActive(false);
            TutorialManager.Instance.bandTut_3.SetActive(true);

            IndicatorManager.Instance.IndicaorActive(standRaw.transform);
        }
        //if (PlayerPrefs.GetInt("bandstocktutorial") == 3 && productCollectionList.Count == 0)
        //{
        //    PlayerPrefs.SetInt("bandstocktutorial", 4);
        //    TutorialManager.Instance.bandTut_2.SetActive(false);
        //    TutorialManager.Instance.bandTut_3.SetActive(true);

        //    IndicatorManager.Instance.IndicaorActive(standRaw.transform);
        //}
    }

    public override void DropCollection(int collectAmount, StackCollect _stackCollect)
    {

    }

    public override void SpecificReset()
    {

    }

    public override void SpecificStart()
    {
        _CollectProducts.collectables = productCollectionList;
    }

    public void ManuelRawCreate()
    {
        StartCoroutine(ManuealRawCreator());
        if (PlayerPrefs.GetInt("bandstocktutorial") == 0)
        {
            StartCoroutine(BantTutorial());
        }
    }
    IEnumerator BantTutorial()
    {
        yield return new WaitForSeconds(5f);
        TutorialManager.Instance.bandTut_1.SetActive(true);
        IndicatorManager.Instance.IndicaorActive(_CollectProducts.transform);

        IndicatorManager.Instance.TutorialStepStart(51);

    }

    IEnumerator ManuealRawCreator()
    {
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < (standRaw.maxBandCapacity); i++)
        {
            GameObject newProduct = Instantiate(productPrefabs[0].gameObject);
            newProduct.GetComponent<Collectable>().collectActive = false;

            newProduct.GetComponent<Collectable>().fishCollectable = productCollectionList;


            productCollectionList.Add(newProduct.GetComponent<Collectable>());


            float deltaY = 0;
            Transform targetTR;

            targetTR = productPosTR[0];

            if (productCollectionList.Count > 0)
            {
                deltaY = (productCollectionList.Count - 1) / productPosTR.Length;
                targetTR = productPosTR[(productCollectionList.Count - 1) % productPosTR.Length];
            }

            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 1.4f, 0);
            Quaternion targetRot = targetTR.transform.rotation;

            //newProduct.transform.parent = targetTR.parent;


            newProduct.transform.position = dropPos;
            newProduct.transform.rotation = targetRot;

            //yield return new WaitForSeconds(0.2f);
            newProduct.GetComponent<Collectable>().productCollectActive = true;

            yield return null;
            newProduct.GetComponent<Collectable>().productCollectActive = true;
        }
    }
    public void ManuelRawCreateWithCount(int extraCount)
    {
        StartCoroutine(ManuealRawCreator_Count(extraCount));
    }

    IEnumerator ManuealRawCreator_Count(int extraCount)
    {
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < (extraCount); i++)
        {
            GameObject newProduct = Instantiate(productPrefabs[0].gameObject);
            newProduct.GetComponent<Collectable>().collectActive = false;

            newProduct.GetComponent<Collectable>().fishCollectable = productCollectionList;


            productCollectionList.Add(newProduct.GetComponent<Collectable>());


            float deltaY = 0;
            Transform targetTR;

            targetTR = productPosTR[0];

            if (productCollectionList.Count > 0)
            {
                deltaY = (productCollectionList.Count - 1) / productPosTR.Length;
                targetTR = productPosTR[(productCollectionList.Count - 1) % productPosTR.Length];
            }

            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 1.4f, 0);
            Quaternion targetRot = targetTR.transform.rotation;

            //newProduct.transform.parent = targetTR.parent;


            newProduct.transform.position = dropPos;
            newProduct.transform.rotation = targetRot;

            //yield return new WaitForSeconds(0.2f);
            newProduct.GetComponent<Collectable>().productCollectActive = true;

            yield return null;
            newProduct.GetComponent<Collectable>().productCollectActive = true;
        }
    }
}

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

    public override void CollectableCountSet()
    {
        throw new System.NotImplementedException();
    }

    public override void DropCollection(int collectAmount, StackCollect _stackCollect)
    {
        throw new System.NotImplementedException();
    }

    public override void SpecificReset()
    {
        throw new System.NotImplementedException();
    }

    public override void SpecificStart()
    {
        _CollectProducts.collectables = productCollectionList;
    }

    public void ManuelRawCreate()
    {
        StartCoroutine(ManuealRawCreator());
    }

    IEnumerator ManuealRawCreator()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject newProduct = Instantiate(productPrefabs[0].gameObject);
            newProduct.GetComponent<Collectable>().collectActive = false;

            newProduct.GetComponent<Collectable>().fishCollectable = productCollectionList;


            productCollectionList.Add(newProduct.GetComponent<Collectable>());


            float deltaY = 0;
            Transform targetTR;

            deltaY = (productCollectionList.Count - 1) / productPosTR.Length;
            targetTR = productPosTR[(productCollectionList.Count - 1) % productPosTR.Length];

            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 3f, 0);
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

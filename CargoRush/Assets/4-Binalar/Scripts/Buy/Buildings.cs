using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildings : MonoBehaviour
{
    //[SerializeField] public GameObject buildingPrefab;
    public GameObject loadedBuild;
    public int thisBuildingLevel;
    public int buildNo;

    bool colorIndicate = false;

    //public Vector3 buildPosition;
    //public Quaternion buildRotation;
    //Animator[] childAnim;
    List<Vector3> chldSize = new List<Vector3>();
    List<Transform> chldTR = new List<Transform>();
    private void Awake()
    {
        StartCoroutine(buildInit());
    }

    IEnumerator buildInit()
    {
        loadedBuild.SetActive(true);
        yield return new WaitForSeconds(0.1f);

        loadedBuild.transform.localScale = Vector3.one;

        foreach (var chldObj in loadedBuild.GetComponentsInChildren<MeshRenderer>())
        {
            if (chldObj.name != loadedBuild.name)
            {
                chldSize.Add(chldObj.transform.localScale);
                chldTR.Add(chldObj.transform);
                chldObj.transform.localScale = Vector3.zero;
            }
        }
        loadedBuild.transform.localScale = Vector3.one;
        yield return new WaitForSeconds(0.1f);
        loadedBuild.transform.localScale = Vector3.one;
        StartCoroutine(buildScaling());
    }

    IEnumerator buildScaling()
    {
        for (int i = 0; i < chldTR.Count; i++)
        {
            StartCoroutine(throughlyScaling(chldTR[i], chldSize[i]));
            yield return new WaitForSeconds(0.05f);
        }
        loadedBuild.transform.localScale = Vector3.one;
    }
    IEnumerator throughlyScaling(Transform bld, Vector3 size)
    {
        float counter = 0f;
        float sizeDelta;

        while (counter < 1f)
        {
            counter += 5 * Time.deltaTime;

            bld.localScale = size * counter;
            yield return null;
        }
        bld.localScale = size;
        counter = 0f;
        while (counter < Mathf.PI)
        {
            counter += 15 * Time.deltaTime;
            sizeDelta = 1f - Mathf.Abs(Mathf.Cos(counter));
            sizeDelta /= 3f;
            bld.localScale = size + size * sizeDelta;

            yield return null;
        }
        bld.localScale = size;
    }
}

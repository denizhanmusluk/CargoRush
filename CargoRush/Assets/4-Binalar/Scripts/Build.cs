using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;


public class Build : MonoBehaviour
{
    [SerializeField] public List<GameObject> levels;
    public GameObject loadedBuild;
    float firstScale;
    public int thisBuildingLevel;
    [SerializeField] public List<GameObject> customerList;
    public bool troubleActive = false;
    public int buildNo;

    bool colorIndicate = false;

    public TextMeshProUGUI Text1;
   //public Sequence sequence, sequence2, sequence3, sequence4;
    [SerializeField] public MeshRenderer buildMesh;
    [SerializeField] public Material firstMaterial;
    [SerializeField] public Material troubleMaterial;
    [SerializeField] GameObject attention;
    [SerializeField] GameObject envirnmonetParticles;
    [SerializeField] ParticleSystem fireWork;
    public GameObject hiringImage;
    public GameObject downArrow, upArrow;
    public Transform buildPositionTR;
    //Animator[] childAnim;
    [SerializeField] List<Vector3> chldSize = new List<Vector3>();
     List<Transform> chldTR = new List<Transform>();
    private void Start()
    {
        buildInit(0);
    }

    private void Awake()
    {
      
            //childAnim = GetComponentsInChildren<Animator>();

            //hiringImage.SetActive(false);
            attention.SetActive(false);
        envirnmonetParticles.SetActive(false);
    }
    public void buildInit(int level)
    {

        //troubleActive = false;
        fireWork.Play();
        thisBuildingLevel = level;
    

        loadedBuild = Instantiate(levels[level], buildPositionTR.position, buildPositionTR.rotation);
        loadedBuild.transform.parent = transform;

        foreach (var chldObj in loadedBuild.GetComponentsInChildren<MeshRenderer>())
        {
            chldSize.Add(chldObj.transform.localScale);
            chldTR.Add(chldObj.transform);
            chldObj.transform.localScale = Vector3.zero;
        }
        //firstMaterial = buildMesh.material;
        StartCoroutine(buildScaling());
    }

    IEnumerator buildScaling()
    {
        int buildChildCount = loadedBuild.transform.childCount;
        //foreach (var chldObj in loadedBuild.GetComponentsInChildren<Transform>())
        //{
        //        StartCoroutine(throughlyScaling(chldObj.transform, chldSize[i]));
        //        i++;
        //        yield return new WaitForSeconds(0.1f);
        //}
        for(int i = 0;i< chldTR.Count; i++)
        {
            StartCoroutine(throughlyScaling(chldTR[i], chldSize[i]));
            yield return new WaitForSeconds(0.1f);
        }
        //for (int i = 0; i < buildChildCount; i++)
        //{
        //    StartCoroutine(throughlyScaling(loadedBuild.transform.GetChild(i).transform));
        //    yield return new WaitForSeconds(0.05f);
        //}

        yield return new WaitForSeconds(thisBuildingLevel * Random.Range(0, 1f));

        if (Globals.maxBuildLevel < thisBuildingLevel)
        {
            Globals.maxBuildLevel = thisBuildingLevel;
        }
        //foreach(var anim in childAnim)
        //{
        //    anim.enabled = true;
        //}
        loadedBuild.GetComponent<CreateMoney>()._Start();
    }
    // Update is called once per frame
    IEnumerator throughlyScaling(Transform bld,Vector3 size)
    {
        float counter = 0f;
        //Vector3 firstSize = bld.localScale;
        float sizeDelta;

        while(counter < 1f)
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

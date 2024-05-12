using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environments : MonoBehaviour
{
    //public Material _unlockMaterial, _lockMaterial;

    [SerializeField] public float earnMoney;
    //[SerializeField] GameObject[] coinPrefabs;
    [SerializeField] int coinCount;
    [SerializeField] GameObject point;

    public int collectLevel;
    public int rubbishID;
    public bool collectActive = true;
    Rigidbody rb;
    Transform targetTR;
    bool hitActive = true;
    public int EnvironmentNo;
    public bool triggerActive = false;
    Part _part;
    [SerializeField] Sprite fishImage;

    public bool isGem = false;
    private void Awake()
    {
        //earnMoney *= Globals.levelFactor;
        //childrenMesh = GetComponentsInChildren<MeshRenderer>();
    }
    private void Start()
    {
        firstPos = transform.position;
        firstRot = transform.rotation;
        _part = GetComponent<Part>();
        rb = GetComponent<Rigidbody>();
    }
    public void UnlockMaterial()
    {
        //foreach (var _mesh in childrenMesh)
        //{
        //    _mesh.material = _unlockMaterial;
        //}
    }
    public void ForceLockedObject(Transform _targetTR)
    {
        targetTR = _targetTR;
        //StartCoroutine(ForceLockedAppling());
    }
    public void ForceLockedObjectExit()
    {
        StartCoroutine(ForceLockedApplingExit());

    }
    Vector3 firstPos;
    Vector3 firstSize;
    Quaternion firstRot;
    IEnumerator ForceLockedAppling()
    {
        firstPos = transform.position;
        float counter = 0f;
        float time = 1f;
        while (counter < time)
        {
            counter += 38f * Time.deltaTime;


            Vector3 direction = ((targetTR.position - transform.position - new Vector3(0, transform.position.y, 0)).normalized) * 0.1f;
            transform.position = Vector3.Lerp(firstPos, firstPos + direction, counter);

            yield return null;
        }
        ForceLockedObjectExit();
    }
    IEnumerator ForceLockedApplingExit()
    {
        Vector3 lastPos = transform.position;
        float counter = 0f;
        float time = 1f;
        while (counter < time)
        {
            counter += 22f * Time.deltaTime;


            transform.position = Vector3.Lerp(lastPos, firstPos, counter);

            yield return null;


        }
        collectActive = true;

    }
    public void ForceObject(Transform _targetTR)
    {
        targetTR = _targetTR;
        StartCoroutine(ForceAppling());
    }
    IEnumerator ForceAppling()
    {
        rb.AddForce(Vector3.up * 250);
        yield return new WaitForSeconds(0.05f);
        float counter = 0f;
        float time = 1f;
        float forceFactory = 5f;
        while (counter < time)
        {
            counter += 2 * Time.deltaTime;
            Vector3 direction = targetTR.position - transform.position;
            rb.AddForce(new Vector3(direction.x, -15f, direction.z) * forceFactory);
            yield return null;
        }
        collectActive = true;
    }
    IEnumerator RBSet()
    {
        yield return new WaitForSeconds(1f);
        rb.drag = 5;
    }
    IEnumerator ForceAppling2()
    {
        VibratoManager.Instance.LightVibration();
        transform.GetComponent<Fish>().jumpActive = false;
        //rb.AddForce(Vector3.up * 500);
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }
        rb.mass = 5;
        rb.drag = 5;
        Vector3 direction = targetTR.position - transform.position;

        rb.AddForce(new Vector3(4 * direction.x, 100f, 4 * direction.z) * 50f);
        if (pointActive)
        {
            StartCoroutine(PointCreate());
        }
        //rb = GetComponent<Rigidbody>();
        rb.isKinematic = false;
        GetComponent<Fish>().currentBehaviour = Fish.States.stopping;
        yield return new WaitForSeconds(0.05f);
        float counter = 0f;
        float time = 1f;
        float forceFactory = 5f;
        float holeSpeed = HoleUpgradeManager.Instance._holeUpgradeSettings.holeSpeed[Globals.holeSpeedLevel];
        rb.AddTorque(Vector3.up * 20 * holeSpeed);
        float force_Y;
        while (counter < time)
        {
            counter += 2 * Time.deltaTime;
            direction = targetTR.position - transform.position;
            rb.AddForce(new Vector3(4 * direction.x, 0, 4 * direction.z) * forceFactory * holeSpeed);
            yield return null;
        }
        StartCoroutine(ScaleDown());
        if (rb != null)
        {
            rb.isKinematic = true;

        }


        rb.drag = 7;
        time = 3f;
        counter = 0f;
        while (counter < time)
        {
            counter += 0.5f * Time.deltaTime;

            transform.localPosition = Vector3.Lerp(transform.localPosition, Vector3.zero, Time.deltaTime);

        

            //rb.AddForce(new Vector3(4 * direction.x, -1f, 4 * direction.z) * forceFactory * holeSpeed);
            yield return null;
        }
        collectActive = true;
    }
  
    IEnumerator ScaleDown()
    {
        firstSize = transform.localScale;
        float counter = 0f;
        float time = 1f;
        while (counter < time)
        {
            counter += 0.2f * Time.deltaTime;


            transform.localScale = Vector3.Lerp(firstSize, new Vector3(firstSize.x * 0.2f, firstSize.y * 0.2f, firstSize.z * 0.2f), counter);

            yield return null;


        }
        //StartCoroutine(ScaleReset());
    }
    IEnumerator ScaleReset()
    {
        Vector3 lastScale = transform.localScale;
        float counter = 0f;
        float time = 1f;
        while (counter < time)
        {
            counter += 2 * Time.deltaTime;


            transform.localScale = Vector3.Lerp(lastScale,firstSize, counter);

            yield return null;


        }
        transform.localScale = firstSize;
    }
    bool pointActive = true;
    IEnumerator PointCreate()
    {
        pointActive = false;
        yield return new WaitForSeconds(0.5f);
        Point pnt = Instantiate(point, targetTR.position, Quaternion.identity).GetComponent<Point>();
        pnt.pointValue = (1);
        //pnt.fishImage.sprite = fishImage;
        pnt.PointInit(collectLevel + 1);
        pnt.transform.parent = targetTR.parent.GetChild(0);
    }
    public void HitGround(Transform ground)
    {
        if (isGem)
        {
            FishManager.Instance.GemCreate();
        }
        else
        {
            FishManager.Instance.Fish_Create(rubbishID);
            StartCoroutine(PointCreate());

        }


        Globals.inLevelMoneyCount += earnMoney;
        StartCoroutine(HitDelay());

        for (int i = 0; i < coinCount; i++)
        { 
            Globals.collectCounter++;
        }
  
    }
    IEnumerator HitDelay()
    {
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
        EnvironmentList.Instance.collectEnvCounters[collectLevel]++;
        EnvironmentList.Instance.EnvLevelUpCheck();
        //Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if((collision.transform.tag == "Ground") && hitActive)
        {
            hitActive = false;
            FishManager.Instance._fishList.Remove(GetComponent<Fish>());
            HitGround(collision.transform);

            gameObject.GetComponent<Collider>().enabled = false;
            //Destroy(gameObject.GetComponent<Collider>());




            HoleManager.Instance.CollectEnv();
            //CollectProgressManager.Instance.CollectEnvCountSet();
            //CollectProgressManager.Instance.CollectEnvSliderSet(1);
            //CollectProgressManager.Instance.CollectEnvSliderSet(earnMoney);
        }
    }
    public void EnvReset()
    {
        StartCoroutine(ResetDelay());
    }
    IEnumerator ResetDelay()
    {
        yield return new WaitForSeconds(0.1f);
        transform.position = firstPos;
        transform.rotation = firstRot;


        gameObject.GetComponent<Collider>().enabled = true;
        hitActive = true;
        collectActive = true;
        triggerActive = true;
        GetComponent<Rigidbody>().isKinematic = true;
    }
}

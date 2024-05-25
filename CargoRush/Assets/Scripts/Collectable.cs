using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum CollectType
{
    Type1,
    Type2,
    Type3,
    Type4,
    Type5,
    Type6,
    All,
    Null
}
public class Collectable : MonoBehaviour
{
    //[SerializeField] public Animator animator;
    public bool grindActive = false;
    public float rawCount = 1;
    public CollectType collectType;

    float motionSpeed = 20;
    Transform target;
    public Transform ground;
    public bool isCollected = false;
    public bool collectActive = true;
    public bool productCollectActive = false;
    public bool rotateActive = true;
    //GameObject particle;
    public int collectID;
    [SerializeField] Transform spriteTR;
    public bool roofPushActive = true;

    public WorkArea fishArea;
    public int price;
    public List<Collectable> fishCollectable;
    public Vector3 firstSize;

    public List<Collectable> collectableList;
    public Animator anim;
    public bool isGem = false;
    public GameObject bantGO;
    public void Start()
    {
        firstSize = transform.localScale;
    }
    public void DisperseCollected(Transform impulseTR)
    {
        //roofPushActive = false;
        //StartCoroutine(RoofPushActivator());

        //PlayerPrefs.SetInt(malzemeName, 0);

        //rotateActive = true;
        //gameObject.AddComponent<Rigidbody>();
        if (GetComponent<Rigidbody>() == null)
        {
            gameObject.AddComponent<Rigidbody>();
        }
        //if (GetComponent<BoxCollider>() == null)
        //{
        //    gameObject.AddComponent<BoxCollider>();
        //}
        if (GetComponent<Rigidbody>() != null)
        {
            GetComponent<Rigidbody>().isKinematic = false;
            float[] xDirection = { -1, 1 };
            float[] zDirection = { -1, 1 };
            Vector3 impulseDir = (impulseTR.position - transform.position).normalized;
            GetComponent<Rigidbody>().AddForce(new Vector3(10 * impulseDir.x + Random.Range(-2f,2f), 10 * impulseDir.y, 10 * impulseDir.z + Random.Range(-2f, 2f)) * 80);
        }
        FishDropArea.Instance.proType[GetComponent<Collector>().productId].productList.Add(this);
        StartCoroutine(CollectActivator());

        //GetComponent<Rigidbody>().AddTorque(new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f), Random.Range(-2f, 2f)) * 50);
        //StartCoroutine(rotateCoin());
        //Destroy(gameObject, 4f);
    }
    IEnumerator CollectActivator()
    {
        yield return new WaitForSeconds(1f);
        collectActive = true;
        isCollected = false;
        GetComponent<Collector>().collectorActive = true;
    }
    IEnumerator RoofPushActivator()
    {
        yield return new WaitForSeconds(2f);
        roofPushActive = true;
    }
    public void CollectSave()
    {
        //PlayerPrefs.SetInt(malzemeName, PlayerPrefs.GetInt(malzemeName) + 1);
    }
    IEnumerator rotateCoin()
    {
        yield return new WaitForSeconds(0.3f);
        GetComponent<Rigidbody>().AddForce(-Vector3.up * 500);
        yield return new WaitForSeconds(0.3f);
        Destroy(GetComponent<Rigidbody>());
        GetComponent<Collider>().isTrigger = true;
        transform.position = new Vector3(transform.position.x, ground.position.y + 1f, transform.position.z);
        transform.rotation = Quaternion.Euler(0, 180, 0);
        yield return null;
        collectActive = true;

        //particle.SetActive(true);
        //particle.transform.position -= new Vector3(0, 1, 0);
        //particle.transform.parent = null;
        float counter = 0f;
        float val = 0f;
        //while (rotateActive)
        //{
        //    counter += Time.deltaTime;
        //    val = Mathf.Sin(counter);
        //    spriteTR.transform.localPosition =
        //    transform.Rotate(0, 200 * Time.deltaTime, 0);
        //    yield return null;
        //}
    }
   
    //IEnumerator targetMotion()
    //{
    //    particle.SetActive(false);

    //    GetComponent<SphereCollider>().enabled = false;
    //    float counter = 0f;
    //    float angle = 0f;
    //    Vector3 dirVect = (transform.position - target.position).normalized;



    //    while (counter < Mathf.PI / 2)
    //    {
    //        counter += 3 * Time.deltaTime;
    //        angle = 2 * Mathf.Cos(counter);

    //        transform.position = Vector3.MoveTowards(transform.position, transform.position + dirVect * angle + new Vector3(0, 0.5f, 0), counter * motionSpeed * Time.deltaTime);
    //        yield return null;
    //    }

    //    while (Vector3.Distance(transform.position, target.position) > 1f)
    //    {
    //        transform.position = Vector3.MoveTowards(transform.position, target.position, (40 / Vector3.Distance(transform.position, target.position)) * motionSpeed * Time.deltaTime);
    //        yield return null;
    //    }
    //    Destroy(particle);

    //    GameObject money = gameObject;
    //    money.transform.parent = null;
    //    Destroy(money);
    //}
    public void collect(Transform moneyTarget)
    {
        target = moneyTarget;
        //StartCoroutine(targetMotion());
    }
    public void CollectGem()
    {
        StartCoroutine(MoveUI(GameManager.Instance.ui.moneyTarget));

    }
    IEnumerator MoveUI(Transform _targetTR)
    {
        Vector3 _firstPos = transform.position;
        //firstScale = transform.localScale;
        Vector3 randomRotSpeed = new Vector3(Random.Range(0.5f, 2f), Random.Range(0.5f, 2f), Random.Range(0.5f, 2f));
        Vector3 tempPos = _targetTR.position;
        float counter = 0f;
        float speed = 4f;
        while (counter < 1f)
        {
            counter += speed * Time.deltaTime;
            speed = Mathf.Lerp(4f, 1f, counter);
            //transform.localScale = Vector3.Lerp(2 * firstScale, firstScale, counter);
            transform.position = Vector3.Lerp(_firstPos, new Vector3(_firstPos.x, _targetTR.position.y / 2, _firstPos.z), counter);
            transform.Rotate(randomRotSpeed);
            //transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);
            yield return null;
        }
        _firstPos = transform.position;
        //float maxDistance = Vector3.Distance(firstPos, targetPos);
        //float currentDistance = maxDistance;
        counter = 0f;
        float angle = 0f;
        float posY = 0f;
        float psoY_Factor = 2f;
        while (counter < 1f)
        {
            counter += speed * Time.deltaTime;
            speed = Mathf.Lerp(1f, 4f, counter);

            angle = counter * Mathf.PI;
            posY = psoY_Factor * Mathf.Sin(angle);

            //transform.localScale = Vector3.Lerp(2 * firstScale, firstScale, counter);
            tempPos = Vector3.Lerp(_firstPos, _targetTR.position, counter);
            transform.position = Vector3.Lerp(_firstPos, new Vector3(tempPos.x, _targetTR.position.y + posY, tempPos.z), counter);
            transform.Rotate(randomRotSpeed);
            //transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);
            yield return null;
        }
        transform.position = _targetTR.position;
        //transform.rotation = targetRot;
        //transform.localScale = firstScale;
        GameManager.Instance.GemUpdate(1);
        Destroy(gameObject);
    }
}

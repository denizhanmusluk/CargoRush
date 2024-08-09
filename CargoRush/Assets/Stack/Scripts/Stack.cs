using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour
{
    [SerializeField] int Pool_ID;
    [SerializeField] Transform stackPoint;

    [SerializeField] int firstStackAmount;
    [SerializeField] float stackDistance;

    [Range(1.0f, 30.0f)]
    [SerializeField] float oscillationHalfLife = 10f;
    [SerializeField] float turnSpeed = 100f;

    [Range(1.0f, 5.0f)]
    [SerializeField] float scaleRatio;
    [Range(1.0f, 10.0f)]
    [SerializeField] float scaleFrequency;

    [Range(1.0f, 30.0f)]
    [SerializeField] float scaleDamping;

    //[SerializeField] GameObject stackPrefab;
    [SerializeField] List<GameObject> stackObjects;
    Vector3 stackDirection;
    public enum StackAxis
    {
        X,
        rX,
        Y,
        rY,
        Z,
        rZ
    }
    public StackAxis StackAx;
    private void Awake()
    {
        switch (StackAx)
        {
            case StackAxis.X:
                {
                    stackDirection = Vector3.right;
                }
                break;
            case StackAxis.rX:
                {
                    stackDirection = -Vector3.right;
                }
                break;

            case StackAxis.Y:
                {
                    stackDirection = Vector3.up;
                }
                break;
            case StackAxis.rY:
                {
                    stackDirection = -Vector3.up;
                }
                break;

            case StackAxis.Z:
                {
                    stackDirection = Vector3.forward;
                }
                break;
            case StackAxis.rZ:
                {
                    stackDirection = -Vector3.forward;
                }
                break;
        }
    }
    void Start()
    {
        for (int i = 0; i < firstStackAmount; i++)
        {
            var stackObj = ObjectPool.Instance.GetPoolObject(0);
            //var stackObj = Instantiate(stackPrefab, transform.position + stackDirection * i * stackDistance, transform.rotation);
            stackObjects.Add(stackObj);
        }
    }
    public void addObject()
    {
        //Vector3 instantiatePosition = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
        //Quaternion instantiateRotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
        var stackObj = ObjectPool.Instance.GetPoolObject(Pool_ID);
        stackObj.transform.position = stackPoint.position;
        //var stackObj = Instantiate(stackPrefab, transform.position + instantiatePosition, instantiateRotation);
        stackObjects.Add(stackObj);
        throughlyScale();
    }
    public void dropObject()
    {
        if (stackObjects.Count > 0)
        {
            GameObject obj = stackObjects[stackObjects.Count - 1];
            stackObjects.Remove(obj);
            StartCoroutine(_dropObject(stackPoint, obj));
            throughlyScale();
        }
    }
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    addObject();
        //}

        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    dropObject();
        //}
    }
    void FixedUpdate()
    {
        if (stackObjects.Count > 0)
        {
            followObj(transform, stackObjects[0].transform);
        }
        for (int i = 0; i < stackObjects.Count - 1; i++)
        {
            followObj(stackObjects[i].transform, stackObjects[i + 1].transform);
        }
    }
    void followObj(Transform obj1,Transform obj2)
    {
        Vector3 targetPos = obj1.position;
        float followSpeed = Vector3.Distance(obj2.position, obj1.position);

        if (followSpeed > 0.5f)
        {
            followSpeed *= 2;
        }
        Vector3 followPosition = targetPos + stackDirection * stackDistance;
   
        obj2.position = Vector3.MoveTowards(obj2.position, followPosition, (followSpeed) * oscillationHalfLife * Time.deltaTime);
        obj2.position = Vector3.MoveTowards(obj2.position, new Vector3(obj2.position.x * (1 - Mathf.Abs(stackDirection.x)), obj2.position.y * (1 - Mathf.Abs(stackDirection.y)), obj2.position.z * (1 - Mathf.Abs(stackDirection.z))) + new Vector3(followPosition.x * Mathf.Abs(stackDirection.x), followPosition.y * Mathf.Abs(stackDirection.y), followPosition.z * Mathf.Abs(stackDirection.z)), oscillationHalfLife * Time.deltaTime);

        //stackObjects[i + 1].transform.position = Vector3.MoveTowards(stackObjects[i + 1].transform.position, stackObjects[i].transform.position + Vector3.up * stackDistance, oscillationHalfLife * Time.deltaTime);
        //float deltaRotY = obj2.eulerAngles.y - obj1.eulerAngles.y;
        float deltaRotY = Quaternion.Angle(obj2.rotation, obj1.rotation);

        if(deltaRotY > 10)
        {
            deltaRotY *= 2;
        }
        Debug.Log(deltaRotY);
        obj2.rotation = Quaternion.RotateTowards(obj2.rotation, obj1.rotation, Mathf.Abs(deltaRotY) * turnSpeed * Time.deltaTime);
    }


    public void throughlyScale()
    {
        StartCoroutine(scaleCalling());
    }
    IEnumerator scaleCalling()
    {
        int stackCount = stackObjects.Count;
        for (int i = 0; i < stackCount; i++)
        {
            StartCoroutine(throughlyScaling(stackObjects[stackCount - 1 - i].transform));
            yield return new WaitForSeconds(0.1f / scaleFrequency);
        }
    }
    IEnumerator throughlyScaling(Transform Tr)
    {
        float counter = 0f;
        float firstSize = 1f;
        float sizeDelta;
        while (counter < Mathf.PI)
        {
            counter += scaleDamping * Time.deltaTime;
            sizeDelta = (scaleRatio - 1) * (1f - Mathf.Abs(Mathf.Cos(counter)));
            //sizeDelta /= 3f;
            Tr.localScale = new Vector3(firstSize + sizeDelta, firstSize + sizeDelta, firstSize + sizeDelta);

            yield return null;
        }
        Tr.localScale = new Vector3(firstSize, firstSize, firstSize);
    }

   IEnumerator _dropObject(Transform targetPoint, GameObject dropObject)
    {
        float dropSpeed = 50;
        while (Vector3.Distance(targetPoint.position , dropObject.transform.position) > 0.1f)
        {
            dropObject.transform.position = Vector3.MoveTowards(dropObject.transform.position, targetPoint.position, dropSpeed * Time.deltaTime);
            yield return null;
        }
        ObjectPool.Instance.killPoolObject(dropObject.GetComponent<Iid>().id, dropObject);
    }
}

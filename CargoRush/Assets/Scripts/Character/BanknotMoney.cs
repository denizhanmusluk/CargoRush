using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanknotMoney : MonoBehaviour
{
    public int banknotValue;
    [HideInInspector] public Vector3 firstPos;
    //[HideInInspector] public Quaternion firstRot = Quaternion.Euler(0, 0, 0);

    [HideInInspector] public Vector3 targetPos;
    //[HideInInspector] public Quaternion targetRot;
    //[SerializeField] Vector3 firstScale;
    private void Start()
    {
        //firstPos = transform.position;
        //StartCoroutine(MoveMoney());
    }
    public void MoveObj(Vector3 _firstPos, Vector3 _targetPos)
    {
        Vector3 randomPos = new Vector3(Random.Range(-0.5f, 0.5f), 0, 0);
        firstPos = _firstPos + randomPos;
        targetPos = _targetPos;
        StartCoroutine(MoveMoney());
    }
    IEnumerator MoveMoney()
    {
        //firstScale = transform.localScale;
        Vector3 firstScale = transform.localScale;

        float counter = 0f;
        //float maxDistance = Vector3.Distance(firstPos, targetPos);
        //float currentDistance = maxDistance;
        float angle = 0f;
        float posY = 0f;
        float psoY_Factor = 4f;
        while (counter < 1f)
        {
            counter += 5 * Time.deltaTime;

            angle = counter * Mathf.PI;
            posY = psoY_Factor * Mathf.Sin(angle);
            transform.localScale = Vector3.Lerp(0.8f * firstScale, firstScale * 0.25f, counter);

            //transform.localScale = Vector3.Lerp(2 * firstScale, firstScale, counter);
            transform.position = Vector3.Lerp(firstPos, new Vector3(targetPos.x, targetPos.y + posY, targetPos.z), counter);
            //transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);
            yield return null;
        }
        transform.position = targetPos;
        //transform.rotation = targetRot;
        //transform.localScale = firstScale;
        Destroy(gameObject);
    }

    public void MovingMoney(Vector3 _firstPos, Vector3 _targetPos, Transform targetTR)
    {
        Vector3 randomPos = new Vector3(Random.Range(-0.5f, 0.5f), 0, 0);
        firstPos = _firstPos + randomPos;
        targetPos = _targetPos;
        StartCoroutine(MoveDropMoney(targetTR));
    }
    IEnumerator MoveDropMoney(Transform targetTR)
    {
        Quaternion targetRot = Quaternion.Euler(0, targetTR.eulerAngles.y + Random.Range(-15, 15), 0);
        Quaternion firstRot = transform.rotation;
        float counter = 0f;
        float moveSpeed = Random.Range(10f, 20f);
        //float maxDistance = Vector3.Distance(firstPos, targetPos);
        //float currentDistance = maxDistance;
        float angle = 0f;
        float posY = 0f;
        float psoY_Factor = 3f;
        while (counter < 1f)
        {
            counter += moveSpeed * Time.deltaTime;

            angle = counter * Mathf.PI;
            posY = psoY_Factor * Mathf.Sin(angle);

            transform.position = Vector3.Lerp(firstPos, new Vector3(targetPos.x, targetPos.y + posY, targetPos.z), counter);
            transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);
            yield return null;
        }
        transform.position = targetPos;
        //transform.rotation = targetRot;
        //transform.localScale = firstScale;
    }

    public void MovingMoneyUI(Vector3 _firstPos, Transform _targetTR)
    {
        //firstPos = _firstPos;
        //targetPos = _targetPos;
        StartCoroutine(MoveUI(_firstPos, _targetTR));
    }
    IEnumerator MoveUI(Vector3 _firstPos, Transform _targetTR)
    {
        //firstScale = transform.localScale;
        Vector3 randomRotSpeed = new Vector3(Random.Range(0.5f, 2f), Random.Range(0.5f, 2f), Random.Range(0.5f, 2f));
        Vector3 tempPos = _targetTR.position;
        float counter = 0f;
        float speed = Random.Range(25f, 40f);
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


        //GameManager.Instance.MoneyUpdate(banknotValue);
        Destroy(gameObject);
    }
}

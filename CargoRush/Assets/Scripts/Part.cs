using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Part : MonoBehaviour
{
    public int id;
    public int collectCount;
    [HideInInspector] public Vector3 firstPos;
    [HideInInspector] public Quaternion firstRot = Quaternion.Euler(0, 0, 0);

    [HideInInspector] public Vector3 targetPos;
    [HideInInspector] public Quaternion targetRot;
  [SerializeField]  Vector3 firstScale;
    public GameObject point;
    private void Start()
    {
    }

    public void MoveObj(GameObject _point)
    {
        point = _point;
        StartCoroutine(MoveObjToCar());
    }
    IEnumerator MoveObjToCar()
    {
        firstScale = transform.localScale;

        float counter = 0f;
        //float maxDistance = Vector3.Distance(firstPos, targetPos);
        //float currentDistance = maxDistance;
        float angle = 0f;
        float posY = 0f;
        float psoY_Factor = 7.5f;
        while(counter < 1f)
        {
            counter += 2 * Time.deltaTime;

            angle = counter * Mathf.PI;
            posY = psoY_Factor * Mathf.Sin(angle);

            transform.localScale = Vector3.Lerp(2 * firstScale, firstScale, counter);
            transform.position = Vector3.Lerp(firstPos, new Vector3( targetPos.x , targetPos.y + posY, targetPos.z), counter);
            transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter); 
            yield return null;
        }
        transform.position = targetPos;
        transform.rotation = targetRot;
        transform.localScale = firstScale;
        Scale(transform, 0.2f, 1f, 1f, Ease.OutElastic);
        GameObject pnt = Instantiate(point, transform.position, Quaternion.identity);
        pnt.GetComponent<Point>().pointValue = 1;
    }

    public Tween Scale( Transform prt, float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Vector3 _firstScale = prt.localScale;
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                prt.localScale = _firstScale * value;
            }).OnComplete(delegate ()
            {

            });
        return tween;
    }
    public void SetRigidbody(float time)
    {
        StartCoroutine(RigidSet(time));
    }
    IEnumerator RigidSet(float time)
    {
        yield return new WaitForSeconds(time);
        GetComponent<Rigidbody>().isKinematic = true;
    }
}

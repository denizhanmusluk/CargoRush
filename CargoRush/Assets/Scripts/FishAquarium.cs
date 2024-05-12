using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FishAquarium : MonoBehaviour
{
    public event Action following;

    public List<Transform> posList;
    Transform targetPosTR;
    public bool followActive = true;
    private void Update()
    {
        if (followActive)
        {
            following?.Invoke();
        }
    }
    public void TargetPosSelect()
    {
        int selectPosNo = UnityEngine.Random.Range(0, posList.Count);

        targetPosTR = posList[selectPosNo];
        following = null;
        following += GoToFishPos;
    }
    void GoToFishPos()
    {
        if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(targetPosTR.position.x, targetPosTR.position.z)) > 0.05f)
        {
            Vector3 _targetPosition = new Vector3(targetPosTR.position.x, transform.position.y, targetPosTR.position.z);
            Move(_targetPosition);
            SetRotToTarget(_targetPosition);
        }
        else
        {
            following = null;
            TargetPosSelect();
        }
    }
    void Move(Vector3 targetPosition)
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
    }
    void SetRotToTarget(Vector3 targetPosition)
    {
        Vector3 direction = (targetPosition - transform.position).normalized;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(Quaternion.LookRotation(direction).eulerAngles.x, Quaternion.LookRotation(direction).eulerAngles.y + 180, Quaternion.LookRotation(direction).eulerAngles.z), Time.deltaTime * 5);
        //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, Quaternion.LookRotation(direction).y, transform.eulerAngles.z);
        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(targetPosition), Time.deltaTime * 500);
    }
}

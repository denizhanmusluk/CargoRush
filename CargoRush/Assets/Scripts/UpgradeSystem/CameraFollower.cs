using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using ObserverSystem;

public class CameraFollower : MonoBehaviour
{
    public static Action OnUpdate;

    private static CameraFollower _instance = null;
    public static CameraFollower Instance => _instance;

    [SerializeField] public Transform targetFollow;
    [SerializeField] Transform firstPoint;
    [SerializeField] Transform lastPoint;
    [SerializeField] Transform currentPoint;
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        OnUpdate = null;

        //ObserverManager.Instance.RegisterObserver(this, SubjectType.GameState);//observer register
    }
    //public override void OnNotify(NotificationType notificationType) //observer notify
    //{
    //    switch (notificationType)
    //    {
    //        case NotificationType.Start:
    //            {
    //                OnUpdate += _Update;
    //            }
    //            break;
    //        case NotificationType.End:
    //            {
    //            }
    //            break;
    //        case NotificationType.Win:
    //            {
    //                OnUpdate = null;
    //            }
    //            break;
    //        case NotificationType.Fail:
    //            {
    //                OnUpdate = null;
    //            }
    //            break;

    //    }
    //}
    public void FollowStart()
    {
        OnUpdate += _Update;
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        OnUpdate?.Invoke();
    }
    void _Update()
    {
        transform.position = new Vector3(targetFollow.position.x, transform.position.y, transform.position.z);
        currentPoint.position = targetFollow.position;
        //transform.position = new Vector3(targetFollow.position.x, transform.position.y, transform.position.z);
        //if(targetFollow.position.z >= 0)
        //{
        //    currentPoint.position = Vector3.Lerp(firstPoint.position, lastPoint.position, targetFollow.position.z / 8f);
        //}
        //else
        //{
        //    currentPoint.position = firstPoint.position;
        //}
    }
}

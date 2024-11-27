using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using DG.Tweening;
using ObserverSystem;

public class CameraManager : Observer
{
    private static CameraManager _instance = null;
    public static CameraManager Instance => _instance;

    [SerializeField] float fovHoleFirst;
    [SerializeField] float fovHoleLast;
    [SerializeField] float fovHoleCurrent;
    [SerializeField] float fovHoleTarget;

    public CinemachineVirtualCamera vCamPlayer,vCamWithZoom;
    [SerializeField] float fovPlayerFirst;
    [SerializeField] float fovPlayerLast;
    [SerializeField] float fovPlayerCurrent;
    [SerializeField] float fovPlayerTarget;
    public CinemachineVirtualCamera vCamPlayerZoomIn;
    public CinemachineVirtualCamera vCamPlayerZoomInVip;

    float UpViewFOV = 0f;
    private void Awake()
    {
        UpViewFOV = fovHoleCurrent;

        _instance = this;
    }
    private void Start()
    {
        ObserverManager.Instance.RegisterObserver(this, SubjectType.GameState);//observer register
        //_holeUpgradeSettings = LevelManager.Instance._holeUpgradeSettings;

    }
    public override void OnNotify(NotificationType notificationType) //observer notify
    {
        switch (notificationType)
        {
            case NotificationType.Start:
                {
                    //FovSet();
                }
                break;
            case NotificationType.End:
                {

                }
                break;
            case NotificationType.Win:
                {
                
                }
                break;
            case NotificationType.Fail:
                {
                
                }
                break;

        }
    }

 
    public void PlayerCameraFovSet()
    {
        fovPlayerTarget = Mathf.Lerp(fovPlayerFirst, fovPlayerLast, (float)PlayerPrefs.GetInt("saleLevel") / (float)(AvailableForPurchase.Instance.saleBuilds.Count - 1));
        PlayerCameraFovSetValue(fovPlayerCurrent, fovPlayerTarget, 1f, Ease.InFlash);
        fovPlayerCurrent = fovPlayerTarget;
    }
    private Tween PlayerCameraFovSetValue(float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Tween tween = DOTween.To
          (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
          {
              vCamPlayer.m_Lens.FieldOfView = value; 
          }).OnComplete(delegate ()
          {
              vCamPlayer.m_Lens.FieldOfView = lastValue; 
          });
        return tween;
    }
}

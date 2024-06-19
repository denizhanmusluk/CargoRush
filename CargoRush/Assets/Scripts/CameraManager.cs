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

    public HoleUpgradeSettings _holeUpgradeSettings;
    public CinemachineVirtualCamera vCamHole;
    public Camera UICamHole;
    [SerializeField] float fovHoleFirst;
    [SerializeField] float fovHoleLast;
    [SerializeField] float fovHoleCurrent;
    [SerializeField] float fovHoleTarget;

    public CinemachineVirtualCamera vCamPlayer;
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
    public void FovSet()
    {
        fovHoleCurrent = Mathf.Lerp(fovHoleFirst, fovHoleLast, (float)Globals.holeLevel / (_holeUpgradeSettings.holeRadius.Length - 1));
        fovHoleTarget = fovHoleCurrent;
        CameraFovSetValue(fovHoleFirst, fovHoleTarget, 1f, Ease.InFlash);


        fovPlayerCurrent = Mathf.Lerp(fovPlayerFirst, fovPlayerLast, (float)PlayerPrefs.GetInt("saleLevel") / (float)(AvailableForPurchase.Instance.saleBuilds.Count - 1));
        fovPlayerTarget = fovPlayerCurrent;
        PlayerCameraFovSetValue(fovPlayerFirst, fovPlayerTarget, 1f, Ease.InFlash);

        //vCamHole.m_Lens.FieldOfView = Mathf.Lerp(fovFirst, fovLast, (float)Globals.holeLevel / 10f);
        //fovCurrent = Mathf.Lerp(fovFirst, fovLast, (float)Globals.holeLevel / 10f);
    }
    public void CameraFovUpView()
    {
        CameraFovSetValue(fovHoleCurrent, UpViewFOV, 1f, Ease.InFlash);
    }
    public void HoleCameraFovSet()
    {
        fovHoleTarget = Mathf.Lerp(fovHoleFirst, fovHoleLast, (float)Globals.holeLevel / (_holeUpgradeSettings.holeRadius.Length - 1));
        CameraFovSetValue(fovHoleCurrent, fovHoleTarget, 0.2f, Ease.InFlash);
        fovHoleCurrent = fovHoleTarget;

        FishManager.Instance.transform.localScale = Vector3.Lerp(Vector3.one * FishManager.Instance.firstSize, Vector3.one * FishManager.Instance.lastSize, ((float)Globals.holeLevel + Globals.holeSpeedLevel) / ((_holeUpgradeSettings.holeRadius.Length - 1) + (_holeUpgradeSettings.holeSpeed.Length - 1)));
    }
    private Tween CameraFovSetValue(float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Tween tween = DOTween.To
          (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
          {
              vCamHole.m_Lens.FieldOfView = value;
              UICamHole.fieldOfView = value;
          }).OnComplete(delegate ()
          {
              vCamHole.m_Lens.FieldOfView = lastValue;
              UICamHole.fieldOfView = lastValue;
          });
        return tween;
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

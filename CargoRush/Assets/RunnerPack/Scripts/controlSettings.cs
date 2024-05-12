using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/Character/ControlSettings")]
public class controlSettings : ScriptableObject
{
    [Range(1.0f, 100.0f)]

    [SerializeField] private float SmoothStop = 30f;
    public float _SmoothStop { get { return SmoothStop; } }



    [Header("Runner")]
    [SerializeField] private float runnerMoveSpeed = 5f;
    public float _runnerMoveSpeed { get { return runnerMoveSpeed; } }


    [Range(0.0f, 10.0f)]

    [SerializeField] private float controlSensivity = 10f;
    public float _controlSensivity { get { return controlSensivity; } }


    [Range(0.0f, 45.0f)]
    [SerializeField] private float turnAngle = 5f;
    public float _turnAngle { get { return turnAngle; } }

    [SerializeField] private float turnSpeed = 5f;
    public float _turnSpeed { get { return turnSpeed; } }

    [Range(0.0f, 10.0f)]

    [SerializeField] private float HorizontalBounding = 10f;
    public float _HorizontalBounding { get { return HorizontalBounding; } }

    ////////////////////////////////////////


    [Header("Swing")]

    [SerializeField] private float swingMoveSpeed = 5f;
    public float _swingMoveSpeed { get { return swingMoveSpeed; } }



    [Range(0.0f, 10.0f)]

    [SerializeField] private float swingSensivity = 10f;
    public float _swingSensivity { get { return swingSensivity; } }



    [SerializeField] private float turnSmooth = 5f;
    public float _turnSmooth { get { return turnSmooth; } }


    [SerializeField] private float maxTurnAngle = 5f;
    public float _maxTurnAngle { get { return maxTurnAngle; } }

    [Header("Joy Stick")]

    [SerializeField] private float joystickMoveSpeed = 10f;
    public float _JoystickMoveSpeed { get { return joystickMoveSpeed; } }


    [Range(1.0f, 10.0f)]

    [SerializeField] private float sensivity = 10f;
    public float _sensivity { get { return sensivity; } }
}


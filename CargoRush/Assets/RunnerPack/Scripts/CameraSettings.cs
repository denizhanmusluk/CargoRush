using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Camera/CameraSettings")]

public class CameraSettings : ScriptableObject
{
    [Header("Horizontal Damping")]

    [Range(0.0f, 1.0f)]
    [SerializeField] private float HorizontalDamping = 0.5f;
    public float _HorizontalDamping { get { return HorizontalDamping; } }

    //[Range(0.0f, 1.0f)]
    //[SerializeField] private float HorizontalDampingSpeed = 0.5f;
    //public float _HorizontalDampingSpeed { get { return HorizontalDampingSpeed; } }


    [Header("Vertical Damping")]


    [Range(0.0f, 1.0f)]
    [SerializeField] private float VerticalDamping = 0.5f;
    public float _VerticalDamping { get { return VerticalDamping; } }



    [Range(0.0f, 10.0f)]
    [SerializeField] private float VerticalDampingSpeed = 5f;
    public float _VerticalDampingSpeed { get { return VerticalDampingSpeed; } }

}

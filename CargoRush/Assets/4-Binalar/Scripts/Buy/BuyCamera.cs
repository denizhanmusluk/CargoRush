using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public interface BuyCamera
{
    CinemachineVirtualCamera buyCamera { get; set; }

     bool viewThisCamera { get; set; }

}

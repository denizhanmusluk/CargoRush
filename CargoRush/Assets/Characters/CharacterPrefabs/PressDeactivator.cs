using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressDeactivator : MonoBehaviour
{
    public void PressCharacterControl_Deactive()
    {
        PlayerController.Instance.pressActive = false;
        GameManager.Instance.ui.joyStick.GetComponent<FloatingJoystick>().PointerUpManuel();
        GameManager.Instance.ui.joyStick.SetActive(false);
    }
    public void PressCharacterControl_Active()
    {
        PlayerController.Instance.pressActive = true;
        GameManager.Instance.ui.joyStick.SetActive(true);
    }
}

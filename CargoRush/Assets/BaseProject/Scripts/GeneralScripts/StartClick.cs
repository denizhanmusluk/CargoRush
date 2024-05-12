using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine;

public class StartClick : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventdata)
    {
       //GameManager.Instance.ui.joyStick.GetComponent<FloatingJoystick>().FirstClick(eventdata);
    }

}

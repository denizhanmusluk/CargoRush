using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public float extraSpeed;
    public int extraStack;
    public Vector3 idleOffsetPos;
    public Vector3 runOffsetPos;

    public Vector3 idleRotOffset;
    public Vector3 runRotOffset;
    public List<FlameThrower> flameThrowers;
    private void OnEnable()
    {
        //PlayerController.Instance._board = this;
        Globals.extraSpeed = extraSpeed;
        //Globals.extraStack = extraStack;
    }
    private void OnDisable()
    {
        Globals.extraSpeed = 1;
        //PlayerController.Instance._board = null;
    }
    private void Update()
    {
        if (PlayerController.Instance.pressJoystick)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, runOffsetPos, 50 * Time.deltaTime);
            transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler( runRotOffset.x, runRotOffset.y, runRotOffset.z), 15 * Time.deltaTime);
        }
        else
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, idleOffsetPos, 50 * Time.deltaTime);
            transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(idleRotOffset.x, idleRotOffset.y, idleRotOffset.z), 15 * Time.deltaTime);

        }
    }
}

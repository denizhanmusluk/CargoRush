using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float extraSpeed;
    public int extraStack;
    public int extraMoney;
    public float machineSpeed;
    public Transform hoverboardCreatePos;
    public bool blendShapeActive = false;
    private void OnEnable()
    {
        StartCoroutine(EnableDelay());
    }
    IEnumerator EnableDelay()
    {
        yield return new WaitForSeconds(0.5f);
        if (true)
        {
            Globals.extraSpeedSkins = extraSpeed;
            Globals.extraStackSkin = extraStack;
            Globals.extraMoneySkin = extraMoney;
            Globals.machineSpeedSkin = machineSpeed;
            PlayerController.Instance.hoverBoardCreatePos = hoverboardCreatePos;
            PlayerController.Instance._player = this;
        }
    }
}

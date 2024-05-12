using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TShirt : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hanger;
    public void HangerOpen()
    {
        hanger.SetActive(true);
    }
    public void HangerClose()
    {
        hanger.SetActive(false);
    }
}

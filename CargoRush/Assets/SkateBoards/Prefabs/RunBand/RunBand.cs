using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunBand : MonoBehaviour
{
    public Animator anim;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AnimActive();
        }
        if (Input.GetMouseButtonUp(0))
        {
            AnimPassive();
        }
    }
    void AnimActive()
    {
        anim.SetBool("run", true);
    }
    void AnimPassive()
    {
        anim.SetBool("run", false);
    }
}

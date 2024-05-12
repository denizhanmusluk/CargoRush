using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnceOpen : MonoBehaviour
{
    [SerializeField] string _name;
    void OnEnable()
    {
        if(PlayerPrefs.GetInt(_name) == 0)
        {
            PlayerPrefs.SetInt(_name, 1);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }


}

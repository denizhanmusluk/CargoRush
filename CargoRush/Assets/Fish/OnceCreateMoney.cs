using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnceCreateMoney : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string moneyName;
    void Start()
    {
        if(PlayerPrefs.GetInt(moneyName) != 0)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetInt(moneyName, 1);
    }
}

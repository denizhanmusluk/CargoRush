using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyRewardedManager : MonoBehaviour
{
    private static DailyRewardedManager _instance = null;
    public static DailyRewardedManager Instance => _instance;
    private void Awake()
    {
        _instance = this;
    }


    void CheckAndSaveDate()
    {
        System.DateTime date = System.DateTime.Now;
        string tarih = date.ToString("dd/MM/yyyy");

        Debug.Log("kayitliTarih " + PlayerPrefs.GetString("kayitliTarih") + "  " + tarih);

        if (PlayerPrefs.GetString("kayitliTarih") != tarih)
        {
            PlayerPrefs.SetString("kayitliTarih", tarih);

        }


        PlayerPrefs.Save();
    }
    void ResetDailyRewarded()
    {

    }
}

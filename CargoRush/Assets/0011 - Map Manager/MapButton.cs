using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapButton : MonoBehaviour
{
    [SerializeField] int levelIndex;
    public void MapButtonClick()
    {
        MapManager.Instance.NewLevelSelect(levelIndex);
        AudioManager.Instance.ButtonSound();

        if (PlayerPrefs.GetInt("mapbuttonfirstclck") == 1)
        {
            PlayerPrefs.SetInt("mapbuttonfirstclck", 2);
      

        }
    }
}
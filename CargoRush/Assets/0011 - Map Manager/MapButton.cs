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
    }
}
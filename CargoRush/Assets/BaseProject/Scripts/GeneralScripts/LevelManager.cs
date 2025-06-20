using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public class LevelManager : Singleton<LevelManager>
{
    public GameObject loadedLevel;

    [SerializeField] private List<LevelScriptable> levelList;
    [SerializeField] private List<MissionSettings> _missionSettings;
    public MissionSettings currentMissionSettings;

    [SerializeField] private List<CharacterUpgradeSettings> _CharacterUpgradeSettings;
     public CharacterUpgradeSettings _currnetCharacterUpgradeSettings;




   public void levelInit()
    {
        Globals.LevelCount = levelList.Count;
        if (levelList.Count > 0)
        {
            levelLoad();
        }
    }
    void levelLoad()
    {
        if (PlayerPrefs.GetInt("levelIndex") != 0)
        {
            Globals.currentLevel = PlayerPrefs.GetInt("levelIndex");

        }
        else
        {
            PlayerPrefs.SetInt("levelIndex", Globals.currentLevel);

        }
        //PlayerPrefs.SetInt("level", 0);
        if (PlayerPrefs.GetInt("level") != 0)
        {
            Debug.Log(PlayerPrefs.GetInt("level"));
            Globals.currentLevelIndex = PlayerPrefs.GetInt("level");

        }


        loadedLevel = Instantiate(levelList[Globals.currentLevelIndex]._levelPrefab, transform.position, Quaternion.identity);
        currentMissionSettings = _missionSettings[Globals.currentLevelIndex];
        _currnetCharacterUpgradeSettings = _CharacterUpgradeSettings[Globals.currentLevelIndex];
    }
}

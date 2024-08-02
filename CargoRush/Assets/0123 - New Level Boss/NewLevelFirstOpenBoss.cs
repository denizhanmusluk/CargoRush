using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLevelFirstOpenBoss : MonoBehaviour
{
    public string bossName;
    public BossCharacterSecond bossCharacterSecond;
    public Transform exitPosTR;
    public GameObject popUp1_GO;

    void Start()
    {
        if (PlayerPrefs.GetInt(bossName + PlayerPrefs.GetInt("level")) == 0)
        {
            BossActive();
        }
    }

    void BossActive()
    {
        bossCharacterSecond.gameObject.SetActive(true);
        StartCoroutine(GoOut());
    }
    IEnumerator GoOut()
    {
        yield return new WaitForSeconds(10f);
        popUp1_GO.SetActive(false);
        bossCharacterSecond.GoExit(exitPosTR);
    }
}

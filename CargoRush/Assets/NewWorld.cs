using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWorld : MonoBehaviour
{
    [SerializeField] int nextLevelIndex;
    void Start()
    {
        //IndicatorManager.Instance.IndicaorActive(transform);
    }

    private void OnEnable()
    {
        StartCoroutine(ResetDelay());
    }
    IEnumerator ResetDelay()
    {
        //if (MissionManager.Instance.newMapMission.gameObject.activeInHierarchy)
        //{
        //    MissionManager.Instance.newMapMission.MissionUpdate();
        //}
        PlayerController.Instance.PlayerControlDeActive();
        float firstSize = CameraManager.Instance.vCamPlayer.m_Lens.OrthographicSize;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 1f * Time.deltaTime;
            CameraManager.Instance.vCamPlayer.m_Lens.OrthographicSize = Mathf.Lerp(firstSize, 12f, counter);

            yield return null;
        }

        yield return new WaitForSeconds(0.5f);
        Fade.Instance.Hide();
        //yield return new WaitForSeconds(0.5f);
        PlayerPrefs.SetInt("level", nextLevelIndex);
        Globals.currentLevelIndex = PlayerPrefs.GetInt("level");

        //PlayerPrefs.DeleteAll();
        yield return new WaitForSeconds(0.5f);
        Globals.collectableLevel = 0;
         PlayerPrefs.SetInt("magnetRadiusLevel" , 0);
        PlayerPrefs.SetInt("characterSpeedLevel", 0);
        PlayerPrefs.SetInt("stackCapacityLevel", 0);

        PlayerPrefs.SetInt("workerMoveSpeedLevel",0);
        PlayerPrefs.SetInt("workerCapacityLevel",0);
        PlayerPrefs.SetInt("workerNoLevel",0);
        PlayerPrefs.SetInt("machineLevel",0);


        GameManager.Instance.OnLevelRestart();
    }
}

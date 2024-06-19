using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewWorldActive : MonoBehaviour
{
    [SerializeField] int nextLevelIndex;
    [SerializeField] Image _slider;
    bool cooldown = true;
    bool upgradeOpenActive = false;
    bool opened = false;

    void Start()
    {
        PlayerPrefs.SetInt("newworldactivation", 1);
        MapManager.Instance.MapButtonActive();
        if (nextLevelIndex > PlayerPrefs.GetInt("mapindexmax"))
        {
            PlayerPrefs.SetInt("mapindexmax", nextLevelIndex);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            upgradeOpenActive = true;
            StartCoroutine(CooldownActive(0.7f));
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            upgradeOpenActive = false;
        }
    }

    IEnumerator CooldownActive(float time)
    {
        float counter = 0f;
        while (counter < time && upgradeOpenActive)
        {
            counter += Time.deltaTime;
            _slider.fillAmount = counter / time;
            yield return null;
        }
        if (counter >= time)
        {
            upgradeOpenActive = false;
            NextLevel();
            StartCoroutine(CooldownPasive());
        }
        else
        {
            StartCoroutine(CooldownPasive());
        }
    }
    IEnumerator CooldownPasive()
    {
        float lastValue = _slider.fillAmount;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 4 * Time.deltaTime;
            _slider.fillAmount = Mathf.Lerp(lastValue, 0, counter);

            yield return null;
        }
    }
    private void NextLevel()
    {
        if (!opened)
        {
            opened = true;
            StartCoroutine(ResetDelay());
        }
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
        PlayerPrefs.SetInt("prelevel", PlayerPrefs.GetInt("level"));

        PlayerPrefs.SetInt("level", nextLevelIndex);
        Globals.currentLevelIndex = PlayerPrefs.GetInt("level");

        //PlayerPrefs.DeleteAll();
        yield return new WaitForSeconds(0.5f);
        GameManager.Instance.OnLevelRestart();
    }
}
//public class NewWorldActive : MonoBehaviour
//{
//    [SerializeField] int nextLevelIndex;
//    [SerializeField] Image _slider;
//    bool cooldown = true;
//    bool upgradeOpenActive = false;
//    bool opened = false;

//    void Start()
//    {

//    }
//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.GetComponent<PlayerController>() != null)
//        {
//            upgradeOpenActive = true;
//            StartCoroutine(CooldownActive(0.7f));
//        }
//    }
//    private void OnTriggerExit(Collider other)
//    {
//        if (other.GetComponent<PlayerController>() != null)
//        {
//            upgradeOpenActive = false;
//        }
//    }

//    IEnumerator CooldownActive(float time)
//    {
//        float counter = 0f;
//        while (counter < time && upgradeOpenActive)
//        {
//            counter += Time.deltaTime;
//            _slider.fillAmount = counter / time;
//            yield return null;
//        }
//        if (counter >= time)
//        {
//            upgradeOpenActive = false;
//            NextLevel();
//            StartCoroutine(CooldownPasive());
//        }
//        else
//        {
//            StartCoroutine(CooldownPasive());
//        }
//    }
//    IEnumerator CooldownPasive()
//    {
//        float lastValue = _slider.fillAmount;
//        float counter = 0f;
//        while (counter < 1f)
//        {
//            counter += 4 * Time.deltaTime;
//            _slider.fillAmount = Mathf.Lerp(lastValue, 0, counter);

//            yield return null;
//        }
//    }
//    private void NextLevel()
//    {
//        if (!opened)
//        {
//            opened = true;
//            StartCoroutine(ResetDelay());
//        }
//    }
//    IEnumerator ResetDelay()
//    {
//        //if (MissionManager.Instance.newMapMission.gameObject.activeInHierarchy)
//        //{
//        //    MissionManager.Instance.newMapMission.MissionUpdate();
//        //}
//        PlayerController.Instance.PlayerControlDeActive();
//        float firstSize = CameraManager.Instance.vCamPlayer.m_Lens.OrthographicSize;
//        float counter = 0f;
//        while(counter < 1f)
//        {
//            counter += 1f * Time.deltaTime;
//            CameraManager.Instance.vCamPlayer.m_Lens.OrthographicSize = Mathf.Lerp(firstSize, 12f, counter);

//            yield return null;
//        }

//        yield return new WaitForSeconds(0.5f);
//        Fade.Instance.Hide();
//        //yield return new WaitForSeconds(0.5f);
//        PlayerPrefs.SetInt("level", nextLevelIndex);
//        Globals.currentLevelIndex = PlayerPrefs.GetInt("level");

//        //PlayerPrefs.DeleteAll();
//        yield return new WaitForSeconds(0.5f);
//        GameManager.Instance.OnLevelRestart();
//    }
//}

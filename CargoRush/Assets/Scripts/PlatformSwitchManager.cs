using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlatformSwitchManager : MonoBehaviour
{
    private static PlatformSwitchManager _instance = null;
    public static PlatformSwitchManager Instance => _instance;
    [SerializeField] CinemachineVirtualCamera characterCam;
    public GameObject bottomLight;
    private void Awake()
    {
        _instance = this;
    }
    public void SwitchToBottom()
    {
        Globals.holePlatformActive = false;

        if (PlayerPrefs.GetInt("skinactive") == 1)
        {
            StoreManager.Instance.storeButton.SetActive(true);
        }
        GameManager.Instance.ui.moneyPanel.SetActive(true);

        bottomLight.SetActive(true);




        Globals.stackActive = true;

        PlayerController.Instance.firstPressPos = Vector2.zero;
        PlayerController.Instance.GameStart();
        PlayerController.Instance._stackCollect.collectActive = true;

        StartCoroutine(CameraSetIdle());

    }
    IEnumerator CameraSetIdle()
    {
        Fade.Instance.Show();
        var a = Camera.main.GetComponent<CinemachineBrain>().m_DefaultBlend.m_Time;
        Camera.main.GetComponent<CinemachineBrain>().m_DefaultBlend.m_Time = 0;

        characterCam.Priority = 1;

        yield return new WaitForSeconds(1f);
        Camera.main.GetComponent<CinemachineBrain>().m_DefaultBlend.m_Time = a;
        //DnzEvents.AIworkerStart();

    }
}

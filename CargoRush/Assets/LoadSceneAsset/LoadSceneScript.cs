using System.Collections;
using System.Collections.Generic;
//using Facebook.Unity;
using UnityEngine;
using UnityEngine.SceneManagement;
//using HomaGames.HomaBelly;

public class LoadSceneScript : MonoBehaviour
{
    public string StartSceneName = "MainScene";
    public float StartDelaySecond = 5f;
    public Animator StartAnimator;
    public void Awake()
    {
        //if (!HomaBelly.Instance.IsInitialized)
        //{
        //    Events.onInitialized += OnInitialized;
        //}
        //else
        //{
        //}
    }

    private void OnDisable()
    {
        //Events.onInitialized -= OnInitialized;
    }

    private void OnInitialized()
    {
        // Homa Belly initialized, call any Homa Belly method
    }
    void Start()
    {

        //GameAnalyticsSDK.GameAnalytics.Initialize();
        StartCoroutine(StartDelayFunction());
        StartCoroutine(StartDelayAnimationFunction());
    }


    public IEnumerator StartDelayFunction()
    {
        yield return new WaitForSeconds(StartDelaySecond);
        SceneManager.LoadScene("MainScene");
    }
    public IEnumerator StartDelayAnimationFunction()
    {
        yield return new WaitForSeconds(0.5f);
        StartAnimator.SetTrigger("Start");
    }
}


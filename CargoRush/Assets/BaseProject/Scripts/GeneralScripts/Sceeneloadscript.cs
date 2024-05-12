using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using HomaGames.HomaBelly;

public class Sceeneloadscript : MonoBehaviour
{
	public void Awake()
	{
		//if (!HomaBelly.Instance.IsInitialized)
		//{
		//	// Listen event for initialization
		//	Events.onInitialized += OnInitialized;
		//}
		//else
		//{
		//	// Homa Belly already initialized
		//}
	}
	void Start()
    {
		//DefaultAnalytics.MainMenuLoaded();
		//Debug.Log("DefaultAnalytics.MainMenuLoaded();");
		//GameAnalyticsSDK.GameAnalytics.Initialize();
		SceneManager.LoadScene("MainScene");
    }
	private void OnDisable()
	{
		//Events.onInitialized -= OnInitialized;
	}

	private void OnInitialized()
	{
		// Homa Belly initialized, call any Homa Belly method
	}
}


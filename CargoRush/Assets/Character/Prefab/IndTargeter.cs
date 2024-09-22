using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HomaGames.HomaBelly;

public class IndTargeter : MonoBehaviour
{
    public string targeterName;
    bool collisionActive = true;
    [SerializeField] float delayTime;
    [SerializeField] bool indicatorActivatorActive;
    [SerializeField] bool tutorialCompleter = false;
    [SerializeField] int tutorialStepIndex;
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerController>() != null)
        {
            if(PlayerPrefs.GetInt(targeterName) == 0)
            {
                if (collisionActive)
                {
                    collisionActive = false;

                    PlayerPrefs.SetInt(targeterName, 1);
                    IndicatorManager.Instance.IndicaorDeActive();
                    StartCoroutine(SetDelay());
                    if (tutorialCompleter)
                    {
                        //PlayerPrefs.SetInt("tutorialcompleted", 1);
                        //TutorialManager.Instance.TutorialCompletedCheck();
                    }
                }
            }
        }
    }
    IEnumerator SetDelay()
    {
        yield return new WaitForSeconds(delayTime);
        if (indicatorActivatorActive)
        {
            IndicatorManager.Instance.IndicatorTargeterActive();
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
    private void OnEnable()
    {
        if (PlayerPrefs.GetInt(targeterName) == 0)
        {
            IndicatorManager.Instance.TutorialStepStart(tutorialStepIndex);
        }
    }
    private void OnDisable()
    {
        IndicatorManager.Instance.TutorialStepCompleted();
    }

}

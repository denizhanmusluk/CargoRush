using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlatformSwitchManager.Instance.dropTheJunksGO = gameObject;
        gameObject.SetActive(false);
    }
}

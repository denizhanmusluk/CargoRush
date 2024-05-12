using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TutorialPanel : MonoBehaviour
{
    [SerializeField] GameObject tutorial1GO;
    [SerializeField] GameObject tutorial2GO;
    public void Tutorial_PanelClose()
    {
        tutorial1GO.SetActive(false);
        //StartCoroutine(TutorialPanelClose());
        TutorialPanel2_Open();
    }
    IEnumerator TutorialPanelClose()
    {
        float counter = 0;
        float SimulationSpeed = 1f;
        while (counter < 1f)
        {
            counter += SimulationSpeed * Time.deltaTime;

            foreach (var img in transform.GetComponentsInChildren<Image>())
            {
                img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.Abs(1 - counter));
            }
            foreach (var img in transform.GetComponentsInChildren<TextMeshProUGUI>())
            {
                img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.Abs(1 - counter));
            }
            yield return null;
        }
        gameObject.SetActive(false);

    }
    public void TutorialPanel2_Open()
    {
        tutorial2GO.SetActive(true);
        StartCoroutine(SetDelayTutorial());
    }
    IEnumerator SetDelayTutorial()
    {
        yield return new WaitForSeconds(6f);
        StartCoroutine(TutorialPanelClose());
        GameManager.Instance.ui.startCanvas.SetActive(true);
    }
}

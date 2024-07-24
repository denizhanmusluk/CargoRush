using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

public class GraphManager : MonoBehaviour
{
    public List<HisseCompany> allHisseData;
    public RectTransform graphContainer;
    public Sprite circleSprite;
    public Color[] lineColors;
    public float lineWidth = 0.2f; // Çizgi kalýnlýðý için yeni bir deðiþken ekledik.

    private void Start()
    {
        StartCoroutine(StartDelay());
    }

    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(2f);
        StartCoroutine(SetGraph());
    }
    public bool openedShareUI = false;
    IEnumerator SetGraph()
    {
        while (true)
        {


            if (openedShareUI)
            {
                DrawGraph();

                yield return new WaitForSeconds(1f);
                if (graphContainer != null)
                {
                    foreach (Transform child in graphContainer.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
            }
            else
            {
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
    private void DrawGraph()
    {
        float maxShareValue = FindMaxShareValue(); // Tüm þirketler için maksimum hisse deðerini buluyoruz

        foreach (HisseCompany data in allHisseData)
        {
            DrawHisseData(data, maxShareValue);
        }
    }

    private void DrawHisseData(HisseCompany data, float maxShareValue)
    {
        GameObject lastCircle = null;
        LineRenderer lineRenderer = new GameObject(data.companyName).AddComponent<LineRenderer>();
        lineRenderer.transform.SetParent(graphContainer, false);
        lineRenderer.positionCount = data.shareValues.Count;
        lineRenderer.startColor = lineColors[allHisseData.IndexOf(data)];
        lineRenderer.endColor = lineColors[allHisseData.IndexOf(data)];
        lineRenderer.startWidth = lineWidth; // Çizgi kalýnlýðýný ayarladýk.
        lineRenderer.endWidth = lineWidth;   // Çizgi kalýnlýðýný ayarladýk.

        for (int i = 0; i < data.shareValues.Count; i++)
        {
            float xPosition = Mathf.Lerp(0, graphContainer.sizeDelta.x, (float)i / (data.shareValues.Count - 1)); // x pozisyonunu zaman damgasýna göre oranladýk
            float yPosition = Mathf.Lerp(0, graphContainer.sizeDelta.y, data.shareValues[i] / maxShareValue); // y pozisyonunu hisse deðerine göre oranladýk
            Vector3 point = new Vector3(xPosition, yPosition);
            lineRenderer.SetPosition(i, point);

            GameObject circle = CreateCircle(new Vector2(xPosition, yPosition), data);
            if (lastCircle != null)
            {
                CreateLine(lastCircle.GetComponent<RectTransform>().anchoredPosition, circle.GetComponent<RectTransform>().anchoredPosition, data);
            }
            lastCircle = circle;
        }
        lineRenderer.gameObject.SetActive(false);
    }

    private GameObject CreateCircle(Vector2 anchoredPosition, HisseCompany data)
    {
        GameObject circle = new GameObject("circle", typeof(Image));
        circle.transform.SetParent(graphContainer, false);
        circle.GetComponent<Image>().sprite = circleSprite;
        RectTransform rectTransform = circle.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = anchoredPosition;
        rectTransform.sizeDelta = new Vector2(5, 5);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        rectTransform.GetComponent<Image>().color = lineColors[allHisseData.IndexOf(data)];

        return circle;
    }

    private void CreateLine(Vector2 pointA, Vector2 pointB, HisseCompany data)
    {
        GameObject line = new GameObject("line", typeof(Image));
        line.transform.SetParent(graphContainer, false);
        RectTransform rectTransform = line.GetComponent<RectTransform>();
        Vector2 direction = (pointB - pointA).normalized;
        float distance = Vector2.Distance(pointA, pointB);
        rectTransform.sizeDelta = new Vector2(distance, lineWidth); // Çizgi kalýnlýðýný ayarladýk.
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        rectTransform.anchoredPosition = pointA + direction * distance * 0.5f;
        rectTransform.localEulerAngles = new Vector3(0, 0, Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg);
        rectTransform.GetComponent<Image>().color = lineColors[allHisseData.IndexOf(data)];
    }

    private float FindMaxShareValue()
    {
        float max = 0f;
        foreach (HisseCompany data in allHisseData)
        {
            float localMax = data.shareValues.Max();
            if (localMax > max)
            {
                max = localMax;
            }
        }
        return max;
    }
}

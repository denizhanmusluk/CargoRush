using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Point : MonoBehaviour
{
    [SerializeField] Color _color;
    [Range(0, 1)] [SerializeField] int alpha;
    [Range(0, 20)] [SerializeField] float UpwardSpeed;
/*    [Range(0, 4)] [SerializeField]*/ float SimulationSpeed;
    [SerializeField] Vector2 randomSpeed;
   public TextMeshProUGUI PointText;
    public int pointValue;
    public Image fishImage;
    private void Start()
    {
        SimulationSpeed = Random.Range(randomSpeed.x, randomSpeed.y);
        PointText.color = _color;
        //foreach (var txt in GetComponentsInChildren<TextMeshProUGUI>())
        //{
        //    PointText = txt;
        //}
        StartCoroutine(pointUp());
        //StartCoroutine(colorSet(alpha));
        PointText.text = "+"+pointValue.ToString();
    }
    public void PointInit(int pointValue)
    {
        PointText.text = "+" + pointValue.ToString();
    }
    IEnumerator pointUp()
    {

        float counter = 0;
        float spd = 0;
        while (counter < Mathf.PI / 2)
        {
            counter += SimulationSpeed * Time.deltaTime;
            spd = Mathf.Cos(counter);
            spd *= UpwardSpeed;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + new Vector3(0, 1, 0), Time.deltaTime * spd);

            yield return null;
        }
        StartCoroutine(colorSet(alpha));
    }
    IEnumerator colorSet(float _alpha)
    {
        float counter = 0;
        while (counter < Mathf.PI / 2)
        {
            counter += 4 * SimulationSpeed * Time.deltaTime;
            float currentAlpha = (counter / (Mathf.PI / 2));
            PointText.color = new Color(PointText.color.r, PointText.color.g, PointText.color.b, Mathf.Abs(_alpha - currentAlpha));
            fishImage.color = new Color(fishImage.color.r, fishImage.color.g, fishImage.color.b, Mathf.Abs(_alpha - currentAlpha));
            yield return null;
        }
        Destroy(gameObject);
    }
}

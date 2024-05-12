using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SizeUp : MonoBehaviour
{
    [SerializeField] Color _color;
    [Range(0, 1)] [SerializeField] int alpha;
    [Range(0, 20)] [SerializeField] float UpwardSpeed;
    [Range(0, 10)] [SerializeField]
    float SimulationSpeed;
    public TextMeshProUGUI PointText;
    private void Start()
    {
        PointText.color = _color;
        StartCoroutine(pointUp());
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
            yield return null;
        }
        Destroy(gameObject);
    }
}

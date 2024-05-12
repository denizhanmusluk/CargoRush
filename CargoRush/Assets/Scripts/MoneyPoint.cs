using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MoneyPoint : MonoBehaviour
{
    [SerializeField] Color _color;
    [Range(0, 1)] [SerializeField] int alpha;
    [Range(0, 20)] [SerializeField] float UpwardSpeed;
    /*    [Range(0, 4)] [SerializeField]*/
    float SimulationSpeed;
    [SerializeField] Vector2 randomSpeed;
    public TextMeshProUGUI PointText;
    public int pointValue;
    
    void Start()
    {
        SimulationSpeed = Random.Range(randomSpeed.x, randomSpeed.y);
        PointText.color = _color;

        StartCoroutine(pointUp());
        PointText.text = "$" + pointValue.ToString();
    }
    public void PointInit(int moneyAmount)
    {
        StartCoroutine(SetMoneyVal(moneyAmount));
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

    IEnumerator SetMoneyVal(int moneyAmount)
    {
        float counter = 0f;
        int decimalCounter = 0;

        while (counter < 1f)
        {
            decimalCounter++;
            counter += Time.deltaTime;
            float money = Mathf.Lerp(0 , (float)moneyAmount, counter);
            PointText.text = "$" + CoefficientTransformation.Converter((int)money);
       
            yield return null;
        }

        PointText.text = "$" + CoefficientTransformation.Converter((int)moneyAmount);

        yield return new WaitForSeconds(1f);

        StartCoroutine(colorSet(alpha));

    }
}

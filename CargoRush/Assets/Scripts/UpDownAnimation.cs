using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownAnimation : MonoBehaviour
{
    [SerializeField(), Range(0f, 5f)] private float positionFactor;
    [SerializeField(), Range(0f, 10f)] private float positionSpeed;
    Vector3 firstPos;
    void Start()
    {
        firstPos = transform.position;
        StartCoroutine(UpDownAnim());

    }

    IEnumerator UpDownAnim()
    {
        float counter = 0f;
        float value = 0;
        yield return new WaitForSeconds(Random.Range(0.5f, 1f));
        while (true)
        {
            counter += positionSpeed * Time.deltaTime;
            value = Mathf.Abs(Mathf.Sin(counter));
            value *= 0.05f * positionFactor;
            transform.position = firstPos + Vector3.up * value;

            yield return null;

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAnimation : MonoBehaviour
{
    [SerializeField(), Range(0f, 10f)] private float rotateSpeed;
    [SerializeField(), Range(0f, 180f)] private float maxAngle;
    [SerializeField] int firstValue = 127;
    Quaternion firstLocalRot;

    void Start()
    {
        firstLocalRot = transform.localRotation;
        StartCoroutine(UpDownAnim());

    }

    IEnumerator UpDownAnim()
    {
        float counter = 0f;
        float value = 0;
        yield return new WaitForSeconds(Random.Range(0.5f, 1f));
        while (true)
        {
            counter += rotateSpeed * Time.deltaTime;
            value = maxAngle * Mathf.Sin(counter);

            transform.localRotation = Quaternion.Euler(transform.localEulerAngles.x, firstValue + value, transform.localEulerAngles.z);

            yield return null;

        }
    }
}

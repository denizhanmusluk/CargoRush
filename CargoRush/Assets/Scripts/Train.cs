using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;

public class Train : MonoBehaviour
{
    [SerializeField] SplineFollower splineFollower;
    [SerializeField] float lowSpeed, normalSpeed, highSpeed;
    float currentSpeed;
    void Start()
    {
        currentSpeed = normalSpeed;
        splineFollower.followSpeed = currentSpeed;
    }

    // Update is called once per frame
    public void SpeedUp()
    {
        StartCoroutine(_SpeedUp());
    }
    public void SpeedDown()
    {
        StartCoroutine(_SpeedDown());
    }

    public void SpeedNormal()
    {
        StartCoroutine(_SpeedNormal());
    }
    IEnumerator _SpeedUp()
    {
        float counter = 0f;
        float _currentSpeed = currentSpeed;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            currentSpeed = Mathf.Lerp(_currentSpeed, highSpeed, counter);
            splineFollower.followSpeed = currentSpeed;
            yield return null;
        }
        currentSpeed = highSpeed;
        splineFollower.followSpeed = currentSpeed;
    }
    IEnumerator _SpeedDown()
    {
        float counter = 0f;
        float _currentSpeed = currentSpeed;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            currentSpeed = Mathf.Lerp(_currentSpeed, lowSpeed, counter);
            splineFollower.followSpeed = currentSpeed;
            yield return null;
        }
        currentSpeed = lowSpeed;
        splineFollower.followSpeed = currentSpeed;
    }
    IEnumerator _SpeedNormal()
    {
        float counter = 0f;
        float _currentSpeed = currentSpeed;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            currentSpeed = Mathf.Lerp(_currentSpeed, normalSpeed, counter);
            splineFollower.followSpeed = currentSpeed;
            yield return null;
        }
        currentSpeed = normalSpeed;
        splineFollower.followSpeed = currentSpeed;
    }
}

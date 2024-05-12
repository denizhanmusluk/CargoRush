using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FasterReward : MonoBehaviour
{
    public int rewardTime;
    public int extraLevel;

    [SerializeField] GameObject cicrcle;

    Transform targetTR;
    Rigidbody rb;
    bool collectActive = true;
    bool hitActive = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Dedector>() != null && collectActive)
        {
            cicrcle.SetActive(false);

            collectActive = false;

            ForceObject(other.transform);
            rb.isKinematic = false;
        }
        if ((other.transform.tag == "Ground") && hitActive)
        {
            hitActive = false;
            HitGround();
            Destroy(gameObject.GetComponent<Collider>());

        }

    }

    public void ForceObject(Transform _targetTR)
    {
        targetTR = _targetTR;
        StartCoroutine(ForceAppling());
    }

    IEnumerator ForceAppling()
    {
        rb.AddForce(Vector3.up * 500);
        yield return new WaitForSeconds(0.05f);
        float counter = 0f;
        float time = 2f;
        float forceFactory = 5f;
        while (counter < time)
        {
            counter += 2 * Time.deltaTime;
            Vector3 direction = targetTR.position - transform.position;
            rb.AddForce(new Vector3(direction.x, -15f, direction.z) * forceFactory);
            yield return null;
        }
        collectActive = true;
    }

    void HitGround()
    {
        HoleManager.Instance.FasterRewardLevelUp(rewardTime, extraLevel);
        StartCoroutine(HitDelay());

    }
    IEnumerator HitDelay()
    {
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
    }
}

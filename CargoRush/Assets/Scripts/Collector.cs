using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public float impulse;
    public bool pushActive = false;
    [SerializeField] Rigidbody rb;
    public int productId;
    public GameObject shadowGO;
    public bool collectorActive = true;

    public bool hitOutSd = true;
    public void FirstPush(Vector3 forceDir)
    {
        rb.isKinematic = false;
        pushActive = true;
        rb.AddForce(forceDir * impulse * 10);
    }
    public void Push(Transform collTR, float _impulse)
    {
        if (collectorActive && rb != null)
        {
            impulse = _impulse;
            pushActive = true;
            rb.isKinematic = false;
            Vector3 forceDirection = (transform.position - collTR.position).normalized;
            Vector3 randomPosOffset = new Vector3(Random.Range(-0.1f, 0.1f), 0, Random.Range(-0.1f, 0.1f));
            rb.AddForce((forceDirection + randomPosOffset) * impulse);
            StartCoroutine(Kinemator());
        }
    }
    IEnumerator Kinemator()
    {
        yield return new WaitForSeconds(1f);
        while (rb != null && (rb.velocity.x > 0 || rb.velocity.y > 0 || rb.velocity.z > 0 || transform.position.y > 1.5f))
        {
            yield return null;
        }
        if (rb != null)
        {
            rb.isKinematic = true;
        }
        pushActive = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collectorActive && collision.transform.GetComponent<Collector>() != null && pushActive && impulse > 10f)
        {
            collision.transform.GetComponent<Collector>().Push(transform, impulse * 0.4f);
            impulse *= 0.4f;
        }
    }
}

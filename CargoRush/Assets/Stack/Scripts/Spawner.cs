using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float spawnInterval = 1;
    [SerializeField] private ObjectPool objectPool;
    void Start()
    {
        StartCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {
        int counter = 0;
        while (true)
        {
            GameObject obj = ObjectPool.Instance.GetPoolObject(counter++ % 2);
            obj.transform.position = Vector3.zero;
            //if(obj.GetComponent<IStart>() != null)
            //{
            //    obj.GetComponent<IStart>().Starter();
            //}
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
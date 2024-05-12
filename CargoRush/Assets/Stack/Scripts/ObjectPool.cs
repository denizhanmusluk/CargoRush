using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObjectPool : MonoBehaviour
{
    private static ObjectPool _instance = null;
    public static ObjectPool Instance => _instance;
    [Serializable]
    public struct Pool
    {
        public Queue<GameObject> pooledObjects;
        public GameObject objectPrefab;
        public int poolSize;
    }
    [SerializeField] private Pool[] pools;
    private void Awake()
    {
        _instance = this;
        for (int j = 0; j < pools.Length; j++)
        {
         pools[j].pooledObjects = new Queue<GameObject>();
            for (int i = 0; i < pools[j].poolSize; i++)
            {
                GameObject obj = Instantiate(pools[j].objectPrefab);
                if (obj.GetComponent<Iid>() != null) { obj.GetComponent<Iid>().id = j; }
                obj.SetActive(false);

                pools[j].pooledObjects.Enqueue(obj);
            }
        }
    }

    public GameObject GetPoolObject(int objectType)
    {
        if(objectType >= pools.Length)
        {
            return null;
        }
        GameObject obj = pools[objectType].pooledObjects.Dequeue();
        obj.SetActive(true);
        //pools[objectType].pooledObjects.Enqueue(obj);
        return obj;
    }
    public GameObject killPoolObject(int objectType, GameObject obj)
    {
        if(objectType >= pools.Length)
        {
            return null;
        }
        pools[objectType].pooledObjects.Enqueue(obj);
        obj.SetActive(false);
        //obj = pools[objectType].pooledObjects.Dequeue();

        return obj;
    }
}

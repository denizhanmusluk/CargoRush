using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableList : MonoBehaviour
{
    private static CollectableList _instance = null;
    public static CollectableList Instance => _instance;
    [SerializeField] GameObject blomParticle;
    public List<Collectable> collectables = new List<Collectable>();
    void Awake()
    {
        _instance = this;
    }

    public void ClearAllCollectable()
    {
        StartCoroutine(_ClearCollectables());
    }
    IEnumerator _ClearCollectables()
    {
        for(int i = 0; i < collectables.Count; i++)
        {
            collectables[i].gameObject.SetActive(false);
            Instantiate(blomParticle, collectables[i].transform.position, Quaternion.identity);
            yield return null;
        }
    }
}

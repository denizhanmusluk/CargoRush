using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    [SerializeField] List<GameObject> objects = new List<GameObject>();
    [SerializeField] int objCount;
    int selection;
    private void Start()
    {
        StartCoroutine(CreatObj());
    }
    IEnumerator CreatObj()
    {
        for (int i = 0; i < objCount; i++)
        {
            selection = Random.Range(0, objects.Count);
            Vector3 createPosition = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(0.5f, 2.5f), Random.Range(-0.5f, 0.5f));
            GameObject newObj = Instantiate(objects[selection], transform.position, Quaternion.identity);
            yield return null;
            newObj.transform.parent = transform;
            newObj.transform.localPosition = createPosition;
            newObj.GetComponent<Rigidbody>().isKinematic = false;
            newObj.GetComponent<Rigidbody>().drag = 10;
        }
    }
}
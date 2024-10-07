using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VipDrone : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform fishPosParent;
    public Transform[] fishPosTR;
    public Stand stand;

    public Transform createPos;
    public Transform standPos;
    public Transform carGoPos;
    public GameObject vipCanvasGo;

    [SerializeField] float moveSpeed = 1f;
    private void Start()
    {
        StartCoroutine(CarGoPos());
    }
    IEnumerator CarGoPos()
    {
        float counter = 0f;
        while(counter < 1f)
        {
            counter += moveSpeed * Time.deltaTime;
            transform.position = Vector3.Lerp(createPos.position, standPos.position, counter);
            transform.rotation = Quaternion.Lerp(createPos.rotation, standPos.rotation, counter);

            yield return null;
        }

        transform.position = standPos.position;
        transform.rotation = standPos.rotation;

        stand.StandReActive();
    }
    private void Update()
    {
        VipCanvasSetRot();
    }
    private void VipCanvasSetRot()
    {
        Quaternion cameraRot = Camera.main.transform.rotation;
        vipCanvasGo.transform.rotation = Quaternion.Euler(cameraRot.eulerAngles.x, cameraRot.eulerAngles.y, cameraRot.eulerAngles.z);
    }
    public void CarGoOut()
    {

        StartCoroutine(CarGoOutDelay());
    }

    IEnumerator CarGoOutDelay()
    {
        yield return new WaitForSeconds(1f);
        float counter = 0f;
        while (counter < 1f)
        {
            counter += moveSpeed * Time.deltaTime;
            transform.position = Vector3.Lerp(standPos.position, createPos.position, counter);
            transform.rotation = Quaternion.Lerp(standPos.rotation, createPos.rotation, counter);

            yield return null;
        }

        transform.position = createPos.position;
        transform.rotation = createPos.rotation;

        Destroy(gameObject, 1);
    }
}

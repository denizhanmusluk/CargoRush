using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowPosSetter : MonoBehaviour
{
    public float y_Offset;
    public float y_Factor = 0.5f;
    public SpriteRenderer shadowSprite;
    public Transform directionLightTR;
    Vector3 directionLightDir = Vector3.zero;
    Transform parentTR;
    Vector3 firstSize;
    private void OnEnable()
    {
        parentTR = transform.parent;
        transform.parent = null;

        firstSize = transform.localScale;
        directionLightTR = PlatformSwitchManager.Instance.bottomLight.transform;
        directionLightDir = (directionLightTR.forward).normalized;
        StartCoroutine(EnableDelay());
    }
    IEnumerator EnableDelay()
    {
        yield return new WaitForSeconds(0.5f);
        shadowSprite.enabled = true;
    }
    void FixedUpdate()
    {
        y_Factor = Mathf.Abs((parentTR.position.y - y_Offset)) - 0.2f;
        transform.rotation = Quaternion.Euler(90, 0, 0);
        transform.position = new Vector3(parentTR.position.x + (directionLightDir.x * 0.5f * y_Factor), y_Offset, parentTR.position.z + (directionLightDir.z * 0.5f * y_Factor));
        transform.localScale = firstSize * (y_Factor * 0.1f + 1f);
        shadowSprite.color = new Color(shadowSprite.color.r, shadowSprite.color.g, shadowSprite.color.b, 1f / (1f + y_Factor * 0.2f));
    }
    private void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(90, 0, 0);
        //transform.position = new Vector3(transform.position.x, y_Offset, transform.position.z);
    }
}

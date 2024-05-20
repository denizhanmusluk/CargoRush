using UnityEngine;
using System.Collections;

public class AINode : MonoBehaviour
{

    public float nextNodeDistance = 10f;
    public Transform nextNode;
    public Transform previousNode;

    public NodeSetting nodeSetting;

    [HideInInspector]
    public Color GizmosColor = new Color(1, 1, 1);

    [System.Serializable]
    public class NodeSetting
    {
        //public bool brakeing;
        //public int speedLimit;
        //public int brake_minspeed_Limit;
        //public int nodeBrakePower;
        //public int forceImp = 0;
        //public bool specialCamera_1 = false;
        //public bool specialCamera_2 = false;
        //public bool brakePedalActive = false;

        //public bool finalCameraActive = false;
        //public bool finishPoint = false;

    }
#if UNITY_EDITOR

    void OnDrawGizmos()
    {
        transform.LookAt(nextNode);

        //if (nodeSetting.brakeing)
        //    Gizmos.color = Color.red;
        //else
            Gizmos.color = GizmosColor;

        Gizmos.DrawSphere(transform.position, 0.25f);
    }
#endif
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AIPath : MonoBehaviour
{

    public Color pathColor = new Color(1, 0.5f, 0);
    public List<AINode> aiNodes = new List<AINode>();
    private void Awake()
    {
        foreach(AINode node in GetComponentsInChildren<AINode>())
        {
            aiNodes.Add(node);
        }
    }
#if UNITY_EDITOR
    void OnDrawGizmos()
    {
        Gizmos.color = pathColor;

        int count = 1;

        foreach (Transform node in transform)
        {
            node.GetComponent<AINode>().GizmosColor = pathColor;

            if (!node.GetComponent<AINode>())
                node.gameObject.AddComponent<AINode>();

            if (node.name != count.ToString())
                node.name = count.ToString();


            Transform NextNode = transform.Find((count + 1).ToString());
            Transform PreviousNode = transform.Find((count - 1).ToString());

            if (NextNode)
            {
                Gizmos.DrawLine(node.position, NextNode.position);
                node.GetComponent<AINode>().nextNode = NextNode;
            }

            if (PreviousNode)
                node.GetComponent<AINode>().previousNode = PreviousNode;

            count++;
        }
    }
#endif
}

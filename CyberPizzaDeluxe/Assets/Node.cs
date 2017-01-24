using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public List<GameObject> connectedNodes = new List<GameObject>();

    public void drawLineToConnectedNodes()
    {
        foreach (GameObject n in connectedNodes)
        {
            Debug.DrawLine(transform.position, n.transform.position, Color.green, 100.0f);
        }
    }
}

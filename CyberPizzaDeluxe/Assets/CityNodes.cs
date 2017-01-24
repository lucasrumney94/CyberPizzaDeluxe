using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityNodes : MonoBehaviour {

    public GameObject node;
    public int numberOfNodes = 10;
    public List<GameObject> nodes = new List<GameObject>();


    

	// Use this for initialization
	void Start ()
    {
        for (int i = 0; i < numberOfNodes; i++)
        {
            nodes.Add(Instantiate(node, transform) as GameObject);
        }
        foreach (GameObject n in nodes)
        {
            n.transform.position = Random.insideUnitCircle * 10.0f;
            n.GetComponent<Node>().connectedNodes.Add(nodes[Random.Range(0, numberOfNodes)]);
        }
        foreach (GameObject n in nodes)
        {
            n.GetComponent<Node>().drawLineToConnectedNodes();
        }
    }
	
	// Update is called once per frame
	void LateStart ()
    {

    }
}


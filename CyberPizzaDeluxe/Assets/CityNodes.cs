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
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}


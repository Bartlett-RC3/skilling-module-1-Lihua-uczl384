using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4_ListenScript : MonoBehaviour {

    public bool seen = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!seen)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;

        }
        else 
        {
            GetComponent<MeshRenderer>().material.color = Color.red;

        }
        seen = false;
    }
}

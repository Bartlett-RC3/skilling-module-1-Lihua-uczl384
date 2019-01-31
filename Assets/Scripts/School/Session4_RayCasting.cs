using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4_RayCasting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Ray casting steps
        //Step1:Create ray
        Vector3 raycastingDirection = transform.forward;
        //Step2:See hat object is in front of me
        RaycastHit objectInFront;
        //step3:Do something with the object in front of me
        if (Physics.Raycast(transform.position, raycastingDirection, out objectInFront))
        {
            Debug.Log("object in front is:" + objectInFront.transform.name);
            objectInFront.transform.GetComponent<Session4_ListenScript>().seen = true;


        }
	}
}

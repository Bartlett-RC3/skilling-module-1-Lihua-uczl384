
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4_RayCasting_Lihua : MonoBehaviour {


    private Vector3 rayCasting = new Vector3();
    public RaycastHit floor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Create ray
        rayCasting = transform.TransformDirection(Vector3.forward);


        RaycastHit objectInFront;

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * 5.0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 5.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 0.01f);
        }
        // Move the cube down
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * 5.0f);
        }
        if (Physics.Raycast(transform.position, rayCasting, out objectInFront))
        {
            
            if(objectInFront.rigidbody != null)
            {
                Debug.Log(objectInFront.transform.name);
                Destroy(objectInFront.transform.gameObject);
      
          }
        }
    }
}

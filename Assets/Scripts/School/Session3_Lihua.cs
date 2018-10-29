using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3_Lihua : MonoBehaviour {

    public GameObject cubePrefab;
    public GameObject light;
    public GameObject objectReference;

    public int spacing = 10;
    public int gridX = 10;
    public int gridY = 10;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Instantiate(cubePrefab, new Vector3(i * spacing, j * spacing, 0), Quaternion.identity,this.transform);
            }
        }
        objectReference.transform.Translate(Vector3. up);

	}
	
	// Update is called once per frame
	void Update () {
        //TIME
        Debug.Log("This computer can render a frame in" + Time.deltaTime);
        Debug.Log("Since I started playing the game this amount of time has passed:" + Time.timeSinceLevelLoad);
        Debug.Log("Computer has counted this amount of frames:" + Time.frameCount);

        //TimeManager
        //Skybox
        //translation
        //move childremn gameobjects in x axis
       // foreach (Transform child in this.transform)
       // {
            
            //child.Translate(Random.value, 0, 0);
            //child.Translate(0, 0,Random.Range (-0.1f,0.1f) );

       // }

        //ROTATION
        //ROTATE CHILDREN GAMEOBJECTS AROUND Y AXIS
        foreach (Transform child in this.transform)
        {
            //child.Rotate(0, Random.value, 0);
            //child.RotateAroundLocal(Vector3.up, Random.value);
            child.localScale = new Vector3(Random.Range(0.1f, 1), Random.Range(0.1f, 1), Random.Range(0.1f, 1))
 ;
        }

        Vector3[] originalScale=new Vector3 [this.transform.childCount];
        for(int i=0;i<transform.childCount;i++)
        {
            //keyboard input
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //If I have pressed space make temporary the cubes large!
                //Record the cubes original scale
                foreach (Transform child in this.transform)
                {
                    child.localScale = child.localScale * 10.0f;
                }
            }
            else
            {
                for (int j = 0; j < transform.childCount; j++)
                transform.GetChild(j).localScale = originalScale[j];

            }
}
        //mouse pressed
        if (Input.GetMouseButton(0))
        {
            light.GetComponent<Light>().color = new Color(Random.value, Random.value, Random.value);
        }
    
}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4_homework_Listener : MonoBehaviour
{
    public bool Cubeseen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Cubeseen)
        {
            GetComponent<MeshRenderer>().material.color = Color.blue;

        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
        }

        Cubeseen = false;

    }
}

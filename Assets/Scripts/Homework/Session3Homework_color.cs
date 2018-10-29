using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3Homework_color : MonoBehaviour
{

    public Material cubeColor;

    // Use this for initialization
    void Start()
    {
     


    }

    // Update is called once per frame
    void Update()
    {
        //Create a cube and change its colour when key is pressed or mouse is pressed
        if (Input.GetMouseButton(1))

        {
           cubeColor.color =  new Color(Random.value,Random.value,Random.value);
            
        }
        

    }
}


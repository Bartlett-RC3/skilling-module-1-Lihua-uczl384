using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3Homework_Lihua : MonoBehaviour
{
    public GameObject prefab;
    public int number = 15;
    public int spacing = 10;

    public bool cubeLeft;
    public bool cubeRight;
    public bool cubeLeft1;
    public bool cubeRight1;
    public GameObject copy;
    public GameObject cube;
    public Material color;


    // Use this for initialization
    void Start()
    {

        if (cubeLeft == true)
        {
            Instantiate(prefab, new Vector3(-spacing, 0, 0), Quaternion.identity, this.transform);
        }
        cube = Instantiate(cube);
    }

    // Update is called once per frame
    void Update()
    {

        // Move cube left and right by manually setting the Transform component


        if (cubeRight == true)
        {
            gameObject.transform.Translate(Vector3.right);
        }
        // cube loop left and right  by manually setting the Transform component
        if (cubeLeft1 == true)
        {
            for (int i = 0; i < number; i++)
            {

                copy = Instantiate(prefab, this.transform);
                copy.transform.localPosition = new Vector3(-i * spacing, 0, 0);
            }
        }
        if (cubeRight1 == true)
        {
            for (int j = 0; j < number; j++)
            {
                copy = Instantiate(prefab, this.transform);
                copy.transform.localPosition = new Vector3(j * spacing, 0, 0);
            }
        }
        //Create a cube and change its colour when key is pressed or mouse is pressed
        if (Input.GetMouseButton(2))

        {
            color.color = new Color(Random.value, Random.value, Random.value);

        }






    }
}
        



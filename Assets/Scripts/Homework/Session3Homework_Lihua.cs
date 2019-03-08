using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3Homework_Lihua : MonoBehaviour
{
    public GameObject prefab;
    public int number = 2;
    public int spacing =3;

    public bool cubeLeft =false;
    public bool cubeRight = false;
    public bool cubeLeft1 = false;
    public bool cubeRight1 = false;
    private GameObject copy;
    public GameObject cube;
    public Material color;

    int count = 1;
    // Use this for initialization
    void Start()
    {

        
            Instantiate(prefab, new Vector3(-spacing, 0, 0), Quaternion.identity, this.transform);
       

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
        if (Input.GetKey(KeyCode.Space))

        {
            color.color = new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

        }

        if (Input.GetKey(KeyCode.D))

        {

            this.transform.Translate(Vector3.right * count);
            count++;
        }
        if (Input.GetKey(KeyCode.A))

        {
            this.transform.Translate(Vector3.left * count);
            count++;
        }
        if (Input.GetKey(KeyCode.S))

        {
            this.transform.Translate(Vector3.down * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))

        {
            this.transform.Translate(Vector3.up * Time.deltaTime);
        }


    }
}
        



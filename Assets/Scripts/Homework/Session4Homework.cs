using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4Homework : MonoBehaviour {


    public GameObject prefab;
    private MeshRenderer getComponnentMeshRender;
    private Vector3 _position = new Vector3(0.0f,0.0f,0.0f);
    IEnumerator ChangeColorCoroutine;
    public float _spacingX = 10.0f;
    public float _spacingZ = 10.0f;
    public int prefabCount = 10;
    public Material cubecolor ;
    // Use this for initialization
    void Start () {
        for (int i = 0; i < prefabCount; i++)
        {
            GameObject cubePrefab = Instantiate(prefab, this.transform);
            _position =new Vector3 (i * _spacingX,0.0f, i*_spacingZ);
            cubePrefab.transform.localPosition = _position;
            getComponnentMeshRender = cubePrefab.GetComponent<MeshRenderer>();
        }
        ChangeColorCoroutine = ChangeCubeColor();
        StartCoroutine(ChangeColorCoroutine);


    }
	
	// Update is called once per frame
	void Update () {
        

        Debug.Log(Time.time);

    }

    IEnumerator ChangeCubeColor()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.3f);
            cubecolor.color = new Color(Random.value, Random.value, Random.value);
           
            yield return StartCoroutine(ChangeColorCoroutine);

            if (Time.time > 5)
            {
                StopCoroutine(ChangeColorCoroutine);
                StopAllCoroutines();
            }


        }





    }



}

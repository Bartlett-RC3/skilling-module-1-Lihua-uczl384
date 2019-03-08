using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4Homework : MonoBehaviour {


    public GameObject prefab;
    private MeshRenderer getComponnentMeshRender;
    private Vector3 _position = new Vector3(0.0f,0.0f,0.0f);
    IEnumerator ChangeColorCoroutine;
    IEnumerator CreateCubeNumberexpand;
    public float _spacingX = 10.0f;
    public float _spacingZ = 10.0f;
    public int prefabCount = 1000;
    public Material cubecolor ;
    private Rigidbody cubeRigidbody;
    private GameObject cubes;
    // Use this for initialization
    void Start () {
        for (int i = 0; i < prefabCount; i++)
        {
            GameObject cubePrefab = Instantiate(prefab, this.transform);
            _position =new Vector3 (i * _spacingX,10f, i*_spacingZ);
            cubePrefab.transform.localPosition = _position;
            cubePrefab.transform.rotation = new Quaternion(Random.Range(-100f, 100f), Random.Range(-100f, 100f), Random.Range(-100f, 100f), Random.Range(-100f, 100f));
            getComponnentMeshRender = cubePrefab.GetComponent<MeshRenderer>();
        }
        ChangeColorCoroutine = ChangeCubeColor();
        StartCoroutine(ChangeColorCoroutine);
        CreateCubeNumberexpand = CreateCubeNumber();
        StartCoroutine(CreateCubeNumberexpand);

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

            if (Time.time > 500)
            {
                StopCoroutine(ChangeColorCoroutine);
                StopAllCoroutines();
            }


        }

    }

    IEnumerator CreateCubeNumber()
    {
        while (true)
        {
            GameObject _cell;
            yield return new WaitForSeconds(0.3f);
         
            cubes.transform.position = new Vector3(Random.Range(-3f,3f),5f, Random.Range(-3f, 3f));
            cubes.transform.rotation = new Quaternion(Random.Range(-100f, 100f), Random.Range(-100f, 100f), Random.Range(-100f, 100f), Random.Range(-100f, 100f));
            _cell = Instantiate(cubes, transform);


            cubeRigidbody= cubes.GetComponent <Rigidbody>();
            yield return StartCoroutine(CreateCubeNumberexpand);

            if (Time.time > 500)
            {
                StopCoroutine(CreateCubeNumberexpand);
                StopAllCoroutines();
            }


        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorCoroutine : MonoBehaviour
{


    //public GameObject prefab;
    private MeshRenderer getComponnentMeshRender;
    //private Vector3 _position = new Vector3(0.0f, 0.0f, 0.0f);
    IEnumerator ChangeColorCoroutineIenumerator;
    //IEnumerator CreateCubeNumberexpand;
    //public float _spacingX = 10.0f;
    //public float _spacingZ = 10.0f;
    //public int prefabCount = 1000;
    public Material cubecolor;
    //private Rigidbody cubeRigidbody;
    //public GameObject cubes;
    // Use this for initialization
    void Start()
    {
        //for (int i = 0; i < prefabCount; i++)
        ////{
        //GameObject cubePrefab = Instantiate(prefab, this.transform);
        //    _position = new Vector3(i * _spacingX, 0.0f, i * _spacingZ);
        //    cubePrefab.transform.localPosition = _position;
        //    getComponnentMeshRender = cubePrefab.GetComponent<MeshRenderer>();
        ////}
        //getComponnentMeshRender = GetComponent<MeshRenderer>();
        ChangeColorCoroutineIenumerator = ChangeCubeColor();
        StartCoroutine(ChangeColorCoroutineIenumerator);
        //CreateCubeNumberexpand = CreateCubeNumber();
        //StartCoroutine(CreateCubeNumberexpand);

    }

    // Update is called once per frame
    void Update()
    {


        //Debug.Log(Time.time);

    }

    IEnumerator ChangeCubeColor()
    {
        while (true)
        {
            ////yield return new WaitForSeconds(0.3f);
            //cubecolor.color = Color.black;
            //Debug.Log(cubecolor.color);
            //yield return StartCoroutine(ChangeColorCoroutineIenumerator);
            yield return new WaitForSeconds(0.1f);
            getComponnentMeshRender.material.color = Color.blue;     //蓝 红 黑 三色切换
            yield return new WaitForSeconds(0.1f);
            getComponnentMeshRender.material.color = Color.red;
            yield return new WaitForSeconds(0.1f);
            getComponnentMeshRender.material.color = Color.black;
            yield return new WaitForSeconds(0.1f);

            if (Time.time > 500)
            {
                StopCoroutine(ChangeColorCoroutineIenumerator);
                StopAllCoroutines();
            }


        }

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RC3
{
    /// <summary>
    /// 
    /// </summary>
    public class Cell : MonoBehaviour
    {
        private MeshRenderer _renderer;

        // Additional custom per-cell attributes
        private int _state = 0;
        private int _age = 0;
        private Color _color;
        IEnumerator ChangeColorCoroutineIenumerator;
        //public Material _cubecolor;
        //private Color colorcubechange = new Color(0.0f, 0.0f, 0.0f);
        /// <summary>
        // ...
        // ...


        /// <summary>
        /// 
        /// </summary>
        private void Awake()
        {
            _renderer = GetComponent<MeshRenderer>();
            //_color = _renderer.material.color;

            State = 0; // set dead by default
        }


        private void Start()
        {
            ChangeColorCoroutineIenumerator = ChangeCubeColor();
            StartCoroutine(ChangeColorCoroutineIenumerator);
        }

        /// <summary>
        /// 
        /// </summary>
        public int State
        {
            get { return _state; }
            set
            {
                _state = value;
                _renderer.enabled = (value == 1);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        
        /// <summary>
        /// 
        /// </summary>
        public MeshRenderer Renderer
        {
            get { return _renderer; }
        }

        //public Material Cubecolor
        //{
        //    get { return _cubecolor; }
        //}

        IEnumerator ChangeCubeColor()
        {
            while (true)
            {

                ////yield return new WaitForSeconds(0.3f);
                //cubecolor.color = Color.black;
                //Debug.Log(cubecolor.color);
                //yield return StartCoroutine(ChangeColorCoroutineIenumerator);
                yield return new WaitForSeconds(0.1f);
                _renderer.material.color =new Color( Random.Range(0.0f, 1.0f),Random.Range(0.0f, 1.0f),Random.Range(0.0f, 1.0f));     //蓝 红 黑 三色切换
              
          
                yield return new WaitForSeconds(0.1f);

                yield return StartCoroutine(ChangeColorCoroutineIenumerator);
                if (Time.time > 500)
                {
                    StopCoroutine(ChangeColorCoroutineIenumerator);
                    StopAllCoroutines();
                }


            }

        }
    }
}

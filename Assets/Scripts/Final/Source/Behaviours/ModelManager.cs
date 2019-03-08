using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using SpatialSlur;

namespace RC3
{
    /// <summary>
    /// 
    /// </summary>
    public class ModelManager : MonoBehaviour
    {
        [SerializeField] private ModelInitializer _initializer;
        [SerializeField] private Cell _cellPrefab;
        [SerializeField] private int _countX = 100;
        [SerializeField] private int _countY = 100;
        private MeshRenderer getComponnentMeshRender;
        private Cell[,] _cells;
        private GameOfLife2D _model;
        private GameOfLife2D _previousModel;
    
        private CellLayer _cellLayers;

        private bool createCubeComplete = false;
        private int _stepCount;
        private List<int[,]> historyModel;
        //IEnumerator ChangeColorCoroutine;
        //public Material cubecolor;
        //private Color colorcubechange;
        /// <summary>
        /// 
        /// </summary>
        private void Start()
        {
            
            // create cell array
            _cells = new Cell[_countY, _countX];
            //colorcubechange=this.GetComponent<Material>().color;
            historyModel = new List<int[,]>();
            //ChangeColorCoroutine = ChangeCubeColor();
            //StartCoroutine(ChangeColorCoroutine);
            //instantiate cell prefabs and store in array
            for (int y = 0; y < _countY; y++)
            {
                for(int x = 0; x < _countX; x++)
                {
                    Cell cell = Instantiate(_cellPrefab, transform);
                    //getComponnentMeshRender = cell.GetComponent<MeshRenderer>();
                    cell.transform.localPosition = new Vector3(x, y, 0);

         
                    //Debug.Log(colorcubechange);
                    _cells[y, x] = cell;

                }
            }

            // create model
            _model = new GameOfLife2D(_countY, _countX);
            //_cellLayers = Instantiate(_cellLayers);

            //// initialize model
            //_initializer.Initialize(_cellLayers.CurrentState);

            // initialize model
            _initializer.Initialize(_model.CurrentState);
           
        }


        /// <summary>
        /// 
        /// </summary>
        private void Update()
        {
            //ResetModel();
            _model.Step();
            //createCubeComplete = true;
            //_previousModel = _model;
            //historyModel.Add(_previousModel);
            //Debug.Log(historyModel.Count);
            _stepCount++;
            // Debug.Log($"{_stepCount} steps taken!");

            int[,] state = _model.CurrentState;
            historyModel.Add( state );
            Debug.Log("The Count of list" + historyModel.Count);
            // update cells based on current state of model
            for (int y = 0; y < _countY; y++)
            {
                for (int x = 0; x < _countX; x++)
                    _cells[y, x].State = state[y, x];
            }
            
        }
        //public void MoveModel()
        //{
        //    //_previousModel.GameObject.transform.localPosition = new Vector3(0.0f, 10.0f, 0.0f);

        //}
        //public void ResetModel()
        //{
       

        //    //// re-initialize model
        //    //_initializer.Initialize(_model.CurrentState);


        //    createCubeComplete = false;

        //}
        //public void JustifyandMove()
        //{
        //    if (createCubeComplete == true)
        

        //        //child of population manager
        //        _currentStack.transform.parent = gameObject.transform;

        //        Vector3 vector = new Vector3(2f * (_currentStack.RowCount) * (_curCount), 0, 2f * (_currentStack.ColumnCount));
        //        _currentStack.SetPosition(vector);

        //        //add stack to current generation
        //        AddStackToGeneration(_currentStack);

            
 
        //IEnumerator ChangeCubeColor()
        //{
        //    while (true)
        //    {

        //        yield return new WaitForSeconds(0.3f);

        //        cubecolor.color = new Color(UnityEngine.Random.Range(0f, 255f), UnityEngine.Random.Range(0f, 255f), UnityEngine.Random.Range(0f, 255f));
        //        colorcubechange = cubecolor.color;


        //        yield return StartCoroutine(ChangeColorCoroutine);
        //        if (Time.time > 500)
        //        {
        //            StopCoroutine(ChangeColorCoroutine);
        //            StopAllCoroutines();
        //        }


        //    }

        //}
    }
}

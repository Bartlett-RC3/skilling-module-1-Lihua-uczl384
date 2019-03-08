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
    public class GameOfLife2D : MonoBehaviour
    {
        private int[,] _currentState;
        private int[,] _nextState;
        private Index2[] _offsets = Neighborhoods.MooreR1;
        int state = 0;
        int sumM = 0;
        //private bool createCubeComplete = false;
        //private GameObject _conwayModel;
        ////List<int> sumzero = new List<int>();
        ////List<int> sumone = new List<int>();
        ////List<int> sumtwo = new List<int>();
        ////List<int> sumthree = new List<int>();
        ////List<int> sumfour = new List<int>();
        ////List<int> sumfive = new List<int>();
        ////List<int> sumsix = new List<int>();
        ////List<int> sumseven = new List<int>();
        ////List<int> sumeight = new List<int>();
        ////List<int> sumeight = new List<int>();

        private GOLInstructionSet _instructionSetMO1 = new GOLInstructionSet(2, 3, 3, 6);
        //private bool button2333 = false;
        //private bool button2346 = false;
        //private bool button2316 = false;
        int result = -1;
        /// <summary>
        /// 
        /// </summary>
        public int[,] CurrentState
        {
            get { return _currentState; }
        }

        //public GameObject ConwayModel
        //{
        //    get { return _conwayModel; }
        //}
        /// <summary>
        /// 
        /// </summary>
        public Index2[] Offsets
        {
            get { return _offsets; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();

                _offsets = value;
            }
        }
        public void button2333()
        {

            ruleofdeadandlive2333(state, sumM);

        }
        public void button2346()
        {

            ruleofdeadandlive2346(state, sumM);

        }
        public void button2316()
        {

            ruleofdeadandlive2316(state, sumM);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        public GameOfLife2D(int rows, int columns)
        {
            _currentState = new int[rows, columns];
            _nextState = new int[rows, columns];
        }


        /// <summary>
        /// 
        /// </summary>
        public void Step()
        {
            int nrows = _currentState.GetLength(0);
            int ncols = _currentState.GetLength(1);

            // calculate next state
            for (int i = 0; i < nrows; i++)
            {
                for (int j = 0; j < ncols; j++)
                    Step(i, j);

            }

            //createCubeComplete = true;

            //if (createCubeComplete==false)
            //{
                // swap state buffers
                Swap(ref _currentState, ref _nextState);
            //}
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        private void Step(int i, int j)
        {
            int state = _currentState[i, j];
            int sum = GetNeighborSum(i, j);


            result = ruleofdeadandlive2346(state,sum);
         
            if (result > -1)
            {
                button2346();
                ruleofdeadandlive2346(state, sum);
                _nextState[i, j] = ruleofdeadandlive2346(state, sum);
                //Debug.Log(result);
            }
            result = ruleofdeadandlive2346(state, sum);
            if (result >-1)
            {
                button2316();
            ruleofdeadandlive2316(state, sum);
          
                _nextState[i, j] = ruleofdeadandlive2316(state, sum);

            }
            else
            {
                button2333();
                ruleofdeadandlive2333(state, sum);
                _nextState[i, j] = ruleofdeadandlive2333(state, sum);
            }
        }





        public int ruleofdeadandlive2333(int state,int sumM)
        {
            
            GOLInstructionSet _instructionSetMO2 = new GOLInstructionSet(2, 3, 3, 3);
            GOLInstructionSet instructionSet = _instructionSetMO2;
           
              
              
                //if current state is "alive"
                if (state == 1)
                {
                    if (sumM < instructionSet.getInstruction(0))
                    {
                        result = 0;
                    }

                    if (sumM >= instructionSet.getInstruction(0) && sumM <= instructionSet.getInstruction(1))
                    {
                        result = 1;
                    }

                    if (sumM > instructionSet.getInstruction(1))
                    {
                        result = 0;
                    }
                }

                //if current state is "dead"
                if (state == 0)
                {
                    if (sumM >= instructionSet.getInstruction(2) && sumM <= instructionSet.getInstruction(3))
                    {
                        result = 1;
                    }
                    else
                    {
                        result = 0;
                    }
                }

                return result;

        }




        public int ruleofdeadandlive2346(int state, int sumM)
        {
             
            GOLInstructionSet _instructionSetMO2 = new GOLInstructionSet(2, 3, 4, 6);
            GOLInstructionSet instructionSet = _instructionSetMO2;



            //if current state is "alive"
            if (state == 1)
            {
                if (sumM < instructionSet.getInstruction(0))
                {
                    result = 0;
                }

                if (sumM >= instructionSet.getInstruction(0) && sumM <= instructionSet.getInstruction(1))
                {
                    result = 1;
                }

                if (sumM > instructionSet.getInstruction(1))
                {
                    result = 0;
                }
            }

            //if current state is "dead"
            if (state == 0)
            {
                if (sumM >= instructionSet.getInstruction(2) && sumM <= instructionSet.getInstruction(3))
                {
                    result = 1;
                }
                else
                {
                    result = 0;
                }
            }

            return result;

        }






        public int ruleofdeadandlive2316(int state, int sumM)
        {
    
            GOLInstructionSet _instructionSetMO2 = new GOLInstructionSet(2, 3, 1, 6);
            GOLInstructionSet instructionSet = _instructionSetMO2;



            //if current state is "alive"
            if (state == 1)
            {
                if (sumM < instructionSet.getInstruction(0))
                {
                    result = 0;
                }

                if (sumM >= instructionSet.getInstruction(0) && sumM <= instructionSet.getInstruction(1))
                {
                    result = 1;
                }

                if (sumM > instructionSet.getInstruction(1))
                {
                    result = 0;
                }
            }

            //if current state is "dead"
            if (state == 0)
            {
                if (sumM >= instructionSet.getInstruction(2) && sumM <= instructionSet.getInstruction(3))
                {
                    result = 1;
                }
                else
                {
                    result = 0;
                }
            }

            return result;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="i0"></param>
        /// <param name="j0"></param>
        /// <returns></returns>
        private int GetNeighborSum(int i0, int j0)
        {
            var current = _currentState;
            int nrows = current.GetLength(0);
            int ncols = current.GetLength(1);
            int sum = 0;

            foreach(Index2 offset in _offsets)
            {
                int i1 = Wrap(i0 + offset.I, nrows);
                int j1 = Wrap(j0 + offset.J, ncols);

                if (current[i1, j1] > 0)
                    sum++;
            }
            //CalculatesumGroup(  sum);

            return sum;
        }

        //public void CalculatesumGroup(int sum)
        //{
        //    if (sum == 0)
        //    {
        //        sumzero.Add(1);
        //    }

        //    if (sum == 1)
        //    {
        //        sumone.Add(1);
        //    }
        //    if (sum == 2)
        //    {
        //        sumtwo.Add(1);
        //    }

        //    if (sum == 3)
        //    {
        //        sumthree.Add(1);
        //    }
        //    if (sum == 4)
        //    {
        //        sumfour.Add(1);
        //    }

        //    if (sum == 5)
        //    {
        //        sumfive.Add(1);
        //    }
        //    if (sum == 6)
        //    {
        //        sumsix.Add(1);
        //    }

        //    if (sum == 7)
        //    {
        //        sumseven.Add(1);
        //    }
        //    if (sum == 7)
        //    {
        //        sumseven.Add(1);
        //    }
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int Wrap(int i, int n)
        {
            i %= n;
            return (i < 0) ? i + n : i;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t0"></param>
        /// <param name="t1"></param>
        private static void Swap<T>(ref T t0, ref T t1)
        {
            var temp = t0;
            t0 = t1;
            t1 = temp;
        }
    }
}
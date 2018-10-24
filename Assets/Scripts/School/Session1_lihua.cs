using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Session1_lihua : MonoBehaviour {
    //1
	// Use this for initialization
	
     int myInteger=145;
     int largestInteger = int.MaxValue;
     int smallestInteger = int.MinValue;

    double myDouble = 54.3;
    double maxDouble = double.MinValue;
    float myFloat = 32.456f;
    //Text
    string myFirststring = "My text";
    //Logaical 
    bool myFirstBoolean = true;
    bool myFalseBoolean = false;

    //2.Data structures
    //Scope_Type_Values(can take in many values)
    //Array
    int[] myIntArray = { 1, 2, 3, 4, 5, 6 };
    int[] twentyElementsArray = new int[20];
    double[] doubleArray = { 10.4, 11.23, 45, 72.9 };
    int[,] xyArray = new int[4, 5];

    //List
    List<int> myList = new List<int>();
    

    //Dictionary
    Dictionary<string, string> movingAnimals = new Dictionary<string, string>();











    void Start () {myList.Add(1);
        // Array  adding values
        myIntArray[2] = 300;
        //Array retrive valur
        Debug.Log(myIntArray[1].ToString());

        myList.Add(4321);
        myList.Add(41);
        myList.Add(1);

        //List retrive values
        Debug.Log(myList[2].ToString());
        Debug.Log(myList[myList.Count-1].ToString());

        //Cleating the List
        myList.Clear();


        movingAnimals.Add("flying", "eagle");
        movingAnimals.Add("flying", "parrot");
        movingAnimals.Add("walking", "human");
        movingAnimals.Add("walking", "dog");
        if (movingAnimals.ContainsKey("flying"))
        {
            Debug.Log("A flying animal is:" + movingAnimals.Values);


        }

        //3.Functions
    // Scope -- Type(void,int,float,double,bool,etc)-- Variables -- Body (Instructions)
    //Number addition function
   

    } 
  float NumberAddtion(float a, float b)
        {
            float additionResult = a + b;
            return additionResult;
        }
          

    // Update is called once per frame
    void Update() {

        int x =NumberAddition(2, 3);

          

        }

        
    }
    

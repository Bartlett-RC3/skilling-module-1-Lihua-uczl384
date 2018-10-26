using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session2_Lihua : MonoBehaviour {
    //Variables
    int number1 = 10;
    int number2 = 20;
    int number3 ;
    string someName ="name";
    bool someBool = false;

    string[] tutorNames = { "David","Tyson", "Jordi", "Octavian", "Panos" };

    // Use this for initialization
    void Start() {
        Debug.Log("A tutor is:" + tutorNames[0]);
        Debug.Log("A tutor is:" + tutorNames[1]);
        Debug.Log("A tutor is:" + tutorNames[2]);
        //iterative data using loops
        if (number1 < number2)//Question
                              //Action if ture

        {
            Debug.Log("number1 is smaller than number 2");


        }
        else {
            Debug.Log("number2 is smaller than number1");


        }
        //Questions we can ask
        //If something is smaller or bigger
        //<,>
        //If something is equal to something else
        //==

        //Asking multiple question
        if (number1 < number2 && someBool == true)
        {
            Debug.Log("Answer to both questions is yes!");

        }
        if (number1 < number2) {
            if (someBool == true) {
                Debug.Log("Answe to both questions is yes!");



            }

            if (number1 < number2 || someBool == true)
            {
                Debug.Log("Answer to one of the questions was ture");
                    }
            if ((number1 < number2 && someBool == true)&&(someBool == true && someName =="name"))
                {
                Debug.Log("This id too confusing!Simply Please!");

            }
            //Shortand if
            number3 = (number1 < number2) ? 100 : 200;
        }
        for (int i = 0; i <= tutorNames.Length - 1; i=i+2) {
            Debug.Log("A tutor is:" + tutorNames[i]);
        }
        for (int counter = 0; counter < number2; counter++)
        {
            Debug.Log("Counting...."+counter);

        }
        //For each loop
        foreach (string tutorName in tutorNames)
        {
            Debug.Log(tutorName);
        }
        {

        }
        {

        }
    }

    // Update is called once per frame
    void Update() {

    }

}
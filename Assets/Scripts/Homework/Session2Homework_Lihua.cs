using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WorldDogs;

public class Session2Homework_Lihua : MonoBehaviour {
    // Variables
    public int student1Age = 30;
    public int student2Age = 29;
    public int biggerAge;
    public int sumNumber;
    public bool boolean=true;
    public string[] subjects = { "science", "math", "language" };
    public string condition;
    public List<int> examGrade = new List<int>();
    public int[] myOrder =new int[34];
    public List<Dog> myDogs = new List<Dog>();


	// Use this for initialization
	void Start () {
        // Conditionals
     
        // Normal if statement
        if (student1Age > student2Age)
        {
            Debug.Log("student1 is older than student2.");
        }
        else
        {
            Debug.Log("student2 is older than student1.");
        }
        // Short if statement
        if (boolean)
        {
            Debug.Log("True.");
        }
        // the value of condition is based on the value of boolean
        condition = (boolean == true) ? "Agree" : "Refused";
        {
            Debug.Log("the condition is" + condition);
        }
        // condition
        if (student1Age > student2Age || boolean == true)
        {
            Debug.Log("Enter.");
        }

        biggerAge = (student1Age > student2Age) ? student1Age : student2Age;
        {
            Debug.Log("The age of older one is"+biggerAge );
        }

        // Loops
        // For loop statement (start value, how this ends, incrementation)

        for (int i = 0;  i < subjects.Length;  i++)

        {
            Debug.Log("subject" + i + "is" + subjects[i]);
        }
        for (int i = 0; i < 100; i++)

        {
            sumNumber += i;
            Debug.Log(sumNumber);
        }
        List<int> examGrade = new List<int>();
        for (int k = 0; k < 100; k++)

        {
            examGrade.Add(k + 1);
        }
        // Print the list
        for (int j = 0; j < examGrade.Count; j++)
        {
            Debug.Log("the grade of exam"+j+" is: " + examGrade[j]);
        }
        // While loop
        List<int> numberAddition = new List<int>();
        int numberCount = 1;
        while (numberCount <= 100)
        {
            numberAddition.Add(numberCount);
            numberCount += 4;
        }
        

    
    //create dogs
        Dog dog1 = new Dog("Teddy"," wangwang", 2," London"," Wang");
        Dog dog2 = new Dog("Huskie ", " sue", 5, " Beijing", " Sun");
        Dog dog3 = new Dog("Samoyed ", " lejfr", 1, " Moscow", " fdskv");
        myDogs.Add(dog1);
        myDogs.Add(dog2);
        myDogs.Add(dog3);
}
    void Update()
    {
        for (int i = 0; i < myDogs.Count; i++)
        {
            Debug.Log(myDogs[i].GetDogBasicInformation());
        }
    }
}

    


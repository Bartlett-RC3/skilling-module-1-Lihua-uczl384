using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1_Lihua : MonoBehaviour
{

    // Use this for initialization
    public int scalex = 25;
    public int scaley = 16;
    public float scalez = 14.0f;
    public float scaler = 13.5f;
    public int max = int.MaxValue;
    public double xnumber = 18.3;
    public double ynumber = 19;
    public double number = double.MinValue;

    //Text
    public string str = "london";
    public string str0 = "position";

    // Logaical  
    public bool numberButton = true;
    public bool numberButton0 = false;
    //2.Data structures
    //Array
    public int[] personGrade = { 19, 39, 20, 40, 50 };
    public double[] mathValue = new double[40];
    public int[,] numberArray0 = new int[80, 90];
    public float[] num = { 10.32f, 13.67f, 18.97f };
    //List
    List<int> animalsNumber = new List<int>();
    //Dictionary
    Dictionary<string, string> booksContent = new Dictionary<string, string>();

    // Use this for initialization
    void Start()
    {

        // Array  adding values
        animalsNumber[2] = 34;
        //Array retrive valur
        Debug.Log(animalsNumber[2].ToString());
        animalsNumber.Add(1);
        animalsNumber.Add(34);
        animalsNumber.Add(22434);
        //List retrive values
        Debug.Log(animalsNumber[2].ToString());
        Debug.Log(animalsNumber[animalsNumber.Count - 1].ToString());
        //Cleating the List
        animalsNumber.Clear();
        booksContent.Add("science", "scientist");
        booksContent.Add("medicine", "doctor");
        booksContent.Add("construction", "engineer");
        booksContent.Add("education", "teacher");
        booksContent.Add("agriculture", "peasant");
        if (booksContent.ContainsKey("education"))
        {
            Debug.Log(booksContent.Values + "works in schools");
            //3.Functions
            //Number addition function

        }
    }
    float Additionnumbers(float a, float b)
    {
        float results = a * b;
        return results;


    }
    // Update is called once per frame
    void Update()
    {
        float x = Additionnumbers(2, 3);
        Debug.Log(x);
    }
}

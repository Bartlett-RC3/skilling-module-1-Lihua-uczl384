﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Dog : MonoBehaviour
{

        // Properties
        public string speices;
        public string dogName;
        public int dogAge;
        public string livingLocation;
        public string ownerName;
    // Constructor
    List<Dog> rc3Tutors = new List<Dog>();

    public Dog(string _speices, string _dogName, int _dogAge, string _livingLocation, string _ownerName)
        {
            speices = _speices;
            dogName = _dogName;
            dogAge = _dogAge;
            livingLocation = _livingLocation;
            ownerName = _ownerName;

        }
        //Functions
        public string GetDogBasicInformation()
        {
            return speices + dogName+ dogAge;
        }
        public string GetDogOwnerInformation()
        {
            return ownerName + livingLocation;
        }
    }


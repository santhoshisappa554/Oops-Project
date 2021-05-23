using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This isEmpty Car Class
[System.Serializable]
public class Ca 
{
    //attributes or properties
    public string carName;
    public int makeYear;
    public float maxSpeed;
    const float Pi = 3.141f;

    //constructor
    public Ca()
    {
        Debug.Log("Car Defult Constructor Called");
    }
    public Ca(float maximumSpeed)
    {
        maxSpeed = maximumSpeed;
        Debug.Log("Car second constructor called");
        Debug.Log("Max Speed :" + maxSpeed);
    }
    public Ca(int makeYear, string carName)
    {
        this.makeYear = makeYear;
        this.carName = carName;
        
    }
    //behaviours or methods
    public void Drive()
    {
        Debug.Log("The Drive Car name is: "+carName);
    }
    public void ApplyBrake()
    {
        Debug.Log("This is to apply car Brake");
    }
    public float Speed()
    {
        Debug.Log("The max Speed of the Car: "+maxSpeed);
        return maxSpeed;
    }
    public int Year()
    {
        Debug.Log("The year of the car: " + makeYear);
        return makeYear;
    }
    public void PrintCarDetails()
    {
        Debug.Log("The Car Name : " + carName);
        Debug.Log("The Car make year : " + makeYear);
        Debug.Log("The Car Speed : " + maxSpeed);
    }
}

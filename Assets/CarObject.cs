using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarObject : MonoBehaviour
{
    // Start is called before the first frame update
    //create a car instance
    [SerializeField]
    //private int carspeed;
    //private Ca myBigCar;
    public enum Direction { North,South,East,West}
    void Start()
    {
        Direction myDirection;
        myDirection = MyDirection(Direction.East);
        Debug.Log("My Direction : " + myDirection);
        //myBigCar.PrintCarDetails();
       /* Ca myCar = new Ca(150);
        Ca myCar1 = new Ca(1990,"Audi");
        myCar1.Drive();
        myCar1.Year();
        myCar.carName = "Audi";
        myCar.makeYear = 1990;
        myCar.maxSpeed = 180.0f;
        myCar.Drive();
        myCar.ApplyBrake();
        myCar.Speed();
        myCar.Year();
        myCar1.carName = "Ferrari";
        myCar1.makeYear = 1980;
        myCar1.maxSpeed = 200.0f;
        myCar1.Drive();
        myCar1.ApplyBrake();
        myCar1.Speed();
        myCar1.Year();*/

    }
    Direction MyDirection(Direction dir)
    {
        Direction di;
        di = Direction.East;
        if(dir == Direction.East)
        {
            di = Direction.North;
        }
        return di;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

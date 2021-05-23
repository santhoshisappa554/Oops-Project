using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTest : MonoBehaviour
{
    // Start is called before the first frame update
    //static variable
    static int score = 0;

    //Static Method
    static void IncrementScore()
    {
        Debug.Log("Updated Score is:" + score++);
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IncrementScore();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Coroutines : MonoBehaviour
{

    private void Awake()
    {
        
    }
    private void Start()
    {
        StartCoroutine("ColorTest");
        //ColorsTest();
    }

    IEnumerator ColorTest()
    {
        print("Start the Coroutine");
        yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.green;
        yield return null;
        print("End of Courountine");
    }
    /* void ColorsTest()
    {
        print("Start the Coroutine");
        yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.green;
        yield return null;
        print("End of Courountine");
    }*/
    /*// Start is called before the first frame update
    int num = 0;
    //IEnumerator coritine;
    void Start()
    {
        StartCoroutine(ScoreUpdate());
        print("Start");
    }
    IEnumerator ScoreUpdate()
    {
        
        print("Score:" + ++num);
        yield return new WaitForSeconds(5.0f);
        print("End");
    }
        
    // Update is called once per frame
    private void Update()
    {

        //StartCoroutine(ScoreUpdate());
    }*/

}

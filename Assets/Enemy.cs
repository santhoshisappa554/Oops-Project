using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//derived class
public class Enemy : MonoBehaviour
{
    public void Start()
    {
        void Attack()
        {

            Debug.Log("Enemy Attack");
            GetComponent<Renderer>().material.color = Color.red;

        }
    }
    
}

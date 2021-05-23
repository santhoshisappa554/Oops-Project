using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//base class
public class Robot : Enemy
{
    public bool isAttacking = false;
    public void Update()
    {
        if (isAttacking)
        {
            Attack();
           //base.Attack();
        }
    }
    public void Attack()
    {
        Debug.Log("This is Robot Attack");
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Derived Class
public class GoBlin :MonoBehaviour
{
    private void Start()
    {
        GoBlin mygoBlin = new GoBlin();
        mygoBlin.Attack();
        GoBlin redGoblin = new RedGoblin();
        redGoblin.Attack();
        GoBlin whiteGoblin = new WhiteGoblin();
        whiteGoblin.Attack();
    }

    public virtual void Attack()
    {
        Debug.Log("Goblin Attack");
    }
}

public class RedGoblin: GoBlin
{
    public override void Attack()
    {
        Debug.Log("RedGoBlin Attack");
    }
}

public class WhiteGoblin : GoBlin
{
    public override void Attack()
    {
        Debug.Log("WhiteGoBlin Attack");
    }
}
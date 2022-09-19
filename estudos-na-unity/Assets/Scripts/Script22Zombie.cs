using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script22Zombie : Script22Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        Attack();  
    }

    // Para reescrever o método herdado, é necessário utilizar o parametro "override"!
    public override void Attack()
    {
        
    }

}

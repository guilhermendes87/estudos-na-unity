using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script23ManCharacter : Script23MyCharacter
{
    // Start is called before the first frame update
    void Start()
    {
        Say();    
    }

    public override void Say()
    {
        Debug.Log("Quem é vivo sempre aparece!");
    }
        
}

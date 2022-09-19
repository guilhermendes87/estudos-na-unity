using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script23OrcCharacter : Script23MyCharacter
{
    // Start is called before the first frame update
    void Start()
    {
        Say();    
    }

    public override void Say()
    {
        Debug.Log("Estou aqui novamente meu velho amigo!");
    }
}

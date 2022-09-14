using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script20Sobrecargas2 : MonoBehaviour
{

    private void Start()
    {
        Script20Sobrecargas Sob = new Script20Sobrecargas();

        Sob.Add(10, 20);
        Sob.Add("Vasco", "da Gama");
    }
    

}

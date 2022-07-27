using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script06WhileDoWhile : MonoBehaviour
{
    int QuantItens = 5;
    int Money = 100;

    // Start is called before the first frame update
    void Start()
    {
        //while (QuantItens > 0)
        //{
        //    Debug.Log("Item coletado");
        //    QuantItens--;
        //}

        do
        {
            Debug.Log("Dinheiro :" + Money);
            Money += 50;
        }
        while (Money <= 1000);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

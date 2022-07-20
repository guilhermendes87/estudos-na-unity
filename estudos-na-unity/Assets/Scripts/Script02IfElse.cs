using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script02IfElse : MonoBehaviour
{
    public int n1;
    public int n2;
    public bool AtivarCheckBox;

    // Start is called before the first frame update
    void Start()
    {
        if(AtivarCheckBox==false)
        {
            Debug.Log("A caixa não está marcada");
        }
        else
        {
            Debug.Log("A caixa está marcada");
        }
        

        if (n1 > n2)
        {
            Debug.Log("O primeiro valor é maior que o segundo valor");
        }
        else if (n2 > n1)
        {
            Debug.Log("O segundo valor é maior que o primeiro valor");
        }
        else
        {
            Debug.Log("Os valores são identicos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

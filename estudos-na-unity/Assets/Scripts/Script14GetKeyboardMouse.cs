using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script14GetKeyboardMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDrag()
    {
        Debug.Log("O Clique foi realizado!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Botão A está sendo pressionado!");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Botão S foi pressionado!");
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("Botão D foi solto!");
        }
    }
}

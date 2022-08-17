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
            Debug.Log("Bot�o A est� sendo pressionado!");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Bot�o S foi pressionado!");
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("Bot�o D foi solto!");
        }
    }
}

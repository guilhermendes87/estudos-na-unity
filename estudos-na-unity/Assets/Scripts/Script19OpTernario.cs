using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script19OpTernario : MonoBehaviour
{
    public int Life = 3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Life > 0 ? "O jogador est� vivo" : "O jogador est� morto");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

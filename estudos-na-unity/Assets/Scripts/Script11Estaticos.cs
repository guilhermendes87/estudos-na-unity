using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script11Estaticos : MonoBehaviour
{
    public int vida = 3;
    public static Script11Estaticos estaticos;

    // Start is called before the first frame update
    void Start()
    {
        estaticos = this;

    }

    public void AumentarVida()
    {

        Debug.Log(vida);
    }
}

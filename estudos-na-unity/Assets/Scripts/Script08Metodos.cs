using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script08Metodos : MonoBehaviour
{
    public int Vida= 50;
    public int ValorRegen = 10;
    public int ValorDano = 5;

    void AumentarVida(int regen)
    {
        Vida += regen;
    }

    void DiminuirVida(int dano)
    {
        Vida -= dano;
    }

    // Start is called before the first frame update
    void Start()
    {
        AumentarVida(ValorRegen);
        Debug.Log("Vida :" + Vida);

        DiminuirVida(ValorDano);
        Debug.Log("Vida :" + Vida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

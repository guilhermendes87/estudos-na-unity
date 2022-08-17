using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script01 : MonoBehaviour
{
    //Estudo das variáveis
    
    //1) Tipos de variáveis:
    
    int ValorInteiro;
    float ValorDecimal;
    string Texto;

    //2) Variáveis Publicas e Privadas:
    //variáveis publicas
    public int ValorInt = 10;
    public float ValorDec = 10.5f;
    public string TextoDeclarado = "Seu texto escrito aqui";

    //variáveis privadas
    //private int ValorInt = int ValorInteiro
    //private float ValorDec = float ValorDecimal;
    //private string TextoDeclarado = string Texto;

    //Variaveis de Objetos da Unity
    public GameObject gameobject;
    public Transform transformUnity;
    public AddComponentMenu novoComponente;
    public Rigidbody2D rig;

    // Iniciado toda vez que o jogo/programa é iniciado.
    void Start()
    {
        Script11Estaticos.estaticos.AumentarVida();
        //Debug.Log("Sua vida atual é: " + Script11Estaticos.estaticos.vida);
        Debug.Log("Seu nome é: "+ Script11Estaticos.estaticos.Name);
    }

    // Atualizado na quantidade de frames que está configurado
    void Update()
    {
        
    }
}

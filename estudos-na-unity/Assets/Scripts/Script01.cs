using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script01 : MonoBehaviour
{
    //Estudo das vari�veis
    
    //1) Tipos de vari�veis:
    
    int ValorInteiro;
    float ValorDecimal;
    string Texto;

    //2) Vari�veis Publicas e Privadas:
    //vari�veis publicas
    public int ValorInt = 10;
    public float ValorDec = 10.5f;
    public string TextoDeclarado = "Seu texto escrito aqui";

    //vari�veis privadas
    //private int ValorInt = int ValorInteiro
    //private float ValorDec = float ValorDecimal;
    //private string TextoDeclarado = string Texto;

    //Variaveis de Objetos da Unity
    public GameObject gameobject;
    public Transform transformUnity;
    public AddComponentMenu novoComponente;
    public Rigidbody2D rig;

    // Iniciado toda vez que o jogo/programa � iniciado.
    void Start()
    {
        
    }

    // Atualizado na quantidade de frames que est� configurado
    void Update()
    {
        
    }
}

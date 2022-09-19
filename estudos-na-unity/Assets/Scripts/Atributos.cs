using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Atributos só podem ser utilizados em cima de variáveis ou classes!
public class Atributos : MonoBehaviour
{
    //"Header" CRIA títulos acima
    [Header("Variáveis numéricas")]
    //Oculta varáveis públicas no inspector
    [HideInInspector]
    public int Score;

    [Header("Outras variáveis")]
    //Mostra variáveis privadas no inspector
    [SerializeField]
    private int Point;
    
    //"Tooltip" MOSTRA uma tag com informações adicionais ao passar o mouse sobre
    [Tooltip("Essas variáveis são do tipo string")]
    [SerializeField]
    private string Texto;

    //"Range" define um intervalo de uso
    [Range(0f, 10f)]
    public int LifeBar;

    //"Space" Gera um espaço entre Variáveis
    [Space]

    //Define um campo de texto maior
    [TextArea]
    public string TextArea;
}

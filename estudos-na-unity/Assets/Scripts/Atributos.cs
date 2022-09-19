using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Atributos s� podem ser utilizados em cima de vari�veis ou classes!
public class Atributos : MonoBehaviour
{
    //"Header" CRIA t�tulos acima
    [Header("Vari�veis num�ricas")]
    //Oculta var�veis p�blicas no inspector
    [HideInInspector]
    public int Score;

    [Header("Outras vari�veis")]
    //Mostra vari�veis privadas no inspector
    [SerializeField]
    private int Point;
    
    //"Tooltip" MOSTRA uma tag com informa��es adicionais ao passar o mouse sobre
    [Tooltip("Essas vari�veis s�o do tipo string")]
    [SerializeField]
    private string Texto;

    //"Range" define um intervalo de uso
    [Range(0f, 10f)]
    public int LifeBar;

    //"Space" Gera um espa�o entre Vari�veis
    [Space]

    //Define um campo de texto maior
    [TextArea]
    public string TextArea;
}

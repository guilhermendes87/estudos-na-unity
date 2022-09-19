using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// AS COUROUTINE SERVEM PARA PAUSAR UMA FUNÇÃO OU MÉTODO POR UM DETERMINADO TEMPO, E RETORNAREM EM SEGUIDA DO MESMO INSTANTE!!
public class Script26CouroutineController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Teste");
    }

    IEnumerator Teste()
    {
        Debug.Log("Iniciando a Couroutine!");
        yield return new WaitForSeconds(5f);
        Debug.Log("Segunda parte da Couroutine após 5 segundos!");
        yield return null;

    }
}

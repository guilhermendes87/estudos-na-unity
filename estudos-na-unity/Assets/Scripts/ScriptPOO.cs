using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPOO : MonoBehaviour
{
    /*PROGRAMA��O ORIENTADA A OBJETO*/

    //TODO SCRIPT NA UNITY � UMA CLASSE
    public class Personagem
    {
        //CARACTERISTICAS DESTE OBJETO
        float Life;
        float Power;
        float Exp;

        //COMPORTAMENTO DESSE OBJETO

        void AumentarVida()
        {
            //faz alguma coisa
        }

        //PERSONALIZAR OBJETO
        public Personagem(float Experience)
        {
            Exp = Experience;
        }

        //INSTANCIA DA CLASSE PERSONAGEM
        Personagem P1 = new Personagem(50f);
    }
        

}

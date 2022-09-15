using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script22Enemy : MonoBehaviour
{
    public int health;

    public void Damage(int damageValue)
    {
        health -= damageValue;
    }

    // o parametro "virtual" permite que o método seja modificado através da classe herdada!
    public virtual void Attack()
    {
        //Valor de ataque do inimigo
        //Inimigo ataca personagem
    }
}

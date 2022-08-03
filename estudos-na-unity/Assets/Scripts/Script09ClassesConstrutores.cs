using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script09ClassesConstrutores : MonoBehaviour
{
    
    [System.Serializable]
    public class inimigo
    {
        public string name;
        public int force;
        public int speed;
        public int mana;
        public int life;

        public inimigo(string Name, int Force, int Speed, int Mana, int Life)
        {
            name = Name;
            force = Force;
            speed = Speed;
            mana = Mana;
            life = Life;
        }

    }

    public inimigo enemy01;
    public inimigo enemy02;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("O Inimigo 01 tem as seguintes características" + " Nome: " + enemy01.name + ", Força: " + enemy01.force + " e Velocidade: " + enemy01.speed +", Mana: " + enemy01.mana + " e Vida: " + enemy01.life);
        Debug.Log("O Inimigo 02 tem as seguintes características" + " Nome: " + enemy02.name + ", Força: " + enemy02.force + " e Velocidade: " + enemy02.speed +", Mana: " + enemy02.mana + " e Vida: " + enemy02.life);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

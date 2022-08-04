using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script10Lists : MonoBehaviour
{
    [System.Serializable]
    public class Enemy
    {
        public string name;
        public int life;
        public int damage;

        public Enemy(string Name, int Life, int Damage)
        {
            name = Name;
            life = Life;
            damage = Damage;
        }
               
    }

    public List<Enemy> enemies = new List<Enemy>();

    void Start()
    {
        enemies.Add(new Enemy("Brutamontes", 100, 70));
        enemies.Add(new Enemy("Bruxildos", 70, 100));
    }

}

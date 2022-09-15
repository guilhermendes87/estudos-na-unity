using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script21Encapsulamento : MonoBehaviour
{
   public class Warrior
    {
        public int health;

        public int Health
        {
            get
            {
                return health;  
            }

            set
            {
                health -= value;

                if (health <= 0)
                {
                    health = 0;
                    Die();
                }
            }
        }

        private void Die()
        {
            //a��o para morrer, tal como gamer over, anima��o, etc.
        }
    }
}

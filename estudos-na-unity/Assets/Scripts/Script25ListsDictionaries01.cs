using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script25ListsDictionaries01 : MonoBehaviour
{
    public string Name;
    public int Level;
    public int Health;


    public Script25ListsDictionaries01(string newName, int maxLevel, int maxHealth)
    {
        Name = newName;
        Level = maxLevel;
        Health = maxHealth;
    }
}

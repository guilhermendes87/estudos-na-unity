using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script05ForEach : MonoBehaviour
{
    string[] Enemies = new string[3];

    // Start is called before the first frame update
    void Start()
    {
        Enemies[0] = "Inimigo 1";
        Enemies[1] = "Inimigo 2";
        Enemies[2] = "Inimigo 3";

        foreach (string i in Enemies)
        {
            Debug.Log(i);
        }
    }
// Update is called once per frame
void Update()
    {

    }
}
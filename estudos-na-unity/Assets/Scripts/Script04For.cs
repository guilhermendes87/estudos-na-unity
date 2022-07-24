using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script04For : MonoBehaviour
{
    public int NumberEnemies;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= NumberEnemies; i++)
        {
            Debug.Log("O número de inimigos é: " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

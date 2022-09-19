using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enemy;

public class Script24NamespacesController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy.Script24NamespacesEnemy enemy1 = new Enemy.Script24NamespacesEnemy();
        Enemy.BossEnemies boss1 = new Enemy.BossEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

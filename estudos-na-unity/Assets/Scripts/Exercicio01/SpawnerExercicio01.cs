using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerExercicio01 : MonoBehaviour
{
    public List<GameObject> Paredes = new List<GameObject>();
    public float SpawnerTimer = 5f;
    float TimerCont;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        TimerCont += Time.deltaTime;

        if(TimerCont >= SpawnerTimer)
        {
            Instantiate(Paredes[Random.Range(0,Paredes.Count)], transform.position, transform.rotation);
            TimerCont = 0;
        }
    }
}

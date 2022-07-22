using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script03Switch : MonoBehaviour
{
    public int DiaDaSemana;

    // Start is called before the first frame update
    void Start()
    {
        switch (DiaDaSemana)
        {
            case 1:
                Debug.Log("Sunday");
                break;
            case 2:
                Debug.Log("Monday");
                break;
            case 3:
                Debug.Log("Tuesday");
                break;
            case 4:
                Debug.Log("Wednesday");
                break;
            case 5:
                Debug.Log("Thursday");
                break;
            case 6:
                Debug.Log("Friday");
                break;
            default:
                Debug.Log("Fora de data!");
                break;

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

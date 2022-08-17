using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script16Enums : MonoBehaviour
{   
    public enum selectHero
    {
        Donatelo,
        Leonardo,
        Michelangelo,
        Rafael
    }

    public selectHero myHero;

    // Start is called before the first frame update
    void Start()
    {
        switch (myHero)
        {
            case selectHero.Donatelo:
                Debug.Log("Donatelo selecionado!");
                break;

            case selectHero.Leonardo:
                Debug.Log("Leonardo selecionado!");
                break;

            case selectHero.Michelangelo:
                Debug.Log("Michelangelo selecionado!");
                break;

            case selectHero.Rafael:
                Debug.Log("Rafael selecionado!");
                break;  
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

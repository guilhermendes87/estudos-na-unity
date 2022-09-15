using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script23MyCharacter : MonoBehaviour
{
    public string Name;
    public int Health;
    public int Strength;
    public float Speed;

    // Start is called before the first frame update
    public virtual void Say()
    {
        Debug.Log("Olá amigo... você é muito amigo!");
    }

    
}

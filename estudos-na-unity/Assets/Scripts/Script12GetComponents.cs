using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script12GetComponents : MonoBehaviour
{
    private Rigidbody rig;
    private BoxCollider box2d;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        box2d = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

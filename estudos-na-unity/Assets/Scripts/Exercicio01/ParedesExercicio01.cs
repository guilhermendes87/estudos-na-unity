using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedesExercicio01 : MonoBehaviour
{
    public float Velocit;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Velocit * Time.deltaTime);
    }
}

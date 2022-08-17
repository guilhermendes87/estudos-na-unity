using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script15InstantiateDestroy : MonoBehaviour
{
    public GameObject Prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(Prefab, new Vector3(2, 1, 10), Quaternion.identity);
            Debug.Log("Objeto Criado!");
        }

        //necessário criar outro script e adicionar ao mesmo gameObject para que funcione!
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    Destroy(gameObject);
        //    Debug.Log("Objeto destruído!");
        //}
    }
}

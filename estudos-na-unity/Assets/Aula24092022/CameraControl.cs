using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform Ball;
    public Vector3 OffSet;
    public Vector3 NewPos;
    // Start is called before the first frame update
    void Start()
    {
        OffSet = transform.position - Ball.position;
    }

    // Update is called once per frame
    void Update()
    {
        NewPos = OffSet + Ball.position;
        transform.position = NewPos;
    }
}

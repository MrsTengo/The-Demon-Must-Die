using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    public Transform cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(cube.position);
    }
}

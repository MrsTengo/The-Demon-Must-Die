using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task4 : MonoBehaviour
{
    public GameObject cubePrefab;
    public Camera CameraPAMAGITI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = CameraPAMAGITI.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject cube = Instantiate(cubePrefab);
                cube.transform.position = hit.point;
            }

            if (Input.GetMouseButtonDown(1))
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}

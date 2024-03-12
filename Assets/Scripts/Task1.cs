using UnityEngine;

public class Task1 : MonoBehaviour
{
    public Transform PointA;
    public Transform PointB;

    void Start()
    {

    }

    void Update()
    {
        transform.position = Vector3.Lerp(PointA.position, PointB.position, 0.5f);
    }
}

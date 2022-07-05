using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePointRandomer : MonoBehaviour
{
    public Transform firstPoint;
    public Transform secondPoint;
    public Transform thirdPoint;
    public Vector2 targetPoint;

    int rand;


    void Update()
    {
        rand = Random.Range(1, 4);

        if (rand == 1) targetPoint = firstPoint.position;
        if (rand == 2) targetPoint = secondPoint.position;
        if (rand == 3) targetPoint = thirdPoint.position;
    }
}

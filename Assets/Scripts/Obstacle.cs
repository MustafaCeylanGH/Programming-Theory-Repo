using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // ENCAPSULATION
    private float rotateX = 45;
    public float rotateY = 30;
    // ENCAPSULATION
    private float rotateZ = 15;
    public float rotationSpeed = 2;

    // INHERITANCE
    public virtual void RotateObstacle()
    {
        transform.Rotate(rotateX* rotationSpeed * Time.deltaTime, rotateY* rotationSpeed * Time.deltaTime, rotateZ* rotationSpeed * Time.deltaTime);
    }

}

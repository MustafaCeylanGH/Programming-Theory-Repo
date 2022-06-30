using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : Obstacle
{
    // POLYMORPHISM
    public override void RotateObstacle()
    {
        rotationSpeed = 5f;
        base.RotateObstacle();
    }
    // ABSTRACTION
    private void Update()
    {
        RotateObstacle();
    }
}

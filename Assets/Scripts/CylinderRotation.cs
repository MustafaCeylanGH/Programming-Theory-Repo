using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotation : Obstacle
{
    // POLYMORPHISM
    public override void RotateObstacle()
    {
        rotateY = 0f;
        rotationSpeed = 1f;
        base.RotateObstacle();
    }
    // ABSTRACTION
    private void Update()
    {
        RotateObstacle();
    }
}

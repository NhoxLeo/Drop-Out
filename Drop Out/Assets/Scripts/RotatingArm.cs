﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingArm : MonoBehaviour
{
    private float speed = 0.6f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed, 0);
    }
}

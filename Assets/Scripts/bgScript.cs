﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgScript : MonoBehaviour
{
    float ScrollSpeed = -5f;
    Vector2 startPos;
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * ScrollSpeed, 20);
        transform.position = startPos + Vector2.right * newPos;
    }
}

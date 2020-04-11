﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{
    public float upForce = 1f;
    public float sideForce = .1f;

    // Start is called before the first frame update
    void Start()
    {
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce / 2f, upForce);

        Vector2 force = new Vector2(xForce, yForce);

        GetComponent<Rigidbody2D>().velocity = force;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

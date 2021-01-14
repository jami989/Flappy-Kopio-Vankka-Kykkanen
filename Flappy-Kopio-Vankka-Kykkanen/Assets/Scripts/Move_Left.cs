﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Left : MonoBehaviour
{

    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime); // move left

        if (transform.position.x < -13)
        {
            Destroy(gameObject); // destroy gameobject when out of screen
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, (float)-.8, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, (float).8, 0);
        }

      
    }
}

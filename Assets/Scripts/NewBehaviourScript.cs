using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.position += Vector3.up * 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * 2f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * 2f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * 2f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * 2f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, (float)-.6, 0);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, (float).6, 0);
        }

    }


}

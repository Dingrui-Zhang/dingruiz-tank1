using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    private Vector3 O_position;
    private Quaternion O_rotation;
    public Transform gun;

    // Start is called before the first frame update
    void Start()
    {
       O_position = transform.position;
       O_rotation = transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * 2f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * 2f * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -90, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(0, 90, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.position += transform.forward * 2f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.position += transform.forward * 2f * Time.deltaTime;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.position != gun.position)
        {
            Reset();
        }

    }

    private void Reset()
    {
        transform.position = O_position;
        transform.rotation = O_rotation;
    }
}

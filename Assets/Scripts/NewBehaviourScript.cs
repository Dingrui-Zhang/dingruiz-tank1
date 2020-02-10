using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
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
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * 2f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * 2f * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(0, -90, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(0, 90, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {

            transform.position += transform.forward * 2f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
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

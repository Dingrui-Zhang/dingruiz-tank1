using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Vector3 O_position;
    //private Time record;

    // Start is called before the first frame update
    void Start()
    {
        O_position = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * 6f * Time.deltaTime;

        if (transform.position.x > 37)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.x < -85)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.z > 20)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.z < -27)
        {
            Destroy(this.gameObject);

        }


    }
    
    private void OnTriggerEnter(Collider other)
    {   
        if (transform.position != O_position)
        {
            Destroy(this.gameObject);
        }

    }






}

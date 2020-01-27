using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * 6f * Time.deltaTime;

        if (transform.position.x > 11)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.x < -36)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.z > 16)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.z < -23)
        {
            Destroy(this.gameObject);

        }
    }

   
        


   
}

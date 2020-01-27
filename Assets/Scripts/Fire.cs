using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Transform gun;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //gun.position = transform.position;
        //gun.rotation = transform.rotation;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, gun.position, gun.rotation);
        }
               
    }
}

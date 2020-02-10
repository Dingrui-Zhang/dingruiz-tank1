using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireP2 : MonoBehaviour
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

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(bullet, gun.position, gun.rotation);
        }

    }
}

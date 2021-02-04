using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody pl;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is our first game!");
	//pl.AddForce(0,0,1000);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            //Debug.Log("This is our first game!");
            pl.AddForce(0, 0, 500 * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            //Debug.Log("This is our first game!");
            pl.AddForce(0, 0, -500 * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            //Debug.Log("This is our first game!");
            pl.AddForce(500 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            //Debug.Log("This is our first game!");
            pl.AddForce(-500 * Time.deltaTime, 0, 0);
        }
    }
}
 
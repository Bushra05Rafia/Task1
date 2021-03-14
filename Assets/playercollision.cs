using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public playermovement movement;
    void OnCollisionEnter(Collision Collisioninfo)
    {
        //if (Collisioninfo.collider.name == "Cube")
        //{
        // Debug.Log("Player Collide with Something!");
        // Debug.Log(Collisioninfo.collider.name);
        //}
        if (Collisioninfo.collider.tag == "obstacle")
        {
            Debug.Log("Player Collide with Something!");
            Debug.Log(Collisioninfo.collider.name);
            //movement.enable = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // OnTriggerEnter2D is called when a gameobject colides with this gameobject
    void OnTriggerEnter2D(Collider2D col)
    {
        //check if the gameobject is a projectile
        if (col.gameObject.layer == LayerMask.NameToLayer("Projectiles"))
        {
            //destroy both the target and the projectile
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}

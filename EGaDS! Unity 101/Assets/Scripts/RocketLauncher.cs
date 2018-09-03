using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : MonoBehaviour {
    //we need a reference to the bullet game object
    [SerializeField] GameObject bullet;

    //we want a cool down time, so we want a cooldown time and a clock to keep track of time
    [SerializeField] float cooldown;
    float timeSinceShot;
    
    // Use this for initialization
    void Start () {
        timeSinceShot = cooldown;
    }
	
	// Update is called once per frame
	void Update () {
        //Every update we want our time since shot to increment by the amount of time that has gone by
        timeSinceShot += Time.deltaTime;

        //shoot the rocket on click, GetAccess returns 1 when fully clicked, also we need to makesure that the cooldown is up
        if (Input.GetAxis("Fire1") > 0 && timeSinceShot  >= cooldown)
        {
            //create the bullet from the prefab
            GameObject currBullet = Instantiate(bullet, transform.position, transform.rotation);

            //modify its possition to be at the end of the barrel
            Vector3 currPos = currBullet.transform.position;
            currBullet.transform.position = currPos + new Vector3(1f, .05f, 0);
            
            //reset the clock
            timeSinceShot = 0;
        }
    }
}

    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerMove : MonoBehaviour {

 	// keep some reference to the rigidbody
	private Rigidbody2D rb;

	// velocity's value can be edited in the unity editor
	[SerializeField] float velocity = 10f;

	// same for jumping
	[SerializeField] float jumpStrength = 100f;

	// track if touching ground
	private bool touchingGround = true;

	// Use this for initialization
	void Start () {
		 // find the rigidbody component on the gameobject that has this script
		rb = GetComponent<Rigidbody2D>();
        
	}
	
	// Update is called once per frame
	void Update () {
		// set the player velocity to move the player
		// 		x will react to key presses because of Input.GetAxit()
		// 		y will be the previously set velocty
		//		z will be nothing since this is a 2D game
		rb.velocity = new Vector3(
			Input.GetAxis("Horizontal") * velocity, // x
			rb.velocity.y, 							// y
			0);										// z

		// jump only if on ground AND jump key pressed
		if(touchingGround && Input.GetAxis("Jump") > 0){
			rb.AddForce(new Vector3(0, jumpStrength, 0));
			touchingGround = false;
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		touchingGround = true; // reset jump
	}
}

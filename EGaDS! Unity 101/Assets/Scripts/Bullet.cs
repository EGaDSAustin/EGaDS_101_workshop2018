using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	[SerializeField] float velocity = 5f;
	[SerializeField] float deadtime = 1f;

	private Rigidbody2D rb;
	private float life = 0;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		life += Time.deltaTime;
		if(life > deadtime){
			Destroy(gameObject);
		}

		rb.velocity = new Vector3(velocity, 0, 0);
	}
}

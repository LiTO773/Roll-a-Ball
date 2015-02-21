using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical); //X Y Z

		rigidbody.AddForce (movement * speed * Time.deltaTime);


	}
	// Update is called once per frame
	void Update () {
	
	}
}

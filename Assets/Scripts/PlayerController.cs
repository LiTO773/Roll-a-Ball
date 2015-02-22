using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;
	public GUIText countText;
	public GUIText winText;
	public GUIText instructions;
	public GUITexture gg;
	private int count;

	public AudioClip collect;
	public AudioClip win;

	void Start(){
		instructions.text = "Make cubes get #REKT";
		count = 0;
		SetCountText ();
		winText.text = "";
		gg.enabled = false;
	}

	void FixedUpdate () {
		//Android Release
		//transform.Translate ((Input.acceleration.x / 2) , 0, (-Input.acceleration.z / 2));
		//Computer release
		//float moveHorizontal = Input.GetAxis ("Horizontal");
		//float moveVertical = Input.GetAxis ("Vertical");

		//Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical); //X Y Z

		//rigidbody.AddForce (movement * speed * Time.deltaTime);
		if (SystemInfo.deviceType == DeviceType.Desktop) {
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");
			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
			rigidbody.AddForce (movement * speed * Time.deltaTime);
		} else {
			float moveHorizontal = Input.acceleration.x;
			float moveVertical = Input.acceleration.y;
			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
			rigidbody.AddForce (movement * speed * Time.deltaTime);
		}
	}
	// Update is called once per frame

	void OnTriggerEnter(Collider other) {
		if (count >= 1) {
			instructions.text = "";
		}
		if (other.gameObject.tag == "PickUp") {
			other.gameObject.SetActive(false);
			collectSound ();
			count = count+1;
			SetCountText ();
		}
	}
	void SetCountText() {
		countText.text = "Sample Text: " + count.ToString ();
		if (count == 8) {
			gg.enabled = true;
			winSound();
			winText.text = "GG MANOS!!!";
			countText.text = "";
		}
	}

	void collectSound() {
		audio.clip = collect;
		audio.Play ();
	}

	void winSound () {
		audio.clip = win;
		audio.Play ();
	}
}
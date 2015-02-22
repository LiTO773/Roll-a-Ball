using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {
	public Texture2D texture;

	void Update () {
		renderer.material.mainTexture = texture;
	}
}

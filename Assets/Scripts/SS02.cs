using UnityEngine;
using System.Collections;

public class SS02 : MonoBehaviour {
	public float delayTime = 4;
	
	IEnumerator Start() {
		yield return new WaitForSeconds (delayTime);
		
		Application.LoadLevel ("MiniGame");
	}
}

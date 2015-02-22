using UnityEngine;
using System.Collections;

public class SS01 : MonoBehaviour {
	public float delayTime = 3;
	
	IEnumerator Start() {
		yield return new WaitForSeconds (delayTime);
		
		Application.LoadLevel ("SplashScreen2");
	}
}
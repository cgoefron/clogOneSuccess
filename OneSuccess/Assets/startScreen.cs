using UnityEngine;
using System.Collections;

public class startScreen : MonoBehaviour {

	void Update () {
		if (Input.GetKeyDown ("r")) {
			Application.LoadLevel("Scene 1"); //change to whatever game scene we're using when ready
		}
	}
}

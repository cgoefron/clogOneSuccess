using UnityEngine;
using System.Collections;

public class sceneChanger : MonoBehaviour { //Use this script if we make a start screen


	void Update () {
		if (Input.GetKeyDown ("r")) {
			Application.LoadLevel("Scene 1"); //change to whatever game scene we're using when ready
		}
}
}
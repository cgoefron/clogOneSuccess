using UnityEngine;
using System.Collections;

public class sceneChanger : MonoBehaviour { //Use this script if we make a start screen


	void Start () {
		if (Input.GetKeyDown ("r")) {
			Application.LoadLevel("ChristinaScene"); //change to whatever game scene we're using when ready
		}
}
}
using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
	
			if (other.tag == "Player") {
				Application.LoadLevel("endScene"); 
			}
	}
}
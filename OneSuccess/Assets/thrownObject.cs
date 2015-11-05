using UnityEngine;
using System.Collections;

public class thrownObject : MonoBehaviour { //add this to the object being thrown	

	public Rigidbody rb;
	public float thrust;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.AddForce ( transform.forward * 800 + transform.up * 500 );
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Mouth") {
			Application.LoadLevel("winScene"); //make a win message
		}
		else {
			Application.LoadLevel("endScene"); //make lose message
			//Destroy(gameObject);
		}
		Debug.Log( "collide (name) : " + other.gameObject.name );
	}


	}


using UnityEngine;
using System.Collections;

public class thrownObject : MonoBehaviour { //add this to the object being thrown	

	public Rigidbody rb;
	public float thrust;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.AddForce ( transform.forward * 300 + transform.up * 50 );
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
		if (other.tag != "Monster") {
			Application.LoadLevel("winScene");; //make a win message
		}
		if (other.tag != "Boundary") {
			Destroy(gameObject);
		}
		Debug.Log( "collide (name) : " + other.gameObject.name );
	}


	}


using UnityEngine;
using System.Collections;

public class MonsterChase : MonoBehaviour {

	Transform playerPosition; 
	public float speed;
	
	// Use this for initialization
	void Start () {
		playerPosition = GameObject.Find ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (playerPosition.position);
		transform.position += speed * Time.deltaTime * transform.forward;
	}

	void onTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Application.LoadLevel("endScene");; //make a death scene
		}
	}
}
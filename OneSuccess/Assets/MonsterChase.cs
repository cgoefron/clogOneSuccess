using UnityEngine;
using System.Collections;

public class MonsterChase : MonoBehaviour { //add this to the monster

	Transform playerPosition; 
	public float speed;
	

	void Start () {
		playerPosition = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	

	void Update () {
		transform.LookAt (playerPosition.position);
		transform.position += speed * Time.deltaTime * transform.forward;
		Debug.Log (transform.position);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag( "Player") == true ) {
			Application.LoadLevel("endScene"); //make a "death" message
		}
	}
}
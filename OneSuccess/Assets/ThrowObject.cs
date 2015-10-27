using UnityEngine;
using System.Collections;

public class ThrowObject : MonoBehaviour { //add this to the player

	public float rayDistance = 5;
	
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	
	private float nextFire;
	
	public float speed = 1.0f;
	

	void Update () {
		
		//		RaycastHit hitInfo;
		//	if ( Physics.Raycast( transform.position, transform.forward, out hitInfo, rayDistance ) ) {
		//			Debug.Log ( "you've hit the thing named: " + hitInfo.collider.name );
		//			hitInfo.collider.GetComponent<packTextures>().changeTexture();}
		
		
		if (Input.GetKeyDown("x") && Time.time > nextFire) 
		{
			Instantiate(shot, shotSpawn.position, Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0));
			nextFire = Time.time + fireRate;
			
		}

	}
	
		void OnDrawGizmos(){ 
			Gizmos.color = Color.red;
			Gizmos.DrawRay (transform.position, transform.forward * rayDistance); 

	
	
}
}
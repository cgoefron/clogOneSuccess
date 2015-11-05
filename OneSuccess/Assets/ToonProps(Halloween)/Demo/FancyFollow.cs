using UnityEngine;
using System.Collections;

public class FancyFollow : MonoBehaviour {
	public Transform target;
	public float positionTime = 1f;
	public float rotationTime = 1f;
	void Update() {
		transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime/positionTime);
		transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, Time.deltaTime/rotationTime);
	}
}
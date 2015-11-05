using UnityEngine;
using System.Collections;

public class FancyMouseLook : MonoBehaviour {
	public float sensitivity = 10f;
	public bool invert = false;
	void Update() {
		Vector2 delta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
		transform.Rotate(new Vector3(0f, delta.x*sensitivity, 0f), Space.World);
		transform.Rotate(new Vector3(delta.y*-sensitivity, 0f, 0f), Space.Self);
	}
}
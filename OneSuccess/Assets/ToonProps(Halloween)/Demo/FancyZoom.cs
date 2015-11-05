using UnityEngine;
using System.Collections;

public class FancyZoom : MonoBehaviour {
	public float sensitivity = 1f;
	public bool invert = false;
	public Vector3 zoomIn;
	public Vector3 zoomOut;
	void Update() {
		float delta = Input.GetAxis("Mouse ScrollWheel");
		transform.localPosition = Vector3.MoveTowards(transform.localPosition, delta != 0f ? (delta > 0f ? zoomIn : zoomOut ) : transform.localPosition, sensitivity*Mathf.Abs(delta)*sensitivity);
	}
	void OnDrawGizmosSelected() {
		Gizmos.color = Color.cyan;
		Gizmos.DrawSphere(transform.parent.TransformPoint(zoomIn), 0.1f);
		Gizmos.DrawSphere(transform.parent.TransformPoint(zoomOut), 0.1f);
		Gizmos.DrawLine(transform.parent.TransformPoint(zoomIn), transform.parent.TransformPoint(zoomOut));
	}
}
using UnityEngine;
using System.Collections;

public class daytonight : MonoBehaviour {

	public GameObject theSun;
	public GameObject cam;
	public Material day;
	public Material night;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (theSun.GetComponent<Light>().enabled == true) 
		{
			cam.GetComponent<Skybox>().material = day;
		}
		else
		{
			cam.GetComponent<Skybox>().material = night;
		}
	}
}

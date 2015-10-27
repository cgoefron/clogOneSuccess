using UnityEngine;
using System.Collections;

public class changesky : MonoBehaviour {

	public GameObject theSun;
	public bool isNight = false;
	public float num = 10000;

	// Use this for initialization
	void Start () {

		InvokeRepeating ("switchLight", 0, 3f);
	}
	
	// Update is called once per frame
	void Update () {

		if (!isNight) {
			theSun.GetComponent<Light>().range = 1;
	}
		else
		{
			theSun.GetComponent<Light>().range += 1;
			if(theSun.GetComponent<Light>().range >= num)
			{
				theSun.GetComponent<Light>().enabled = true;
				isNight = false; 
			}

		}
	
	}
	void switchLight() {
		//turn the light off if on, or on if off
		Light sunlight = theSun.GetComponent<Light> ();
		if (sunlight.enabled == true) {
			sunlight.enabled = false;
		} else {
			sunlight.enabled = true;
		}
	}
}

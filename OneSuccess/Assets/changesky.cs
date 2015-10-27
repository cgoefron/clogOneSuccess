using UnityEngine;
using System.Collections;

public class changesky : MonoBehaviour {

	public GameObject theSun;
	public bool isNight = false;
	public float num = 10000;

	// Use this for initialization
	void Start () {

	
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
}

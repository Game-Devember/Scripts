using UnityEngine;
using System.Collections;

public class shiftDetector : MonoBehaviour {
	public GameObject car;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
 void OnTriggerEnter(Collider other)
	{
		car.GetComponent<lennyCarControls>().normalise(other);
	    
	}
}

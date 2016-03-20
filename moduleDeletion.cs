using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class moduleDeletion : MonoBehaviour {
	// Use this for initialization
	public GameObject currentModule;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void delete(GameObject newModule)
	{   
		Debug.Log (currentModule);
		Destroy (currentModule);
		currentModule = newModule;
	}
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class moduleSpawn : MonoBehaviour {
	float spawnPosition=0.0f;
	public GameObject[] tunnelModules;
	public GameObject[] normalModules;
	public GameObject[] spawnedModules;
	int i;
	int module;
	float loc=180;
	float moduleLength=180;
	int moduleCount=0;
	public int modules=3;
	public bool spawn;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	if (spawn) {
			spawnModuleSet ();

		}
	}
	void spawnModuleSet()
	{   spawn=false;
		moduleCount = 0;
		for (i=0; i<modules; i++) 
		{

			module=(int)Random.Range(0.0f,normalModules.Length);
			Instantiate(normalModules[module],new Vector3(0,0,loc),Quaternion.identity);
			Debug.Log ("normal module");
			loc=loc+moduleLength;

		}

		module=(int)Random.Range(0,tunnelModules.Length);
	
		Instantiate(tunnelModules[module],new Vector3(0,0,loc),Quaternion.identity);
		Debug.Log ("tunnel module");
		loc=loc+moduleLength;
	}
}

using UnityEngine;
using System.Collections;

public class lennyCam : MonoBehaviour {
	public GameObject lenny;
	Vector3 pos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (0, 0, 10)); 
	}
}

using UnityEngine;
using System.Collections;

public class stageSpin : MonoBehaviour {

	public float rotationSpeed = 1.0f;
	void Start () {
	
	}
	

	void Update () {
		transform.Rotate (Vector3.up * Time.deltaTime * rotationSpeed);
	}
}

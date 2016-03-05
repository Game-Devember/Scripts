using UnityEngine;
using System.Collections;

public class coinScript : MonoBehaviour {
	
	public int coinValue = 1;
	public int rotationSpeed = 3;

	void Start () {
	
	}
	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * 100,Space.World);
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Player"){
			col.gameObject.SendMessage("sendCoins",coinValue);
			col.gameObject.SendMessage("requestDestroy",gameObject);
		}
	}
}

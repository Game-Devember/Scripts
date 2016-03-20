using UnityEngine;
using System.Collections;

public class coinScript : MonoBehaviour {
	
	public int coinValue = 1;
	public int rotationSpeed = 3;
	public AudioClip coinSound;
	void Start () {
		GetComponent<AudioSource>().clip = coinSound;
		GetComponent<AudioSource>().volume = 0.5f;
		GetComponent<AudioSource>().playOnAwake = false;
		GetComponent<AudioSource>().dopplerLevel = 0;
		GetComponent<AudioSource>().loop = false;
	}
	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * 100,Space.World);
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Player"){
			col.gameObject.SendMessage("sendCoins",coinValue);
			col.gameObject.SendMessage("requestDestroy",gameObject);
			GetComponent<AudioSource>().Play();
		}
	}
}

using UnityEngine;
using System.Collections;

public class followOrb : MonoBehaviour {
	public bool addFor = false;
	public float forceAmount = 1.0f;
	public Transform target;
	public int stoppingDistance = 1;
	public float followDamping = 1.0f;
	public float orbSpeed = 1.0f;
	public float orbAccel = 1.0f;
	public float orbTurnSpeed = 1.0f;
	public bool reset = false;
	private Vector3 startPos;
	private Quaternion startRot;
	// Use this for initialization
	void Start () {
		startPos = transform.position;
		startRot = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightArrow)){
			Debug.Log ("added Force");
			addFor = false;
			StartCoroutine(orbMovement());
		}
		if(Vector3.Distance(transform.position,target.position) <= stoppingDistance){
			Debug.Log ("reset unset");
			reset = false;
		}
		if(reset){
			transform.position = Vector3.MoveTowards(transform.position,target.position,Time.deltaTime * orbSpeed);
			Debug.Log("inThatFunction");
			//transform.Translate(Vector3.forward * Time.deltaTime * orbSpeed);
			Vector3 relativePos = target.position - transform.position;
			Quaternion rotationT = Quaternion.LookRotation(relativePos);
			transform.rotation = Quaternion.Lerp (transform.rotation,rotationT,Time.deltaTime * orbTurnSpeed);
			orbSpeed += orbAccel;
		}
		if(Input.GetKeyDown(KeyCode.Space)){
			Debug.Log("Stage Reset");
			transform.position = startPos;
			transform.rotation = startRot;
			reset = false;
			addFor = false;
		}
	}

	IEnumerator orbMovement(){
		Debug.Log ("orbMovement");
		GetComponent<Rigidbody>().AddForce(transform.up * forceAmount);
		yield return new WaitForSeconds(1 * followDamping);
		Debug.Log ("Follow Now");
		reset = true;
	}
}

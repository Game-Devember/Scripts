using UnityEngine;
using System.Collections;

public class lennyCarController : MonoBehaviour {
	public WheelCollider[] wheelColliders = new WheelCollider[4];
	public GameObject carBody;
	public float Torque;
	public  float maxSqrVelocity;
	public float steerAngle;
	public bool steer=true;
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log(carBody.GetComponent<Rigidbody>().rotation.y);
		if (Input.GetMouseButtonDown (1)) 
		{
			Vector3 pos = GetComponent<Rigidbody>().position;
			GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 1);
			pos.x=Mathf.MoveTowards (pos.x,-5, Time.deltaTime*100);
			GetComponent<Rigidbody>().position = pos;
		}
	}

	void FixedUpdate()
	  {    
		carTorque ();
      }

      void carTorque()
         {
		   //Debug.Log (carBody.GetComponent<Rigidbody> ().velocity.sqrMagnitude);
		   if (carBody.GetComponent<Rigidbody> ().velocity.sqrMagnitude > maxSqrVelocity) {
			  wheelColliders [0].motorTorque = 0;
			  wheelColliders [1].motorTorque = 0;
		     }
		  else{
			   wheelColliders [0].motorTorque = Torque;
			   wheelColliders [1].motorTorque = Torque;
		     }
		
	     }


}
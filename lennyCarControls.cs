using UnityEngine;
using System.Collections;

public class lennyCarControls : MonoBehaviour {
	 int moveLeft=0;
	int moveRight=0;
	float targetLane=0;
	int presentLane=0;
	// Use this for initialization
	void Start () {
	
	}
	public void normalise(Collider other)
	{
		if (other.gameObject.tag == "rightLane") {
			moveRight = 0;
			presentLane=1;
			gameObject.GetComponent<Animation>().Play("normalisePostRight");
			Debug.Log ("RighLane");
		}

		if (other.gameObject.tag == "leftLane") {
			moveLeft = 0;
			presentLane=-1;
			gameObject.GetComponent<Animation>().Play("normalisePostLeft");
			Debug.Log ("LeftLane");
		}
		if (other.gameObject.tag == "centreLane") {
			presentLane=0;
			if(moveLeft==1)
			{
				Debug.Log ("Play post left");
				moveLeft = 0;
				gameObject.GetComponent<Animation>().Play("normalisePostLeft");
			}
			if(moveRight==1)
			{
				Debug.Log ("Play post right");
				moveRight = 0;
				gameObject.GetComponent<Animation>().Play("normalisePostRight");
			}
			Debug.Log ("centreLane");
		}
	}
	// Update is called once per frame
	void Update ()
	{
		GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 10);

	  if(Input.GetMouseButtonDown(0))
		   {
			moveLeft=1;
			targetLane=targetLane-5;
			transform.Rotate(new Vector3(0,0,30));

			}if(Input.GetMouseButtonDown(1))
		   {
			moveRight=1;
			targetLane=targetLane+5;
			transform.Rotate(new Vector3(0,0,-30));
		   }
		if(moveLeft==1)
		{
		
			Vector3 pos = GetComponent<Rigidbody> ().position;
			pos.x = Mathf.MoveTowards (pos.x, targetLane, Time.deltaTime * 30);
			GetComponent<Rigidbody> ().position = pos;
			GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 10);

			}
		if(moveRight==1)
		{
			
			Vector3 pos = GetComponent<Rigidbody> ().position;
			pos.x = Mathf.MoveTowards (pos.x, targetLane, Time.deltaTime * 30);
			GetComponent<Rigidbody> ().position = pos;
			GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 10);
			
		}

	}
public void upSwipe()
	{

			moveLeft = 1;
			targetLane = GetComponent<Rigidbody> ().position.x - 5;
			transform.Rotate (new Vector3 (0, 0, 30));

	}
public void downSwipe()
	{
			moveRight = 1;
			targetLane = GetComponent<Rigidbody> ().position.x + 5;
			transform.Rotate (new Vector3 (0, 0, -30));

	}



	
}


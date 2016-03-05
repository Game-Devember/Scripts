using UnityEngine;
using System.Collections;

public class lerpTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine ("test");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private IEnumerator test()
	{float angle = 30;
		while (angle!=0) {

			angle = Mathf.Lerp (30, 0, Time.time*5);
			Debug.Log (angle);
			yield return new  WaitForEndOfFrame ();
		}
	}
}

using UnityEngine;
using System.Collections;

public class garageButtonScript : MonoBehaviour {

	GameObject slider;

	void Start () {
		slider = GameObject.Find("slider");
	}

	void Update () {
	
	}

	public void backToMenu(){
		slider.SendMessage("switchMenu");
	}
}

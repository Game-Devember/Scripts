using UnityEngine;
using System.Collections;

public class mainMenuButtonScript : MonoBehaviour {

	public string sceneName;
	private GameObject slider;

	void Start () {
		slider = GameObject.Find ("slider");
	}

	void Update () {
	
	}

	public void startFunction(){
		Application.LoadLevel (sceneName);
	}
	public void garageFunction(){
		slider.SendMessage("switchGarage");
	}
	public void insFunction(){
		slider.SendMessage("switchInstructions");
	}
	public void credFunction(){
		slider.SendMessage ("switchCredits");
	}
	public void credBack(){
		slider.SendMessage ("switchMenu");
	}
	public void insBack(){
		slider.SendMessage ("switchMenu");
	}
}

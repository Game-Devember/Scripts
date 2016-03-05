using UnityEngine;
using System.Collections;

public class playerCredits : MonoBehaviour {

	private int bankCredits = 0;
	public int currentCredits = 0; // UI Purposes only
	void Start () {
		if(PlayerPrefs.HasKey("playerCoins")) PlayerPrefs.SetInt("playerCoins",currentCredits);
		else currentCredits = PlayerPrefs.GetInt("playerCoins");
	}
	void Update () {
	
	}

	public void addCoins(int value){
		currentCredits += value;
	}

	public void initLevel(){ // Important to call this to enable Saving of coins
		Debug.Log ("*** Coins Updated in Prefs!");
		bankCredits += currentCredits;
		currentCredits = 0;
	}
}

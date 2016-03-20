using UnityEngine;
using System.Collections;

public class gameSupport {
	
	GameObject getPlayerGameObject(){
		GameObject gOb = GameObject.FindWithTag("Player");
		return gOb;
	}

}

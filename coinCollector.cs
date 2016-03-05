using UnityEngine;
using System.Collections;

public class coinCollector : MonoBehaviour {

	GameObject gameMaster;
	void Start () {
		gameMaster =  GameObject.Find("gameController");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "coin"){
		}
	}

	public void sendCoins(int value){
		gameMaster.SendMessage("addCoins",value);
	}
	
	public void requestDestroy(GameObject gOb){
		Destroy(gOb);
	}
}

using UnityEngine;
using System.Collections;

public class coinCollector : MonoBehaviour {

	GameObject gameMaster;
	void Start () {
		gameMaster =  GameObject.Find("GameController");
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
	
	public IEnumerator requestDestroy(GameObject gOb){
		gOb.GetComponent<Renderer>().enabled = false;
		yield return new WaitForSeconds(1);
		Destroy(gOb);
	}
}

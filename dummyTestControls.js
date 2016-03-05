#pragma strict

public var speed : int = 1.0;
public var sidSpeed : int = 1.0;
function Start () {

}

function Update () {
	
	//var forTrans : float = Input.GetAxis("Vertical") * speed;
	var sidTrans : float = Input.GetAxis("Horizontal") * sidSpeed;
	var forTrans : float = 1 * speed;
	forTrans *= Time.deltaTime;
	sidTrans *= Time.deltaTime;
	
	transform.Translate(0,0,forTrans);
	transform.Translate(sidTrans,0,0);
}
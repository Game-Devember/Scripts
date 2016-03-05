#pragma strict

public var obstacleDamage : int = 1;
public var movingForward : boolean = false;
public var movingSideways : boolean = false;
public var jumping : boolean = false;

public var movingSpeed : int = 1.0;

function Start () {
	gameObject.tag = "obstacle";
}

function Update () {
	if(movingForward) moveForward();
	if(movingSideways) {
		
	}
	if(jumping);
}

function  OnTriggerEnter(other: Collider) {
	if(other.gameObject.tag == "Player"){
		other.gameObject.SendMessage("receiveDamage",obstacleDamage);
	}
}

function moveForward(){
	transform.Translate(0,0,-1*Time.deltaTime*movingSpeed);
}
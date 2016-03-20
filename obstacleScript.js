#pragma strict

public var obstacleDamage : int = 1;
public var movingForward : boolean = false;
public var movingSideways : boolean = false;
public var jumping : boolean = false;
public var movingSpeed : int = 1.0;
public var obstacleSound : AudioClip;

function Start () {
	gameObject.tag = "obstacle";
	GetComponent.<AudioSource>().clip = obstacleSound;
	GetComponent.<AudioSource>().volume = 1;
	GetComponent.<AudioSource>().playOnAwake = false;
	GetComponent.<AudioSource>().dopplerLevel = 0;
	GetComponent.<AudioSource>().loop = false;
}

function Update () {
	if(movingForward) moveForward();
	if(movingSideways) {
		
	}
	if(jumping);
}

function  OnTriggerEnter(other: Collider) {
	if(other.gameObject.tag == "Player"){
		GetComponent.<AudioSource>().Play();
		other.gameObject.SendMessage("receiveDamage",obstacleDamage);
		other.gameObject.SendMessage("requestDestroy",gameObject);
	}
}

function moveForward(){
	transform.Translate(0,0,-1*Time.deltaTime*movingSpeed);
}
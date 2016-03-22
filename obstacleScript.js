#pragma strict

public var obstacleDamage : int = 1;
public var movingForward : boolean = false;
public var movingSideways : boolean = false;
public var movingSpeed : int = 1.0;
public var obstacleSound : AudioClip;
public var enable : boolean = false;
private var jumpLock : boolean = false;

function Start () {
	gameObject.tag = "obstacle";
	GetComponent.<AudioSource>().clip = obstacleSound;
	GetComponent.<AudioSource>().volume = 1;
	GetComponent.<AudioSource>().playOnAwake = false;
	GetComponent.<AudioSource>().dopplerLevel = 0;
	GetComponent.<AudioSource>().loop = false;
}

function Update () {
	if(enable){
		if(movingForward) moveForward();
		if(movingSideways) moveSide();
		enable = false;
	}
}

function  OnTriggerEnter(other: Collider) {
	if(other.gameObject.tag == "Player"){
		GetComponent.<AudioSource>().Play();
		other.gameObject.SendMessage("receiveDamage",obstacleDamage);
		other.gameObject.SendMessage("requestDestroy",gameObject);
	}
}
function moveSide(){
	GetComponent.<Rigidbody>().velocity = new Vector3(1 * Time.deltaTime * movingSpeed * 30,0,0);
}
function moveForward(){
	GetComponent.<Rigidbody>().velocity = new Vector3(0,0,-1*Time.deltaTime*movingSpeed*30);
}
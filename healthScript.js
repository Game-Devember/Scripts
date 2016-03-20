#pragma strict

public var maxHealth : int = 2;
public var particles : GameObject[];
private var hitsTaken : int;

function Start () {
	hitsTaken = 0;
}

function Update () {	
}

function initParticleSystem(hits: int){
	// Debug.Log(hits);
	// Debug.Log(particles[hits].name);
	particles[hits].SetActive(true);
}

function receiveDamage(amount: int){
	hitsTaken += amount;
	initParticleSystem(hitsTaken-1);
	if(hitsTaken >= maxHealth){
	
	}
}

function requestDestroy(gOb: GameObject){
	gOb.GetComponent.<Renderer>().enabled = false;
	yield WaitForSeconds(2);
	Destroy(gOb);
}
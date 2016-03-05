#pragma strict

public var speed : float = 1.0;
public var canvasGarPos : int = 0;
public var canvasCredPos : int = 0;

var inMain : boolean = false;
var inGar : boolean = false;
var inIns : boolean = false;
var inCred : boolean = false;

function Start () {
	inMain = true;
}

function Update () {
}

function switchGarage(){
	if(inMain){
		inMain = false;
		while(parseInt(Mathf.Round(transform.localPosition.x)) < canvasGarPos){
			transform.localPosition =  Vector3(Mathf.Lerp(transform.localPosition.x, canvasGarPos, Time.deltaTime * speed), 0, 0);
			yield new WaitForEndOfFrame();
		}
		transform.localPosition.x = canvasGarPos;
		inGar = true;
	}
}

function switchMenu(){
	if(inGar){
		inGar = false;
		while(parseInt(Mathf.Round(transform.localPosition.x)) > 0){
			transform.localPosition =  Vector3(Mathf.Lerp(transform.localPosition.x,0, Time.deltaTime * speed), 0, 0);
			yield new WaitForEndOfFrame();
		}
		transform.localPosition.x = 0;
		inMain = true;
	}
	else if(inCred){
		inCred = false;
		while(parseInt(Mathf.Round(transform.localPosition.y)) > 0){
			transform.localPosition = Vector3(0,Mathf.Lerp(transform.localPosition.y,0,Time.deltaTime * speed),0);
			yield new WaitForEndOfFrame();
		}
		transform.localPosition.y = 0;
		inMain = true;
	}
	else if(inIns){
		inIns = false;
		while(parseInt(Mathf.Round(transform.localPosition.x)) < 0){
			transform.localPosition =  Vector3(Mathf.Lerp(transform.localPosition.x,0, Time.deltaTime * speed), 0, 0);
			yield new WaitForEndOfFrame();
		}
		transform.localPosition.x = 0;
		inMain = true;
	}
}
function switchCredits(){
	if(inMain){
		inMain = false;
		while(parseInt(Mathf.Round(transform.localPosition.y)) < canvasCredPos){
			transform.localPosition = Vector3(0,Mathf.Lerp(transform.localPosition.y, canvasCredPos,Time.deltaTime * speed),0);
			yield new WaitForEndOfFrame();
		}
		transform.localPosition.y = canvasCredPos;
		inCred = true;
	}
}

function switchInstructions(){
	if(inMain){
		inMain = false;
		while(parseInt(Mathf.Round(transform.localPosition.x)) > -canvasGarPos){
			transform.localPosition =  Vector3(Mathf.Lerp(transform.localPosition.x, -canvasGarPos, Time.deltaTime * speed), 0, 0);
			yield new WaitForEndOfFrame();
		}
		transform.localPosition.x = -canvasGarPos;
		inIns = true;
	}
}		

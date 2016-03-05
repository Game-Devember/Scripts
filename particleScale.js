#pragma strict

public var targetScale : Vector3;
public var speed : float = 1.0;
public var destroyTime : float = 1.0;
public var colTime : float = 1.0;
function Start () {

	Invoke("destroyMe",destroyTime);
	Invoke("removeCol",colTime);

}

function Update () {

	transform.localScale = Vector3.Lerp(transform.localScale,targetScale,speed * Time.deltaTime);
}

function destroyMe()
{
	Destroy(gameObject);
}

function removeCol()
{
	gameObject.GetComponent.<Collider>().enabled = false;
}
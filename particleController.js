#pragma strict

public var brokenRockParticles : GameObject;
public var numberRocks : int;
function Start () {
//Debug.Log("Script On");
//Debug.Log(gameObject.name);
}

function Update () {

}

function OnTriggerEnter(col : Collider)
{
	//Debug.Log("Collision Found");
	if(col.gameObject.tag == "bRock")
	{
		//Debug.Log("Collision Found on Rock");
		var i = 0;
		while(i<numberRocks)
		{
			Instantiate(brokenRockParticles,col.gameObject.transform.position,col.gameObject.transform.rotation);
			i++;
		}
		Destroy(col.gameObject);
	}
}
var TheKey : GameObject;
private var playerNextToKey = false;

function Update () 
{
 	if (Input.GetKeyDown(KeyCode.E) && playerNextToKey == true)
	{
	TheKey.active = false;
	//Debug.Log("tes");
	}
}

function OnTriggerEnter (theCollider : Collider)
{
	if (theCollider.tag == "Player")
	{
		playerNextToKey = true;
		//print("ASDAS");
	}
}

function OnTriggerExit (theCollider : Collider)
{
	if (theCollider.tag == "Player")
	{
		playerNextToKey = false;
	}
}
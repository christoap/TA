var doorClip : AnimationClip;
//var Key : GameObject;
private var Door = false;

function Start () 
{

}

function Update () 
{
	if (Input.GetKeyDown(KeyCode.E) && Door == true)
	{
	GameObject.Find("level1").GetComponent.<Animation>().Play("levelDoor");

	}

}

function OnTriggerEnter (theCollider : Collider)
{
	if (theCollider.tag == "Player")
	{
		Door = true;
	}
}

function OnTriggerExit (theCollider : Collider)
{
	if (theCollider.tag == "Player")
	{
		Door = false;
	}
}
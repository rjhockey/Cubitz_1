using UnityEngine;

public class EndTrigger : MonoBehaviour
{

	public GameManager gameManager;

	void OnTriggerEnter()
	{
		Debug.Log("Invisible End hit");
		gameManager.CompleteLevel();
	}

}

// this is linked to the 'End' object in Unity. When the player
// has passed all the obstacles, they will strike this invisible
// object that will call the CompleteLevel method from the
// GameManager script

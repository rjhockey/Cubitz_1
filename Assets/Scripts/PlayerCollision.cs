using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public GameManager gameManager;  // Creates a public reference to the GameManager so
	// you can link to playerCollision under player in inspector and call EndGame below

	public PlayerMovement movement;     // A reference to our PlayerMovement script

    // This function runs when we hit another object.
    // We get information about the collision and call it "collisionInfo".


    void OnCollisionEnter(Collision collisionInfo)
	{
		// We check if the object we collided with has a tag called "Obstacle".

		if (collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;   // Disable the players movement.
			gameManager.EndGame();
		}
	}

}

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

	bool gameHasEnded = false;

	public float restartDelay = 1f;

	public GameObject completeLevelUI;   // connects to EndTrigger script

	public void CompleteLevel()   // triggered when lvl completed successfully
	{
		Debug.Log("lvl completed");
		completeLevelUI.SetActive(true);
	}

	public void EndGame()    // restarts level when obstacle has been hit
	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			Debug.Log("restart level");
			Invoke("Restart", restartDelay);
		}
	}

	void Restart()
	{
		// when player hits obstacle, this restarts the same scene from beginning
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}

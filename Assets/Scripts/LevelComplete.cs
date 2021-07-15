using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{

	public void LoadNextLevel()  // Loads the next level DUH!
	{
		Debug.Log("Load Next Level");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

}

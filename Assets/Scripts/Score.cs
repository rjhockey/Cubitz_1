using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

	public Transform player;
	public Text scoreText;

	// Update is called once per frame
	void Update()
	{
		scoreText.text = player.position.z.ToString("0");
	}
} // more nonsense to test git branching
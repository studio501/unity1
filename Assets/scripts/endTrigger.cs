using UnityEngine;

public class endTrigger : MonoBehaviour
{
	public GameManager gameManager;
	public Player movement;
	void OnTriggerEnter()
	{
		gameManager.CompleteLevel();
		movement.enabled = false;
	}
}

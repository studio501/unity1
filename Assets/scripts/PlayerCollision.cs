using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public Player movement;
	public void OnCollisionEnter(Collision info)
	{
		
		if(info.collider.tag == "Obstacle"){
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}

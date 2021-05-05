using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	bool isGameEnd = false;
	public float delayTime = 1f;
	public GameObject winUI;
	public void EndGame()
	{
		if(isGameEnd){
			return;
		}
		isGameEnd = true;
		
		Invoke("Restart",delayTime);
	}

	public void CompleteLevel()
	{
		winUI.SetActive(true);
	}

	void Restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}

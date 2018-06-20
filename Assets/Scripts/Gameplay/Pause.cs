using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

//programação do menu de pause, controlado pelos botões
	
//pausa o tempo da fase	
	public void PauseGame()
	{
		Time.timeScale = 0f;
	}
//retoma a fase
	public void ResumeGame()
	{

		Time.timeScale = 1;
	}
//volta pro menu
	public void BackMenu()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene("Menu");
	}
//Restart fase
	public void RestartLvl(string fase)
	{
		Time.timeScale = 1;
		SceneManager.LoadScene(fase);	
	}

}

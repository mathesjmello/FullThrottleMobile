using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManeger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Quit()
	{
		Application.Quit();
	}

	public void NewGame()
	{
		SceneManager.LoadScene("tela1");
	}
	public void ContnueGame()
	{
		var cena = Persistense.LastCena;
		SceneManager.LoadScene("tela1");
	}
}

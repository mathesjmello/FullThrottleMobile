using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	public GameObject alert;

	// quando esse script se inicia ele carrega as informações do persistence
	void Start(){
		Persistense.LoadData();
	}
	// botão que sai do jogo
	public void Sair(){

		Application.Quit ();
	}
// botão que volta para a tela de faser
	public void Play(){

		SceneManager.LoadScene("Game");
	}
	// botão que volta para o menu
	public void MenuBack(){

		SceneManager.LoadScene ("Menu");
	}

	// mostra tela de sair quando clica no voltar do celular
	void  Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			alert.SetActive (true);

		}

	}
}

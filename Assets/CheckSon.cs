using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSon : MonoBehaviour
{

	public AudioSource Musica;
	public AudioSource SFX;
	// =Checa se o playerprefs de som está zerado ou n, se estiver ele para os aoudios se n eles tocam
	void Start () {
		if (PlayerPrefs.GetFloat("MVolume") <= 0)
		{
			Musica.Stop();
		}
		if (PlayerPrefs.GetFloat("SFXVolume") <= 0)
		{
			SFX.gameObject.SetActive(false);
		}
	}
	
}

using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Interactables : InteractiveView
{
	private bool _highLighted;
	public GameObject Moto, Barman, Porta, Saida, Piano;
	public Text TextoFala;
	public string Visto;
	public AudioSource Som;

	private void Start()
	{
		Persistense.LoadData();
		if (Persistense.PortaOpen == 1&&Porta)
		{
			Saida.SetActive(true);
			Porta.SetActive(false);
			
		}
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

			if (hit.collider != null && hit.transform.gameObject == gameObject)
			{
				var hittedObject = hit.collider.gameObject;
				if (hit.collider.name != "botao")
				{
					_painel.Open(this);
				}
			}
		}
	}

	public override void Grab()
	{
		if (Pegavel)
		{
			
			_painel.transform.position = Vector3.up * 1000;
			
			
			if (Persistense.HaveKey == 0 && Barman != null)
			{
				Persistense.HaveKey = 1;
				Persistense.SaveData();
			}				
			if (Persistense.HaveKey == 1 && Barman != null)
			{
				_painel.transform.position = Vector3.up * 1000;
				
				TextoFala.text = "Ele já me deu a chave";
				TextoFala.gameObject.SetActive(true);
			}
			if (Persistense.HaveKey == 0 && Moto != null)
			{
				TextoFala.text="Não estou com minha chave";
				_painel.transform.position = Vector3.up * 1000;
				TextoFala.gameObject.SetActive(true);
			}				
			if (Persistense.HaveKey == 1 && Moto != null)
			{
				Application.Quit();
			}
			
		}
		else
		{
			_painel.transform.position = Vector3.up * 1000;

			if (Porta)
			{
				TextoFala.text="A porta esta trancada";
				TextoFala.gameObject.SetActive(true);
			}
			else
			{
				TextoFala.text="haaaaa... não";
				TextoFala.gameObject.SetActive(true);
			}
			
		}
}

	public override void See()
	{
		_painel.transform.position= Vector3.up*1000;
		TextoFala.text=Visto;
		TextoFala.gameObject.SetActive(true);
	}

	public override void Kick()
	{
		if (Chutavel)
		{
			if (Porta)
			{		
				Saida.SetActive(true);
				Porta.SetActive(false);
				Persistense.PortaOpen = 1;
				Persistense.SaveData();
				TextoFala.text="agora a porta ta aberta";
				TextoFala.gameObject.SetActive(true);
			}
			_painel.transform.position = Vector3.up * 1000;
			if (Piano)
			{
				Som.Play();
			}
			_painel.transform.position = Vector3.up * 1000;
		}
		else
		{
			_painel.transform.position = Vector3.up * 1000;
			TextoFala.text="Isso não vai funcionar";
			TextoFala.gameObject.SetActive(true);
		}
	}
	
	public void ShowHighLights()
	{
		if (_highLighted)
		{
			gameObject.GetComponent<SpriteRenderer>().color = Color.white;
			_highLighted = false;
		}
		else
		{
			gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
			_highLighted = true;
		}
	}
}

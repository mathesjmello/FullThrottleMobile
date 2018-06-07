using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;

public class Interactables : InteractiveView
{
	private bool _highLighted;
	public GameObject Moto, Barman, Porta, Saida;
	public string Visto;

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
				Debug.Log("Não posso pegar");
				_painel.transform.position = Vector3.up * 1000;
			}
			if (Persistense.HaveKey == 0 && Moto != null)
			{
				Debug.Log("Não estou com minha chave");
				_painel.transform.position = Vector3.up * 1000;
			}				
			if (Persistense.HaveKey == 1 && Moto != null)
			{
				Application.Quit();
			}
			
		}
		else
		{
			Debug.Log("Não posso pegar");
			_painel.transform.position = Vector3.up * 1000;
		}
}

	public override void See()
	{
		Debug.Log(Visto);
		_painel.transform.position= Vector3.up*1000;
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
			}
			_painel.transform.position = Vector3.up * 1000;
		}
		else
		{
			Debug.Log("não posso chutar");
			_painel.transform.position = Vector3.up * 1000;
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

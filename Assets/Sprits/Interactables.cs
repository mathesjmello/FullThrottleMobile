using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Interactables : InteractiveView
{
	private bool _highLighted;
	public string Visto;

	

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
			Debug.Log("posso pegar");
			_painel.transform.position = Vector3.up * 1000;
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
			Debug.Log("posso chutar");
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

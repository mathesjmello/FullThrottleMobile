using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : InteractiveView
{
	private bool _highLighted = false;
	public bool Pegavel, Chutavel;
	public string Visto;


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

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

			if (hit.collider != null)
			{
				var hittedObject = hit.collider.gameObject;
				var painel = FindObjectOfType<Painel>();
				painel.transform.position = hittedObject.transform.position;

			}
			else
			{
				var painel = FindObjectOfType<Painel>();
				painel.transform.position = Vector3.up * 100;
			}
		}
	}

	public void Kick()
	{
		if (Chutavel)
		{
			Debug.Log("posso chutar");
		}
	}
	public void Grab()
	{
		if (Pegavel)
		{
			Debug.Log("posso pegar");
		}
	}
	public void Look()
	{
		Debug.Log(Visto);
	}
}

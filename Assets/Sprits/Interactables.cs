using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : InteractiveView
{
	private bool _highLighted=false;
	
	public void ShowHighLights()
	{
		if (_highLighted)
		{
			gameObject.GetComponent<SpriteRenderer>().color= Color.white;
			_highLighted = false;
		}
		else
		{
			gameObject.GetComponent<SpriteRenderer>().color= Color.yellow;
			_highLighted = true;
		}
	}
}

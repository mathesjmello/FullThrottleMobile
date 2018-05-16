using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveView : MonoBehaviour
{

	public void ShowInteractive()
	{
		var listInterectables = FindObjectsOfType<Interactables>();
		foreach (var interactable in listInterectables)
		{
			interactable.ShowHighLights();
		}
	}
}

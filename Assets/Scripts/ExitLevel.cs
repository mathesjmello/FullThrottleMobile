using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{

	[SerializeField] private string _nextlevel,_oldlevel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

			if (hit.collider != null && hit.transform.gameObject == gameObject)
			{
				var hittedObject = hit.collider.gameObject;
				if (hittedObject.name == "saida")
				{
					SceneManager.LoadScene(_nextlevel);
				}
				if (hittedObject.name == "saida2")
				{
					SceneManager.LoadScene(_oldlevel);
				}
			}
		}
	}
}

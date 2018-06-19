using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalaBallon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnEnable()
	{
		Invoke("Some",4);
	}

	void Some()
	{
		gameObject.SetActive(false);
	}
}

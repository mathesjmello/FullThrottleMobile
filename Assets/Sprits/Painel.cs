using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Painel : MonoBehaviour
{
	public Button Kick, Grab, See;
	private InteractiveView _interactible;

	private void Start()
	{
		Kick.onClick.AddListener(OnKick);
		Grab.onClick.AddListener(OnGrab);
		See.onClick.AddListener(OnSee);
	}

	private void OnSee()
	{
		if(_interactible == null) return;
                
   		_interactible.See();
		
	}

	private void OnGrab()
	{
		if(_interactible == null) return;
        
   		_interactible.Grab();
		
	}

	private void OnKick()
	{
		if(_interactible == null) return;

		_interactible.Kick();
	}

	public void Open(InteractiveView interactible)
	{
		_interactible = interactible;
		transform.position = new Vector3(interactible.transform.position.x, interactible.transform.position.y, transform.position.z); 

		Kick.interactable = _interactible.Chutavel;
		Grab.interactable = _interactible.Pegavel;
	}
}

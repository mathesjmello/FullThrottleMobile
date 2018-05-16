using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveView : MonoBehaviour
{
    public bool Pegavel, Chutavel;
    protected Painel _painel;

    private void Awake()
    {
        _painel = FindObjectOfType<Painel>();
    }

    public void ShowInteractive()
    {
        var listInterectables = FindObjectsOfType<Interactables>();
        foreach (var interactable in listInterectables)
        {
            interactable.ShowHighLights();
        }
    }

    public virtual void Kick()
    {
    }
    public virtual void Grab()
    {
    }
    public virtual void See()
    {
    }
}
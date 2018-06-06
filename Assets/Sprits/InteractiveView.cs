using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveView : MonoBehaviour
{
    private bool _reset;
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
            Persistense.PortaOpen = 0;
            Persistense.HaveKey = 0;
            Persistense.SaveData();
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
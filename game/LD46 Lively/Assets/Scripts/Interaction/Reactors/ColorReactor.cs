using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorReactor : StateReactor
{

    public Color active;
    public Color inactive;
    //public GameObject coloringBook;
    SkinnedMeshRenderer mesh;
    
    protected override void Awake()
    {
        base.Awake();
        mesh = GetComponentInChildren<SkinnedMeshRenderer>();

    }

    public override void React()
    {
        var block = new MaterialPropertyBlock();

        if (switcher.state)
        {
            block.SetColor("_BaseColor", active);
            //mesh.material.color = active;
            Debug.Log("Set color to " + active);
        } else
        {
            block.SetColor("_BaseColor", inactive);
            //mesh.material.color = inactive;
            Debug.Log("Set color to " + inactive);
        }

        mesh.SetPropertyBlock(block);
    }

}

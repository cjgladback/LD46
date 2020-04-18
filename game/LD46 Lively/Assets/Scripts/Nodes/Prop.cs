using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : Node
{
    
    public Location loc;
    Interactible inter;

    void Start()
    {
        inter = GetComponent<Interactible>();
    }

    public override void Arrive()
    {
        if (inter != null && inter.enabled)
        {
            inter.Interact();
            return;
        }

        base.Arrive();

        //make this object interactible
        if (inter != null)
        {
            col.enabled = true;
            inter.enabled = true;
        }
    }

    public override void Leave()
    {
        base.Leave();

        if (inter != null)
        {
            inter.enabled = false;
        }
    }
}

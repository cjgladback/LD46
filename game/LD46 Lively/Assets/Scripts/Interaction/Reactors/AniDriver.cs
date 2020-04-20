using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniDriver : StateReactor
{
    Animator anim;
    protected override void Awake()
    {
        base.Awake();
        anim = GetComponent<Animator>();
    }

    public override void React()
    {
        if (anim.GetBool("Moving") == false)
        {
            anim.SetBool("Moving", true);
        } else
        {
            anim.SetBool("Moving", false);
        }
    }
}


/*
 Todo essentials:
 Make target manager.
 Control activation and deactivation of each walnut locator.
 Make UI - right click and left click images based on level in hierarchy (Waypoint vs Location vs Prop w/o Interactable)
 Count up Bored for each non-useful interactable; end game when Bored exceeds limit.
 Get texture on Terrain!
 Good ending UI clarity
*/
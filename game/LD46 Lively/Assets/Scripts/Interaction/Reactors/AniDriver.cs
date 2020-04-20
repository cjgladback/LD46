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

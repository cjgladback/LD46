using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : Interactible
{

    public bool state;
    public CrouchAlways crouch;
    public bool good;

    public MoveStuff move;

    //public Transform walnutTarget;
    //public Transform switcherTarget;
    //public Transform catTarget;

    //event setup
    public delegate void OnStateChange();
    public event OnStateChange Change;

    public override void Interact()
    {
        state = !state;

        if (Change != null)
        {
            Change();
        }

        crouch.Crouch(good);

        ////if we could just get the darn game working, here are the actual reaction thoughts
        //if (good == true)
        //{
        //    move.AwayWeGo(walnutTarget, switcherTarget, catTarget);
        //}

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : Interactible
{

    public bool state;

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

        //if (GetComponent<StateReactor>() != null)
        //{
        //    GetComponent<StateReactor>().React();
        //}
    }

}

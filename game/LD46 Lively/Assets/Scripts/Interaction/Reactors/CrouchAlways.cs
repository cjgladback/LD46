using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchAlways : MonoBehaviour
{
    public Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void Crouch(bool good)
    {
        anim.SetBool("Pouncy", false);
        if (good == true)
        {
            anim.SetBool("Pouncy", true);
            anim.SetFloat("Bored", 0.0f);
        } else
        {
            float boredom = anim.GetFloat("Bored");
            anim.SetFloat("Bored", boredom + 1);
        }
        anim.SetTrigger("Crouch");
    }
}

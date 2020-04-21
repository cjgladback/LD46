using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WalnutShaker : MonoBehaviour
{
    public Transform target;
    public float walnutFollow;

    void Awake()
    {
        //important thing
        this.enabled = false;
        
        WalnutPlacer place = GetComponent("WalnutPlacer") as WalnutPlacer;

        place.enabled = false;

        DoTheMove();

        place.enabled = true;
    }

    void DoTheMove()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(transform.DOMove(target.position, walnutFollow));
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WalnutShaker : MonoBehaviour
{
    public Transform target;
    public float walnutFollow;

    void Update()
    {

        Sequence seq = DOTween.Sequence();
        seq.Append(transform.DOMove(target.position, walnutFollow));

    }

}

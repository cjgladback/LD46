﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraRig : MonoBehaviour
{
    public Transform y_axis;
    public Transform x_axis;
    public float moveTime;

    public void AlignTo(Transform target)
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(y_axis.DOMove(target.position, moveTime));
        seq.Join(x_axis.DOMove(target.position, moveTime));
        seq.Join(y_axis.DORotate(new Vector3(target.rotation.eulerAngles.x, target.rotation.eulerAngles.y, 0f), moveTime));
        //seq.Join(x_axis.DOLocalRotate(new Vector3(target.rotation.eulerAngles.x, 0f, 0f), moveTime));

        //Camera.main.transform.position = cameraPosition.position;
        //Camera.main.transform.rotation = cameraPosition.rotation;

    }
}

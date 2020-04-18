﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public abstract class Node : MonoBehaviour
{
    public Transform cameraPosition;
    public List<Node> reachableNodes = new List<Node>();

    [HideInInspector]
    public Collider col;

    // Start is called before the first frame update
    void Awake ()
    {
        col = GetComponent<Collider>();
        col.enabled = false;
    }

    private void OnMouseDown()
    {
        Arrive();
    }

    public virtual void Arrive()
    {
        //leave existing currentNode
        if (GameManager.ins.currentNode != null)
        {
            GameManager.ins.currentNode.Leave();
        }

        //set currentNode
        GameManager.ins.currentNode = this;

        //move the camera
        GameManager.ins.rig.AlignTo(cameraPosition);

        //turn off our own collider
        if (col != null)
        {
            col.enabled = false;
        }

        //turn on all reachable nodes' colliders
        foreach (Node node in reachableNodes)
        {
            if(node.col != null)
            {
                node.col.enabled = true;
            }
        }
    }

    public virtual void Leave()
    {
        //turn off all reachable nodes' colliders
        foreach (Node node in reachableNodes)
        {
            if (node.col != null)
            {
                node.col.enabled = false;
            }
        }
    }
}

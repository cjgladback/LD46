using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickIndicator : MonoBehaviour
{
    [HideInInspector]
    public Node currentNode;

    public RawImage leftClickPrefab;
    public RawImage rightClickPrefab;
    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetMouseButtonDown(0))
        //{
            //wipe the click icons
            GameObject clearCanvas = GameObject.FindGameObjectWithTag("clicksInstruction");
            RemoveChildren(clearCanvas);

            //2 means both buttons, 1 means only left, 0 means only right
            if (currentNode.GetComponent<Interactible>() || currentNode.GetComponent<Location>() )
            {
                //update click instructions
                DisplayClicks(2);
            } else if (currentNode.GetComponent<Waypoint>() != null)
            {
                DisplayClicks(1);
            } else
            {
                DisplayClicks(0);
            }
        //}

    }

    void RemoveChildren(GameObject clearCanvas)
    {
        int childCount = clearCanvas.transform.childCount;
        for (int i = childCount - 1; i >= 0; --i)
        {
            GameObject.Destroy(clearCanvas.transform.GetChild(i).gameObject);
        }
    }

    void DisplayClicks(int many)
    {
        if (many > 0)
        {
            RawImage left = Instantiate(leftClickPrefab) as RawImage;
            left.transform.SetParent(this.canvas.transform, false);
        }
        if (many == 0 || many == 2)
        {
            RawImage right = Instantiate(rightClickPrefab) as RawImage;
            right.transform.SetParent(this.canvas.transform, false);
        }
    }
}

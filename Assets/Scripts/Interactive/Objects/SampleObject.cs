using Interactive;
using Interactive.LocationInteractive;
using System.Collections.Generic;
using UnityEngine;

public class SampleObject : MonoBehaviour
{
    InteractiveObject obj;
    Outline outline;
    private void Awake()
    {
        outline = GetComponent<Outline>();
        obj = GetComponent<InteractiveObject>();

        outline.OutlineColor = Color.blue;
        obj.ObjectAction = OnPeretask;
        
    }

    private void OnPeretask()
    {
        Debug.Log("sdfsdf");
        if (outline.OutlineColor == Color.blue)
        {
            outline.OutlineColor = Color.red;
        }
        else if(outline.OutlineColor == Color.red)
        {
            outline.OutlineColor = Color.blue;
        }
    }
}

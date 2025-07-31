using Interactive;
using Interactive.LocationInteractive;
using System.Collections.Generic;
using UnityEngine;

public class SampleObject : MonoBehaviour
{
    private InteractiveObject _obj;
    private Outline _outline;
    private void Awake()
    {
        _outline = GetComponent<Outline>();
        _obj = GetComponent<InteractiveObject>();

        _outline.OutlineColor = Color.blue;
        _obj.ObjectAction = OnPeretask;
        
    }

    private void OnPeretask()
    {
        Debug.Log("sdfsdf");
        if (_outline.OutlineColor == Color.blue)
        {
            _outline.OutlineColor = Color.red;
        }
        else if(_outline.OutlineColor == Color.red)
        {
            _outline.OutlineColor = Color.blue;
        }
    }
}

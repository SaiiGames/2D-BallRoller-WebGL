using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDebugger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ControlManager.instance.OnTouchStart += OnTouchStart;
        ControlManager.instance.OnTouchEnd += OnTouchEnd;
        ControlManager.instance.OnTouchCancel += OnTouchCancel;


    }

    void OnTouchStart()
    {
        GetComponent<SpriteRenderer>().color = Color.green;
    }

    void OnTouchEnd()
    {
        GetComponent<SpriteRenderer>().color = Color.white;

    }
    
    void OnTouchCancel()
    {
        GetComponent<SpriteRenderer>().color = Color.red;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

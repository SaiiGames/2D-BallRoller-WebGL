using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class IntroCanvas : MonoBehaviour
{
    public UnityEvent onCanvasHide;

    public void Update()
    {
        
        CanvasBehaviour();
    }

    public virtual void CanvasBehaviour()
    {
        
    }

    private void CheckTouch()
    {
        
    }
}

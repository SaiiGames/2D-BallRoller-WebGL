using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class ControlManager : MonoBehaviour
{
    public static ControlManager instance;
    
    public delegate void OnTouchStartEvent();
    public event OnTouchStartEvent OnTouchStart;
    public delegate void OnTouchEndEvent();
    public event OnTouchEndEvent OnTouchEnd;
    public delegate void OnTouchCancelEvent();
    public event OnTouchCancelEvent OnTouchCancel;
    
    private InputControl _inputControl;
    private void Awake()
    {
        instance = this;
        _inputControl = new InputControl();
    }

    private void OnEnable()
    {
        _inputControl.Enable();
    }

    private void OnDisable()
    {
        _inputControl.Disable();
    }

    void Start()
    {
        // Debug.developerConsoleVisible = true;
        _inputControl.Input.Hold.started += OnTouchStarted;
        _inputControl.Input.Hold.performed += OnTouchEnded;
        _inputControl.Input.Hold.canceled += OnTouchCanceled;
        // _inputControl.Input.Touch.performed += OnTouchEnded;
    }

    void OnTouchStarted(InputAction.CallbackContext ctx)
    {
        // ctx.interaction
        Debug.Log("Start" + ctx.ReadValue<float>());
        OnTouchStart?.Invoke();
    }

    void OnTouchEnded(InputAction.CallbackContext ctx)
    {
        Debug.Log("End" + ctx.ReadValue<float>());
        OnTouchEnd?.Invoke();
    }
    
    void OnTouchCanceled(InputAction.CallbackContext ctx)
    {
        Debug.Log("End" + ctx.ReadValue<float>());
        OnTouchCancel?.Invoke();
    }

}

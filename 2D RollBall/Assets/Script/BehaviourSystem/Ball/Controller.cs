using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    public float speed;
    private Rigidbody2D Rigid2D;
    // public bool UseKeyboard = false;
    public int pow;

    private void Awake()
    {
        Rigid2D = gameObject.GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        if(AttitudeSensor.current != null)
            InputSystem.EnableDevice(Accelerometer.current);
    }

    private void FixedUpdate()
    {
        
        Vector3 acc = Accelerometer.current.acceleration.ReadValue();
        // var vertical = math.pow(acc.x, pow);
        // var horizontal = math.pow(acc.y, pow);
        var acc2D = new Vector2(acc.x, acc.y) * speed;
        Rigid2D.AddForce(acc2D);
        
    }
}
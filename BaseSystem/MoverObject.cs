using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoverObject : BaseObject {

    public Rigidbody rb;
    
    public float speed;
    public float angle;

    protected virtual void Start() {
        rb = GetComponent<Rigidbody>();
    }
}

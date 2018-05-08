using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileGravityController : MonoBehaviour {

    public float gravity;
    private Rigidbody rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Use this for initialization
    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(0.0F, gravity * rb.mass, 0.0F));
    }
}

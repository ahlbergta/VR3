using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour {

    public int speed;

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);
    }
}

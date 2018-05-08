using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchController : MonoBehaviour {

    public GameObject projectile;
    public float velocity;

    void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && projectile != null)
        {
            projectile.GetComponent<Rigidbody>().AddForce(transform.forward * velocity);
            projectile = null;
        }
	}
}

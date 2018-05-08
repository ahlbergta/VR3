using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerController : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "Inactive")
        {
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
        }
    }
}

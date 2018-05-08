using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour {

    public float radius;
    public float power;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "Inactive")
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddExplosionForce(power, transform.position, radius, 3.0F);
                }
            }
            Destroy(this.gameObject);
        }
    }
}

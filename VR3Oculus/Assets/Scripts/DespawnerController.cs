using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Projectile")
            other.gameObject.AddComponent<Despawn>();
    }
}

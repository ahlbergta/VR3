using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour {

    private float time = 10.0F;

	// Use this for initialization
	void Start () {
        StartCoroutine(StartDespawn());
	}
	
	// Update is called once per frame
	IEnumerator StartDespawn() {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
	}
}

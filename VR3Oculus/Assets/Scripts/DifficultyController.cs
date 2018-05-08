using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyController : MonoBehaviour {

    public float easy;
    public float medium;
    public float hard;

	// Use this for initialization
	void Start () {
        foreach(GameObject block in GameObject.FindGameObjectsWithTag("Easy"))
        {
            Rigidbody rb = block.GetComponent<Rigidbody>();
            if(rb != null)
            {
                Transform tran = block.GetComponent<Transform>();
                rb.mass = tran.lossyScale.x * tran.lossyScale.y * tran.lossyScale.z * easy;
            }
        }
        foreach (GameObject block in GameObject.FindGameObjectsWithTag("Medium"))
        {
            Rigidbody rb = block.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Transform tran = block.GetComponent<Transform>();
                rb.mass = tran.lossyScale.x * tran.lossyScale.y * tran.lossyScale.z * medium;
            }
        }
        foreach (GameObject block in GameObject.FindGameObjectsWithTag("Hard"))
        {
            Rigidbody rb = block.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Transform tran = block.GetComponent<Transform>();
                rb.mass = tran.lossyScale.x * tran.lossyScale.y * tran.lossyScale.z * hard;
            }
        }
    }
}

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
            block.GetComponent<Rigidbody>().mass = easy;
        }
        foreach (GameObject block in GameObject.FindGameObjectsWithTag("Medium"))
        {
            block.GetComponent<Rigidbody>().mass = medium;
        }
        foreach (GameObject block in GameObject.FindGameObjectsWithTag("Hard"))
        {
            block.GetComponent<Rigidbody>().mass = hard;
        }
    }
}

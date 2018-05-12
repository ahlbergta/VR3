using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour {

    private Points points;
    private TextMesh text;

	// Use this for initialization
	void Start () {
        points = GameObject.Find("PointTracker").GetComponent<Points>();
        text = gameObject.GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Points: " + points.points;
	}
}

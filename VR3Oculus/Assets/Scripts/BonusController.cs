using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusController : MonoBehaviour {

    public int value;
    private Points points;

	// Use this for initialization
	void Start () {
        points = GameObject.Find("PointTracker").GetComponent<Points>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag != "Inactive")
        {
            points.points += value;
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour {

    public int value;
    private Points points;

    // Use this for initialization
    void Start () {
        points = GameObject.Find("PointTracker").GetComponent<Points>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Inactive")
        {
            points.points += value;
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveController : MonoBehaviour {

    public int value;
    private Points points;
    private WinController win;

    // Use this for initialization
    void Start()
    {
        points = GameObject.Find("PointTracker").GetComponent<Points>();
        win = GameObject.Find("UI").GetComponent<WinController>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Inactive")
        {
            points.points += value;
            win.CheckWin();
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendorController : MonoBehaviour {

    public int cost0;
    public int cost1;
    public int cost2;
    public GameObject projectile0;
    public GameObject projectile1;
    public GameObject projectile2;
    private Points points;

    // test attributes
    private Transform launcher;
    private LaunchController lc;

    // Use this for initialization
    void Start () {
        points = GameObject.Find("PointTracker").GetComponent<Points>();

        // get test attributes
        launcher = GameObject.Find("Launcher").transform;
        lc = launcher.gameObject.GetComponent<LaunchController>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            if (points.points >= cost0 && lc.projectile == null)
            {
                points.points -= cost0;
                GameObject projectile = Instantiate(projectile0, launcher);
                lc.projectile = projectile;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if(points.points >= cost1 && lc.projectile == null)
            {
                points.points -= cost1;
                GameObject projectile = Instantiate(projectile1, launcher);
                lc.projectile = projectile;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (points.points >= cost2 && lc.projectile == null)
            {
                points.points -= cost2;
                GameObject projectile = Instantiate(projectile2, launcher);
                lc.projectile = projectile;
            }
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendorController : MonoBehaviour {

    public int cost0;
    public int cost1;
    public int cost2;
    public int cost3;
    public GameObject projectile0;
    public GameObject projectile1;
    public GameObject projectile2;
    public GameObject projectile3;
    private Points points;

    private GameObject insufficient;

    // Use this for initialization
    void Start () {
        points = GameObject.Find("PointTracker").GetComponent<Points>();
        insufficient = GameObject.Find("Text_Insufficient");
        insufficient.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.GetDown(OVRInput.Button.One) || Input.GetKeyDown(KeyCode.Alpha1))
        {
            
            if (points.points >= cost0)
            {
                points.points -= cost0;
                GameObject projectile = Instantiate(projectile0);
            }
            else
            {
                StartCoroutine(Insufficient());
            }
        }
        if (OVRInput.GetDown(OVRInput.Button.Two) || Input.GetKeyDown(KeyCode.Alpha2))
        {

            if (points.points >= cost1)
            {
                points.points -= cost1;
                GameObject projectile = Instantiate(projectile1);
            }
            else
            {
                StartCoroutine(Insufficient());
            }
        }
        if (OVRInput.GetDown(OVRInput.Button.Three) || Input.GetKeyDown(KeyCode.Alpha3))
        {

            if (points.points >= cost2)
            {
                points.points -= cost2;
                GameObject projectile = Instantiate(projectile2);
            }
            else
            {
                StartCoroutine(Insufficient());
            }
        }
        if (OVRInput.GetDown(OVRInput.Button.Four) || Input.GetKeyDown(KeyCode.Alpha4))
        {

            if (points.points >= cost3)
            {
                points.points -= cost3;
                GameObject projectile = Instantiate(projectile3);
            }
            else
            {
                StartCoroutine(Insufficient());
            }
        }
        /*
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            if (points.points >= cost0)
            {
                points.points -= cost0;
                GameObject projectile = Instantiate(projectile0);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if(points.points >= cost1)
            {
                points.points -= cost1;
                GameObject projectile = Instantiate(projectile1);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (points.points >= cost2)
            {
                points.points -= cost2;
                GameObject projectile = Instantiate(projectile2);
            }
        }*/
    }

    private IEnumerator Insufficient()
    {
        insufficient.SetActive(true);
        yield return new WaitForSeconds(2);
        insufficient.SetActive(false);
    }
}

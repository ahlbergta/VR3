using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinController : MonoBehaviour {

    private GameObject winText;

	// Use this for initialization
	void Start () {
        winText = GameObject.Find("Text_Win");
        winText.SetActive(false);
	}

    public void CheckWin()
    {
        if(GameObject.FindGameObjectsWithTag("Objective").Length == 1)
        {
            winText.SetActive(true);
        }
    }
}

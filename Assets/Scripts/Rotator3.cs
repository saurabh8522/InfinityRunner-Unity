﻿using UnityEngine;
using System.Collections;

public class Rotator3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(new Vector3(3,3,2),Space.Self);
        transform.Rotate(new Vector3(-0.5f, 0, 0));
    }
}

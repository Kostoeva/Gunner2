﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrankOutput : MonoBehaviour {
    public Transform rotation;

   
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        rotation = this.GetComponent<Transform>();

    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject ball;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - ball.transform.position;      //gets the offset of the camera and player
	}
	
	void LateUpdate () {        //Late update is called after update
        transform.position = ball.transform.position + offset;
	}
}

﻿using UnityEngine;
using System.Collections;

public class DestoryBounary : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

	}
	void OnTriggerExit(Collider other)
	{
		Destroy(other.gameObject);
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
	[SerializeField] private string loadLevel;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
		
	void OnTriggerEnter (Collider other)
	{
		if (other.CompareTag ("Player")) {
			SceneManager.LoadScene (loadLevel);
		}
	}
}

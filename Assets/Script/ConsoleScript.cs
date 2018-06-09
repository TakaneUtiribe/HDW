﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleScript : MonoBehaviour
{

	public GameObject door;
	bool flag = false;

	// Use this for initialization
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if (flag)
		{
			door.gameObject.transform.position = Vector3.Lerp(door.gameObject.transform.position, new Vector3(-2.9f, -1.4963f, -19.2f), Time.deltaTime);
		}
	}

	private void OnTriggerStay(Collider collider)
	{
		if (collider.gameObject.tag == "Player")
		{
			if (Input.GetKey(KeyCode.L))
			{
				flag = true;
			}
		}
	}
}


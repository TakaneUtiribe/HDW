﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    public GameObject wall;
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
			wall.gameObject.transform.position = Vector3.Lerp(wall.gameObject.transform.position, new Vector3(-1.77f, -1.4963f, 9.973543f), Time.deltaTime);
            }
        }

    void OnTriggerStay(Collider collider)
        {
            if (collider.gameObject.tag == "denkiman")
            {
                if (Input.GetKeyUp(KeyCode.L)) 
			    {
                    flag = true;
                }
               
            }
        }


}


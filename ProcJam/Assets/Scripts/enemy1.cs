﻿using UnityEngine;
using System.Collections;

public class enemy1 : MonoBehaviour 
{
    public Transform player;
    float playerTransX;
    float speed;
	// Use this for initialization
	void Start () 
    {
        speed = 3.50f;
	}
	
	// Update is called once per frame
	void Update () 
    {
       
        transform.LookAt(player.position);
       transform.Rotate(new Vector3(0, -90, 0), Space.Self);//correcting the original rotation

        if (Vector3.Distance(player.localPosition, gameObject.transform.localPosition)>1f)
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
           
        }
       
    }
}

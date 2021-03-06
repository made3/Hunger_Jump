﻿using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour 
{

	private Vector3 startPosition;
	public float eatSize = 1;
    public float rotationRange = 50;
    public float minimumPlayerSize;
    public float maximumPlayerSize;

	void Start () 
	{
		startPosition = transform.position;
        Rigidbody2D phisi = gameObject.GetComponent<Rigidbody2D>();
        phisi.AddTorque(Random.Range(-rotationRange,rotationRange));
    }

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "deadzone") 
		{
			transform.position = startPosition;
            Rigidbody2D phisi = gameObject.GetComponent<Rigidbody2D>();
            phisi.velocity = Vector2.zero;
            respawn();
		}
	}

	public void respawn()
	{
		Destroy (gameObject);
	}
}

﻿using UnityEngine;
using System.Collections;

public class impact : MonoBehaviour {

    public Rigidbody2D[] phisiToBeImpacted;
    public GameObject Player;
	
	public void fatImpact(float howFat)
    {
        for (int i = 0; i < phisiToBeImpacted.Length; i++)
        {
            Vector2 playerToObject = phisiToBeImpacted[i].gameObject.transform.position - Player.transform.position;
            Debug.Log(playerToObject);
            Debug.Log(playerToObject.normalized * howFat);
            phisiToBeImpacted[i].velocity = playerToObject * howFat / 20;
            phisiToBeImpacted[i].rotation = Random.Range(-45, 45);
        }
    }
}

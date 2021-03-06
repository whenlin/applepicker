﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {

    public float speed;
    public float leftAndRightEdge;
    public float chanceToChangeDirections;
    public float secondsBetweenAppleDrops;
    public GameObject applePrefab;
    public GameObject appleTree;


	// Use this for initialization
	void Start () {
        //creates the tree and initallizes the transform for use in the update method - acts like singleton, creates one object and monitors its behaviour
        appleTree = Instantiate(appleTree);
        InvokeRepeating("DropApple", 2f,secondsBetweenAppleDrops);
	}

    void DropApple()
    {
        GameObject apple;
        apple = Instantiate(applePrefab) as GameObject;
        apple.transform.position = appleTree.transform.position;
    }

    // Update is called once per frame
    void Update () {
        
        Vector3 pos = appleTree.transform.position;
        pos.x += speed * Time.deltaTime;
        appleTree.transform.position = pos;

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); // Move right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); // Move left
        }

    }

     void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1; // Change direction
        }

    }
}

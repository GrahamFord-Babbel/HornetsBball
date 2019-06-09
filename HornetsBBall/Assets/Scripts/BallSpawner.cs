﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    public static BallSpawner current;

    public GameObject pooledBall; //the prefab of the object in the object pool
    public int ballsAmount; //the number of objects you want in the object pool
    public List<GameObject> pooledBalls; //the object pool
    public static int ballPoolNum = 0; //a number used to cycle through the pooled objects

    //interacts with grabber script
    public BallThrownScript ballThrownScript;
    public Vector3 ballLocation;

    private float cooldown;
    private float cooldownLength = 3f;

    public GameObject selectedBall;
    public GameObject centerBallCart4Respawn;

    void Awake()
    {
        current = this; //makes it so the functions in ObjectPool can be accessed easily anywhere
    }

    void Start()
    {
        ballLocation = pooledBall.transform.position;
        //Create Bullet Pool
        pooledBalls = new List<GameObject>();
        for (int i = 0; i < ballsAmount; i++)
        {
            GameObject obj = Instantiate(pooledBall);
            obj.SetActive(false);
            pooledBalls.Add(obj);
        }
    }

public GameObject GetPooledBall()
{
    ballPoolNum++;
    if (ballPoolNum > (ballsAmount - 1))
    {
            ballPoolNum = 0;
    }
        //if we’ve run out of objects in the pool too quickly, create a new one
        if (pooledBalls[ballPoolNum].activeInHierarchy)
        {
            pooledBalls[ballPoolNum].SetActive(false);
        }
        //create a new bullet and add it to the bulletList

        //pooledBalls.Add(obj);
        //ballsAmount++; //Should i remove this so that it doesn't keep instantiating over 20?
        //ballPoolNum = ballsAmount - 1;
        //    //if (ballPoolNum > 20)
        //    //{
        //    //    pooledBalls.Remove(obj);
        //    //    ballsAmount--;
        //    //    ballPoolNum = ballsAmount + 1;
            //}
        
       
        return pooledBalls[ballPoolNum];
}
   	
	// Update is called once per frame
	void Update () {

        //instantiate ball if old ball has been thrown & timer sufficient
        if (ballThrownScript.ballThrown && cooldown <= 0)
        {
            SpawnBall();
            ballThrownScript.ballThrown = false;
            cooldown = cooldownLength;
        }

        //countdown timer to when next ball CAN appear
        cooldown -= Time.deltaTime;

        //if(cooldown <= 0)
        //{
        //    cooldown = cooldownLength;
        //    SpawnBall();
        //}		
    }

    void SpawnBall()
    {
        selectedBall = BallSpawner.current.GetPooledBall();
        selectedBall.transform.position = centerBallCart4Respawn.transform.position;
        Rigidbody selectedRigidbody = selectedBall.GetComponent<Rigidbody>();
        selectedRigidbody.velocity = Vector3.zero;
        selectedRigidbody.angularVelocity = Vector3.zero;
        //selectedRigidbody.useGravity = false; //delete this if reactivating its gravity on grab doesn't work 6/9
        selectedBall.SetActive(true);
        
    }

}

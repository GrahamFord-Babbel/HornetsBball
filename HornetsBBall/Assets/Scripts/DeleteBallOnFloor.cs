using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBallOnFloor : MonoBehaviour
{

    //to check if there are any balls not deleted / active
    public bool ballLive;
    public GameObject[] liveBall;
    public GameObject centerBallCart4Respawn;
    public BallSpawner ballSpawner;
    public BallThrownScript ballThrownScript;
    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "ball")
    //    {
    //        Debug.Log("ball recognized:" + other.name);
    //        Destroy(other);
    //    }


    //        //changing the destroy of this game object to deactivate, so that we can reactivate randomly
    //        //Destroy(this.gameObject);



    //}


    //FAIL
    //public void Update()
    //{
    //    liveBall = GameObject.FindGameObjectsWithTag("ball");
    //    print("this is whats in the liveball:" + liveBall[0]);

    //    if (liveBall != null)
    //    {
    //        Debug.Log("ball still exists");
    //        foreach (GameObject ball in liveBall)
    //        {
    //            print("live ball at: " + ball.transform.position);
    //        }
    //    }
    //    else if (liveBall[0] = null)
    //    {
    //        Debug.Log("balls all deleted");
    //        ballSpawner.ballLocation = centerBallCart4Respawn.transform.position;
    //        //pooledBalls[ballPoolNum].SetActive(true); //maybe do this?
    //        ballSpawner.SpawnBall();
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ball")
        {
            Debug.Log("ball recognized:" + other.name);
            Destroy(other);
            //ballThrownScript.ballThrown = true;

        }
    }
    //FAIL
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.tag == "ball")
    //    {
    //        Debug.Log("ball recognized:" + collision.gameObject.name);
    //        Destroy(collision.gameObject);
    //    }
    //}
}

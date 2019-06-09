using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionIgnore : MonoBehaviour
{
    public GameObject player1;
    public GameObject ball;

    void Start()
    {
        Physics.IgnoreCollision(player1.GetComponent<Collider>(), GetComponent<Collider>());
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            player1 = collision.gameObject;
            Physics.IgnoreCollision(player1.GetComponent<Collider>(), GetComponent<Collider>());
            Physics.IgnoreCollision(ball.GetComponent<Collider>(), GetComponent<Collider>());
        }

        if (collision.gameObject.tag == "ball")
        {

            ball = collision.gameObject;
            Physics.IgnoreCollision(ball.GetComponent<Collider>(), GetComponent<Collider>());
        }
    }

    //attempt to reactivate ball's gravity, but has to be when released, not when picked up FAIL
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.name == "LeftHandCollider" || other.name == "RightHandCollider")
    //    {
    //        this.GetComponent<Rigidbody>().useGravity = true;
    //    }
    //}
}
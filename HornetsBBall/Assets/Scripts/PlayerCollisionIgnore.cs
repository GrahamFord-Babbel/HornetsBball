using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionIgnore : MonoBehaviour
{
    public GameObject player1;

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
        }
    }
}
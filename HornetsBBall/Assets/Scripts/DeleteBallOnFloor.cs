using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBallOnFloor : MonoBehaviour
{



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ball")
        {
            Debug.Log("ball recognized:" + other.name);
            Destroy(other);
        }


            //changing the destroy of this game object to deactivate, so that we can reactivate randomly
            //Destroy(this.gameObject);
       


    }
}

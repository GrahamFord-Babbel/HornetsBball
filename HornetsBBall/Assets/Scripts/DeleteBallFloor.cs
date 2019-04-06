using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBallFloor : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ball")
        {
            Debug.Log(other.name);
            Destroy(other);
        }


    }
}

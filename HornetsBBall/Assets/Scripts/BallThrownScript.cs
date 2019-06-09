using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrownScript : MonoBehaviour

    
{
    public bool ballThrown;
    public GameObject shotball;

    // Start is called before the first frame update
    void Start()
    {
        ballThrown = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "ball")
        {
            Debug.Log("ball thrown: " + other.name);
            shotball = other.gameObject;
            ballThrown = true;
        }


    }

    }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBallFloorJersey : MonoBehaviour
{

    public GuillermoDunk guillermoDunk;
    public KembaShot kembaShot;

    private void Start()
    {
        guillermoDunk = GameObject.Find("LevelManager").GetComponent<GuillermoDunk>();
        kembaShot = GameObject.Find("LevelManager").GetComponent<KembaShot>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ball")
        {
            Debug.Log(other.name);
            Destroy(other);
        }
        if (other.tag == "Player")
        {
            Debug.Log(other.name);
            if(this.tag == "KembaJersey")
            {
                kembaShot.kembaJerseyActive = true;
            }
            if (this.tag == "GuillermoJersey")
            {
                guillermoDunk.guillermoJerseyActive = true;
            }
            Destroy(this.gameObject);
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerseyDeSpawner : MonoBehaviour

{ 
    public GuillermoDunk guillermoDunk;
    public KembaShot kembaShot;

    //jerseys
    public GameObject kembaJersey;
    public GameObject guillermoJersey;

    //jersey spawner script access
    public JerseySpawner jerseySpawner;

    //ignore hoop trigger
    public GameObject hoopIgnore;

    //get position from Teleport Point & check if change in variable
    //public TeleportPoint teleportPoint;
    //public event OnVariableChangeDelegate OnVariableChange;


    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreCollision(hoopIgnore.GetComponent<Collider>(), GetComponent<Collider>());
        kembaJersey.SetActive(false);
        guillermoJersey.SetActive(false)
;       guillermoDunk = GameObject.Find("LevelManager").GetComponent<GuillermoDunk>();
        kembaShot = GameObject.Find("LevelManager").GetComponent<KembaShot>();
    }


    // Update is called once per frame
    void Update()
    {
        //WEIRD TRY AT RECOGINIZING PORTING
        //if (teleportPoint.travelPositionA != teleportPoint.travelPositionB)
        //{
        //    jerseySpawner.SpawnJersey();

        //    print("got here2");
        //    if (this.name != "TeleportPadNET" & kembaJersey.activeSelf == true)
        //    {

        //        kembaShot.kembaJerseyActive = true;
        //        kembaJersey.SetActive(false);

        //    }
        //    else if (this.name == "TeleportPadNET" & guillermoJersey.activeSelf == true)
        //    {
        //        guillermoDunk.guillermoJerseyActive = true;
        //        guillermoJersey.SetActive(false);
        //    }

        //    teleportPoint.travelPositionA = teleportPoint.travelPositionB;
        //}
    }

    //first attempt FAIL

    private void OnTriggerEnter(Collider other)
    {
        if (other == hoopIgnore)
        {
            //ignore hoop collider
            hoopIgnore = other.gameObject;
            Physics.IgnoreCollision(hoopIgnore.GetComponent<Collider>(), GetComponent<Collider>());
        }
        Debug.Log("collider with position" + other.name);

        print("got here1");

        if (other.name == "Feet Collider for Jerseys") //really need to find a better way of activating this!?!
        {
            Debug.Log("Position collided with:" + other.name);

            //call a function from another JerseySpawner that On Enter WAITS, and then randomly sets active amongst
            //one of the 4 locations
            jerseySpawner.SpawnJersey();

            print("got here2");
            if (this.name != "TeleportPadNET" & kembaJersey.activeSelf == true)
            {

                kembaShot.kembaJerseyActive = true;
                kembaJersey.SetActive(false);

            }
            else if (this.name == "TeleportPadNET" & guillermoJersey.activeSelf == true)
            {
                guillermoDunk.guillermoJerseyActive = true;
                guillermoJersey.SetActive(false);
            }
        }
    }
}

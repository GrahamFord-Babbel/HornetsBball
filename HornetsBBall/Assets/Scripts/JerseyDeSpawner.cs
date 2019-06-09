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

    //readjust basketball location to ported area
    public GameObject leftBallPosition;
    public GameObject rightBallPosition;
    public GameObject centerBallPosition;
    public GameObject currentBallPosition;
    public BallSpawner ballSpawner;
    public GameObject leftBallCart;
    public GameObject rightBallCart;
    public GameObject centerBallCart;

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

        //WORK ON THIS: deactivate ball carts so they don't mess with teleportation - BUT causing issues with spawning, so just shrinking platform size for now
        //leftBallCart.SetActive(false);
        //rightBallCart.SetActive(false);
        //centerBallCart.SetActive(false); //active because starting position

        //IF placing manually doesn't work, try these:
        //ballSpawner = script on Dynamic ball?

        //rename this so its the platform:
        //currentBallPosition = ballSpawner.pooledBall;
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
        //Debug.Log("collider with position" + other.name);

        if (other.name == "Feet Collider for Jerseys") //really need to find a better way of activating this!?!
        {

            //call a function from another JerseySpawner that On Enter WAITS, and then randomly sets active amongst
            //one of the 4 locations
            StartCoroutine(jerseySpawner.SpawnJersey());


            //this one didnt work, need corutnine called FAIL
            //jerseySpawner.SpawnJersey();

            if (this.name != "TeleportPadNET")
            {

                //enter in ballposition reset conditionals here
                //if position equals 1 spawn ball at 1 & so on
                if (this.name == "TeleportPadLEFT") //i.e. 0
                {
                    Debug.Log("LeftPosition activated, ball moved successfully?");

                    //rename this so its the platform only:
                    //currentBallPosition.transform.position = leftBallPosition.transform.position;

                    ballSpawner.selectedBall.transform.position = leftBallPosition.transform.position;
                    ballSpawner.ballLocation = leftBallPosition.transform.position;

                    //WORK ON THIS:
                    //leftBallCart.SetActive(true);
                    //rightBallCart.SetActive(false);
                    //centerBallCart.SetActive(false);
                }
                else if (this.name == "TeleportPadRIGHT")
                {
                    ballSpawner.selectedBall.transform.position = rightBallPosition.transform.position;
                    ballSpawner.ballLocation = rightBallPosition.transform.position;

                    //WORK ON THIS:
                    //leftBallCart.SetActive(false);
                    //rightBallCart.SetActive(true);
                    //centerBallCart.SetActive(false);
                }
                else if (this.name == "TeleportPadCENTER")
                {
                    ballSpawner.selectedBall.transform.position = centerBallPosition.transform.position;
                    ballSpawner.ballLocation = centerBallPosition.transform.position;

                    //WORK ON THIS:
                    //leftBallCart.SetActive(false);
                    //rightBallCart.SetActive(false);
                    //centerBallCart.SetActive(true);
                }

                if (kembaJersey.activeSelf == true)
                {
                    kembaShot.kembaJerseyActive = true;
                    kembaJersey.SetActive(false);
                }

 

            }
            else if (this.name == "TeleportPadNET" & guillermoJersey.activeSelf == true)
            {
                guillermoDunk.guillermoJerseyActive = true;
                guillermoJersey.SetActive(false);
            }
        }
    }
}

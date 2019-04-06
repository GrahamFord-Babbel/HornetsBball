using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KembaShot : MonoBehaviour
{
    public GameObject shotball;
    public BallThrownScript ballThrownScript;
    public GameObject hoopTarget;
    public float shootAngle = 45.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            if (ballThrownScript.ballThrown ==true)
                {
                    shotball = ballThrownScript.shotball;
                    shotball.GetComponent<Rigidbody>().velocity = BallisticVelocity(hoopTarget.transform, shootAngle);
                    //Destroy(cannonBall, 10); // cannonball disappears after 10 seconds
                }

    }

    Vector3 BallisticVelocity(Transform target, float angle)
    {
        Vector3 dir = hoopTarget.transform.position - shotball.transform.position; // get Target Direction
        float height = dir.y; // get height difference
        dir.y = 0; // retain only the horizontal direction
        float dist = dir.magnitude; // get horizontal distance
        float a = angle * Mathf.Deg2Rad; // Convert angle to radians
        dir.y = dist * Mathf.Tan(a); // set dir to the elevation angle.
        dist += height / Mathf.Tan(a); // Correction for small height differences

        // Calculate the velocity magnitude
        float velocity = Mathf.Sqrt(dist * Physics.gravity.magnitude / Mathf.Sin(2 * a));
        return velocity * dir.normalized; // Return the velocity vector.
    }

}

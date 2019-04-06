using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuillermoDunk : MonoBehaviour
{

    public bool guillermoJerseyActive;
    public GameObject player1;
    public GameObject floor2;
    public GameObject guillermoBall;
    public GameObject guillermoBallSpawn;
    public bool guillermoHeight;

    //time limit to boost
    public float cooldown;
    public float cooldownLength = 3f;

    // Start is called before the first frame update
    void Start()
    {
        guillermoHeight = false;
        guillermoBall.SetActive(false);
        guillermoBallSpawn.SetActive(false);
        floor2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (guillermoJerseyActive)
        {
            if (!guillermoHeight)
            {
                player1.transform.Translate(new Vector3(0, 5, 0));
                guillermoHeight = true;
                guillermoBallSpawn.SetActive(true);
                guillermoBall.SetActive(true);
                floor2.SetActive(true);
                //guillermoJerseyActive = false;
            }

            cooldown -= Time.deltaTime;
        }

        if (cooldown <= 0)
        {
            guillermoBall.SetActive(false);
            guillermoBallSpawn.SetActive(false);
            floor2.SetActive(false);
            cooldown = cooldownLength;
            guillermoHeight = false;
            guillermoJerseyActive = false;
        }

    }
}

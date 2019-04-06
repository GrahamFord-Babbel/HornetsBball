using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KembaBasketChoser : MonoBehaviour
{
    public KembaShot kembaShot;
    public GameObject hoopTarget1;
    public GameObject hoopTarget2;
    public bool thisHoop1;

    // Start is called before the first frame update
    void Start()
    {
        if(this.name == "Basket 1 Kemba Trigger")
        {
            thisHoop1 = true;
        }
        if (this.name == "Basket 2 Kemba Trigger")
        {
            thisHoop1 = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ball")
        {
            Debug.Log(other.name);
            if (thisHoop1)
            {
                kembaShot.hoopTarget = hoopTarget1;
            }
            else if (!thisHoop1)
            {
                kembaShot.hoopTarget = hoopTarget2;
            }
        }


    }
}

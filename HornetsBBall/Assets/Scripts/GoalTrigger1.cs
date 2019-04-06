using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger1 : MonoBehaviour {

    public void OnTriggerEnter(Collider collider)
    {
        GoalTrigger2 trigger = GetComponentInChildren<GoalTrigger2>();
        trigger.ExpectCollider(collider);
    }
}

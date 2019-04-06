using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger2 : MonoBehaviour {

    Collider expectedCollider;

public void ExpectCollider(Collider collider)
    {
        expectedCollider = collider;  
    }
    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider == expectedCollider)
        {
            ScoreKeeper scoreKeep = FindObjectOfType<ScoreKeeper>();
            scoreKeep.IncrementScore(1);
        }
    }
}

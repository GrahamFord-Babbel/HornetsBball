using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeRemainingDisplay : MonoBehaviour
{
    LevelManager levelManager;
    Text timeRemainingText;

    // Use this for initialization
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
        timeRemainingText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeRemainingText.text = "Time Remaining: " + levelManager.timeTillNextLevel;
    }
}

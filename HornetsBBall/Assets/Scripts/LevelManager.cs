using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float timeTillNextLevel = 015f;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        //Load currentIndex + 1 when press space
        if (timeTillNextLevel > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                LoadNextScene();
            }

            timeTillNextLevel = timeTillNextLevel - Time.deltaTime;
            // End Level
            if (timeTillNextLevel < 0)
            {
                LoadNextScene();
            }
        }
	
	}
    public void LoadNextScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1);
    }
    public void LoadPreviousScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex - 1);
    }
}

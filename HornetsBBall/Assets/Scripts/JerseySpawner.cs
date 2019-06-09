using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerseySpawner : MonoBehaviour
{

    public float jerseySpawnRate;
    //public int jerseyCount;

    //random instatiation tools
    int positionNumber;
    int positionLocationNumber;

    //spawnlocations
    public GameObject leftPosition;
    public GameObject rightPosition;
    public GameObject centerPosition;
    public GameObject netPosition;
    public GameObject[] positions = new GameObject[4];

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SpawnJersey()
    {
        positionNumber = Random.Range(1, 4);
        foreach (GameObject position in positions)
        {
            positionLocationNumber = System.Array.IndexOf(positions, position);

            Debug.Log("the location entered:" + positionLocationNumber);

            if (positionNumber == positionLocationNumber)
            {

                Debug.Log("Jersey ready to activate:" + positionNumber);

                //set jersey active
                if (position != netPosition)
                {
                    Debug.Log("Kemba Jersey Spawining in: " + jerseySpawnRate);
                    position.GetComponent<JerseyDeSpawner>().kembaJersey.SetActive(true);
                }
                else if (position == netPosition)
                {
                    position.GetComponent<JerseyDeSpawner>().guillermoJersey.SetActive(true);
                }
            }
        }
        yield return new WaitForSeconds(jerseySpawnRate);
    }

    //first attempt FAIL
    //IEnumerator SpawnJersey()
    //{
    //    positionNumber = Random.Range(1, 4);
    //    for (int i = 0; i < positions.Length; i++)
    //    {
    //        if (positionNumber == positions[i].)
    //        {
    //            //set jersey active
    //        }
    //    }
    //    yield return new WaitForSeconds(jerseySpawnRate);
    //}
}

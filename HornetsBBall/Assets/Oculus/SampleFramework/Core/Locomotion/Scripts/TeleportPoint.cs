/************************************************************************************

Copyright (c) Facebook Technologies, LLC and its affiliates. All rights reserved.  

See SampleFramework license.txt for license terms.  Unless required by applicable law 
or agreed to in writing, the sample code is provided “AS IS” WITHOUT WARRANTIES OR 
CONDITIONS OF ANY KIND, either express or implied.  See the license for specific 
language governing permissions and limitations under the license.

************************************************************************************/

using UnityEngine;
using System.Collections;

public class TeleportPoint : MonoBehaviour {

    public float dimmingSpeed = 1;
    public float fullIntensity = 1;
    public float lowIntensity = 0.5f;

    public Transform destTransform;

    private float lastLookAtTime = 0;

    //added this, doesnt come with the Oculus script
    //public GameObject travelPositionA;
    //public GameObject travelPositionB;

    // Use this for initialization
    void Start () {

        //delete these?
        //travelPositionA = this.gameObject;
        //travelPositionB = this.gameObject;

    }

    public Transform GetDestTransform()
    {
       
        return destTransform;
        
    }
   


	
	// Update is called once per frame
	void Update () {

        //sad attempt
        //print("teleport position: " + this.name);
        //travelPositionB = this.gameObject;

        float intensity = Mathf.SmoothStep(fullIntensity, lowIntensity, (Time.time - lastLookAtTime) * dimmingSpeed);
        GetComponent<MeshRenderer>().material.SetFloat("_Intensity", intensity);
	}

    public void OnLookAt()
    {
        lastLookAtTime = Time.time;
    }
}

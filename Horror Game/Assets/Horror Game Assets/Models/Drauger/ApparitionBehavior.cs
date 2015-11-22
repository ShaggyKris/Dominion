using UnityEngine;
using System.Collections;

public class ApparitionBehavior : MonoBehaviour {
    
	
    
	// Update is called once per frame
	void Update () {

<<<<<<< Updated upstream
        //Increases object's x position to travel down hallway
        Vector3 pos = transform.position;
        pos.x = pos.x + 0.005f;
        transform.position = pos;
       
        if (transform.position.x > -25) //test to see if you can destory game object at certain position
        {
            Destroy(gameObject);
        }
    }
=======
		Vector3 pos = transform.position;
		pos.x = pos.x + 0.005f;
		transform.position = pos;

	}
>>>>>>> Stashed changes
}

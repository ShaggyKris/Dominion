using UnityEngine;
using System.Collections;

public class ApparitionBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    
	// Update is called once per frame
	void Update () {

        Vector3 pos = transform.position;
        pos.x = pos.x + 0.005f;
        transform.position = pos;
    }
}

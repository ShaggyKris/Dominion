using UnityEngine;
using System.Collections;

public class ApparitionBehavior : MonoBehaviour
{
	public Animator an;

	// Use this for initialization
	void Start ()
	{
		an.enabled = false;
	}
	
	public bool EN = false;
	// Update is called once per frame
	void Update ()
	{
		if (EN) {

			an.enabled = true;
			//Increases object's x position to travel down hallway
			Vector3 pos = transform.position;
			pos.x = pos.x + 0.01f;
			transform.position = pos;
       
			if (transform.position.x > -35) { //test to see if you can destory game object at certain position
				Destroy (gameObject);
			}
		}
	}
}

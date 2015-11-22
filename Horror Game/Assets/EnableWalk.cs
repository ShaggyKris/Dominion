using UnityEngine;
using System.Collections;

public class EnableWalk : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}

	void OnTriggerEnter (Collider other)
	{
		FindObjectOfType<ApparitionBehavior> ().EN = true;
	}

	// Update is called once per frame
	void Update ()
	{
	
	}
}

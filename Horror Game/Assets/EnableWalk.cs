using UnityEngine;
using System.Collections;

public class EnableWalk : MonoBehaviour
{
	public UnityStandardAssets.Characters.FirstPerson.FirstPersonController fps;

	// Use this for initialization
	void Start ()
	{
		
	}

	void OnTriggerEnter (Collider other)
	{
		FindObjectOfType<ApparitionBehavior> ().EN = true;
		fps.IsWalking=true;
		GetComponent<BoxCollider>().enabled = false;

	}

	// Update is called once per frame
	void Update ()
	{
	
	}
}

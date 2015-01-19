using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SetPathWhenControlled : MonoBehaviour {

	public List<Transform> path;
	public bool shouldRepeathPath = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setPath()
	{
		Debug.Log("SET PATH HERE");
		gameObject.GetComponent<SimplePathFollower>().path = path;
		gameObject.GetComponent<SimplePathFollower>().repeatPath = shouldRepeathPath;
		gameObject.GetComponent<SimplePathFollower>().doStart();
		animation.Play("walk");
	}
}

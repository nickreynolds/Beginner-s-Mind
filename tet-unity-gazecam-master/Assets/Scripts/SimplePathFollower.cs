using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SimplePathFollower : CameraOperator 
{
	public bool repeatPath = true;
	public List<Transform> path;
	private int index = 0;

	void Start()
	{
		AIPath ai = gameObject.GetComponent<AIPath>();
		ai.target = path[index];
	}

	public void handleTrigger(Transform other) 
	{
		Debug.Log("trigger enter");
		if (other == path[index])
		{
			AIPath ai = gameObject.GetComponent<AIPath>();
			index++;
			if (index == path.Count && repeatPath)
			{
				index = 0;
			}

			ai.target = path[index];
		}
	}
}

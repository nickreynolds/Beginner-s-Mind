﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SimplePathFollower : CameraOperator 
{
	public bool repeatPath = true;
	public List<Transform> path;
	private int index = 0;

	void Start()
	{
		doStart();
	}

	public void doStart()
	{
		AIPath ai = gameObject.GetComponent<AIPath>();
		if (path != null && path.Count > 0)
		{
			ai.target = path[index];
		}
	}

	public void handleTrigger(Transform other) 
	{
		Debug.Log("trigger enter");
		if (index < path.Count && other == path[index])
		{
			AIPath ai = gameObject.GetComponent<AIPath>();
			index++;
			if (index == path.Count && repeatPath)
			{
				index = 0;
			}

			if (index < path.Count)
			{
				ai.target = path[index];
			}
			else
			{
				ai.target = null;
			}
		}
	}
}

using UnityEngine;
using System.Collections;

public class PathTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.GetComponent<SimplePathFollower>() != null)
		{
			other.gameObject.GetComponent<SimplePathFollower>().handleTrigger(gameObject.transform);
		}
	}
}

using UnityEngine;
using System.Collections;

public class AnimatorControllerWalkRun : MonoBehaviour {

	public Animator animator;
	private AIPath aiPath;
	private SimplePathFollower pathFollower;
	// Use this for initialization
	void Start () {
		aiPath = GetComponent<AIPath>();
		pathFollower = GetComponent<SimplePathFollower>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (pathFollower.path != null && pathFollower.path.Count > 0)
		{
			animator.SetFloat("Speed", aiPath.speed);
		}
		else
		{
			animator.SetFloat("Speed", 0.0f);
		}
	}
}

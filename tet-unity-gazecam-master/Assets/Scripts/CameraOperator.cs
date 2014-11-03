using UnityEngine;
using System.Collections;

public class CameraOperator : MonoBehaviour 
{	
	public GameObject cameraHolder;
	private GameObject camera;
	public Vector3 CAMERA_LOCAL_POSITION = new Vector3(0.0f,0.0f,0.0f);
	public float HOLD_LENGTH = 1.0f;
	private float holdStartTime = 0.0f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void FixedUpdate()
	{
		if (camera != null)
		{
			if (holdStartTime + HOLD_LENGTH < Time.time)
			{
				attachCamera();
			}
		}
	}

	public void beginAttaching(GameObject camera)
	{
		this.camera = camera;
		holdStartTime = Time.time;
	}

	public void stopAttaching()
	{
		camera = null;
		holdStartTime = 0.0f;
	}

	public void attachCamera()
	{
		camera.transform.parent = cameraHolder.transform;
		camera.transform.localPosition = CAMERA_LOCAL_POSITION;
		camera = null;
		holdStartTime = 0.0f;
	}
}

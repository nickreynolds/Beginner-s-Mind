using UnityEngine;
using System.Collections;

public class CameraOperator : MonoBehaviour 
{	
	public GameObject cameraHolder;
	private GameObject camera;
	public GameObject indicatorSphere;
	public Vector3 CAMERA_LOCAL_POSITION = new Vector3(0.0f,0.0f,0.0f);
	public Quaternion CAMERA_LOCAL_ROTATION = Quaternion.identity;
	public float HOLD_LENGTH = 3.0f;
	private float holdStartTime = 0.0f;

	// Use this for initialization
	void Awake () 
	{
		CAMERA_LOCAL_ROTATION = GameObject.Find("Camera").transform.localRotation;
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
		Debug.LogWarning("begin attaching");
		this.camera = camera;
		holdStartTime = Time.time;
		indicatorSphere.SetActive(true);
	}

	public void stopAttaching()
	{
		Debug.LogWarning("stop attaching");
		camera = null;
		holdStartTime = 0.0f;
		indicatorSphere.SetActive(false);
	}

	public void attachCamera()
	{
		Debug.LogWarning("attach it");
		camera.transform.parent = cameraHolder.transform;
		iTween.RotateTo(camera, iTween.Hash("rotation", CAMERA_LOCAL_ROTATION.eulerAngles, "islocal", true, "time", 2.0f));
		iTween.MoveTo(camera, iTween.Hash("position", CAMERA_LOCAL_POSITION, "islocal", true, "time", 2.0f));
		//camera.transform.localPosition = CAMERA_LOCAL_POSITION;
		//camera.transform.localRotation = CAMERA_LOCAL_ROTATION;

		if (cameraHolder.GetComponentInParent<SetPathWhenControlled>() != null)
		{
			cameraHolder.GetComponentInParent<SetPathWhenControlled>().setPath();
		}

		camera = null;
		holdStartTime = 0.0f;
		indicatorSphere.SetActive(false);

	}
}

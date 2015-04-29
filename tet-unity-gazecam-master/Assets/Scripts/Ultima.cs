using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ultima : CameraOperator 
{
	public List<GameObject> ultimaPieces;

	public override void beginAction(GameObject camera)
	{
		base.beginAction(camera);

		foreach(GameObject piece in ultimaPieces)
		{
			iTween.RotateTo(piece, iTween.Hash("rotation", Vector3.zero, "time", HOLD_LENGTH, "islocal", true, "easetype", iTween.EaseType.linear));
		}
	}

	
	public override void stopAction()
	{
		Debug.LogWarning("stop action");
		base.stopAction();
		if (holdStartTime + HOLD_LENGTH > Time.time + .5f)
		{
			foreach(GameObject piece in ultimaPieces)
			{
				iTween.Stop(piece);
			}
		}
	}
}

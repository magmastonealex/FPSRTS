using UnityEngine;
using System.Collections;

public class getCameraExtents : MonoBehaviour {
	public Camera cameraForExtents;
	public GameObject referenceObject;
	public Vector3 cameraTopLeft;
	public Vector3 cameraTopRight;
	public Vector3 cameraBottomLeft;
	public Vector3 cameraBottomRight;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		float dist = Vector3.Distance(cameraForExtents.transform.position, referenceObject.transform.position);
		cameraBottomLeft = cameraForExtents.ScreenToWorldPoint(new Vector3 (0, 0,dist));
		cameraBottomRight = cameraForExtents.ScreenToWorldPoint(new Vector3 (Screen.width-1, 0,dist));
		cameraTopLeft = cameraForExtents.ScreenToWorldPoint(new Vector3 (0, Screen.height-1,dist));
		cameraTopRight = cameraForExtents.ScreenToWorldPoint(new Vector3 (Screen.width-1, Screen.height-1,dist));
	}
}

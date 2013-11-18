using UnityEngine;
using System.Collections;

public class cameraRectDrawer : MonoBehaviour {
	public GUIStyle st;
	getCameraExtents ce;
	public Rect boundingBox;
	public GameObject marker;
	// Use this for initialization
	void Start () {
		ce = this.gameObject.GetComponent<getCameraExtents> ();
	}
	
	// Update is called once per frame
	void OnGUI () {
	Vector3 vectr = this.gameObject.GetComponent<Camera>().WorldToScreenPoint(ce.cameraTopRight);
	Vector3 vecbl = this.gameObject.GetComponent<Camera> ().WorldToScreenPoint(ce.cameraBottomLeft);
	Vector3 vectl = this.gameObject.GetComponent<Camera> ().WorldToScreenPoint(ce.cameraTopLeft);
	Vector3 vecmk = this.gameObject.GetComponent<Camera> ().WorldToScreenPoint(marker.transform.position);
		boundingBox = new Rect (vecmk.x-vectl.x, (Screen.height-vecmk.y), 10, 10);
		GUI.Box(boundingBox, "", st);
	
	}
}

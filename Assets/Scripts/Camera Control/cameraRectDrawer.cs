using UnityEngine;
using System.Collections;

public class cameraRectDrawer : MonoBehaviour {
	public Transform camera;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
	Vector3 vec = this.gameObject.GetComponent<Camera>().WorldToScreenPoint(camera.position);

	GUI.Box(new Rect(vec.x-80,(Screen.height-vec.y)-80,100,90), "");
	
	}
}

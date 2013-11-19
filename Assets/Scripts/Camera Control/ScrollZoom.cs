using UnityEngine;
using System.Collections;

public class ScrollZoom : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	float deltaScroll = Input.GetAxis("Mouse ScrollWheel");
	if(deltaScroll < 0){
		this.camera.orthographicSize-=1;
	}else if (deltaScroll > 0){
		this.camera.orthographicSize += 1;
	}
}
}

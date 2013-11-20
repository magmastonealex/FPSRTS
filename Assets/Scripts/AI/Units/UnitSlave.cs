using UnityEngine;
using System.Collections;

public class UnitSlave : MonoBehaviour {
	public UnitGroup master;
	public string unitName;
	private SceneCoordinator scd;
	// Use this for initialization
	void Start () {
		scd = GameObject.Find ("SceneCoordinator").GetComponent<SceneCoordinator>();
	}
	
	// Update is called once per frame
	void OnMouseOver() {
		if (Input.GetMouseButtonDown (2)) {
			if(!scd.inFPS){
			scd.inFPS = true;
			GameObject.Find("RTSCamera").GetComponent<wasdMove>().enabled=false;
			GameObject.Find("RTSCamera").GetComponent<ScrollZoom>().enabled=false;
			master.goControl(this.gameObject);
			}
		}
	}
}

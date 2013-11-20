using UnityEngine;
using System.Collections;

public class UnitGroup : MonoBehaviour {

	public GameObject[] slaves;
	public Transform targe;
	private SceneCoordinator scd;
	// Use this for initialization
	void Start () {
	scd = GameObject.Find ("SceneCoordinator").GetComponent<SceneCoordinator>();
	setTarget(targe);
	foreach (GameObject slave in slaves){
		UnitSlave us = slave.GetComponent<UnitSlave>();
		us.master = this;
		slave.GetComponentInChildren<Camera>().enabled=false;
	}
	}

	public void goControl(GameObject chosen){
		setTarget(chosen.transform);
		FPSInputController fps = chosen.GetComponent<FPSInputController>();
		fps.isControlling = true;

		chosen.transform.Find ("Main Camera").gameObject.GetComponent<MouseLook> ().active = true;
		chosen.GetComponent<MouseLook>().active = true;

		GoToPoint gtp = chosen.GetComponent<GoToPoint>();
		gtp.canControl = false;
		chosen.GetComponentInChildren<Camera>().enabled=true;
	}

	void setTarget(Transform targ){
		foreach (GameObject slave in slaves){
			FPSInputController fps = slave.GetComponent<FPSInputController>();
			fps.isControlling = false;
			MouseLook ml = slave.GetComponent<MouseLook>();
			ml.active = false;
			slave.transform.Find ("Main Camera").gameObject.GetComponent<MouseLook> ().active = true;
			slave.GetComponent<MouseLook>().active = true;
			GoToPoint gtp = slave.GetComponent<GoToPoint>();
			gtp.canControl = true;
			gtp.target = targ;
			slave.GetComponentInChildren<Camera>().enabled=false;
		}
	}
	// Update is called once per frame
	void LateUpdate() {
		if (Input.GetKeyDown("q")) {
			this.setTarget(targe);
			if(scd.inFPS){
				scd.inFPS = false;
				GameObject.Find("RTSCamera").GetComponent<wasdMove>().enabled=true;
				GameObject.Find("RTSCamera").GetComponent<ScrollZoom>().enabled=true;
			}
		}
	}
}
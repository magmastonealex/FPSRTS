using UnityEngine;
using System.Collections;

public class UnitGroup : MonoBehaviour {

	public GameObject[] slaves;
	public Transform targe;
	// Use this for initialization
	void Start () {
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
		GoToPoint gtp = chosen.GetComponent<GoToPoint>();
		gtp.canControl = false;
		chosen.GetComponentInChildren<Camera>().enabled=true;
	}

	void setTarget(Transform targ){
		foreach (GameObject slave in slaves){
			FPSInputController fps = slave.GetComponent<FPSInputController>();
			fps.isControlling = false;
			GoToPoint gtp = slave.GetComponent<GoToPoint>();
			gtp.canControl = true;
			gtp.target = targ;
			slave.GetComponentInChildren<Camera>().enabled=false;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
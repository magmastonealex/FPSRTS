using UnityEngine;
using System.Collections;

public class UnitMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnMouseOver(){
		if(Input.GetMouseButtonDown(1)){
		GameObject[] slaves = this.gameObject.GetComponent<UnitSlave>().master.slaves;
		foreach(GameObject slave in slaves){
			slave.GetComponentInChildren<MeshRenderer>().material.color= new Color(1,1,1,1);
		}
		GetComponentInChildren<MeshRenderer>().material.color= new Color(0,0,1,1);
		GameObject.Find("RTSCamera").GetComponent<MenuFollower>().setTarget(transform);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}

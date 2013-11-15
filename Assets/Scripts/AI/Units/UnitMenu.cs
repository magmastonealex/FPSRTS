using UnityEngine;
using System.Collections;

public class UnitMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnMouseOver(){
		if(Input.GetMouseButtonDown(1)){
		GameObject.Find("RTSCamera").GetComponent<MenuFollower>().setTarget(transform);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}

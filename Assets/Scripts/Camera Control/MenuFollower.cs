using UnityEngine;
using System.Collections;

public class MenuFollower : MonoBehaviour {
	public Transform tofollow;
	public bool menuShowing;
	// Use this for initialization
	void Start () {
	
	}
	public void setTarget(Transform tran){
		menuShowing=true;
		tofollow = tran;
	}
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI () {
		float w = (float)(Screen.width*0.25);
		float h = (float)(Screen.height*0.25);
		//GUI.Box(new Rect(0, (float)(Screen.height*0.75), w, h), "Minimap");
		if(menuShowing){
			Vector3 vec = this.gameObject.GetComponent<Camera>().WorldToScreenPoint(tofollow.position);
			if(vec.x > 0 && vec.y >0){
				Debug.Log(vec.y);
				GUI.Box(new Rect(vec.x,Screen.height-vec.y,100,90), "Unit Menu");
				GUI.Button(new Rect(vec.x,Screen.height-vec.y+20,90,15), "Attack");
				GUI.Button(new Rect(vec.x,Screen.height-vec.y+20+15,90,15), "Defend");
				GUI.Button(new Rect(vec.x,Screen.height-vec.y+20+15+15,90,15), "Support");
				GUI.Button(new Rect(vec.x,Screen.height-vec.y+20+15+15+15,90,15), "Move");
			}
		}
	}
}

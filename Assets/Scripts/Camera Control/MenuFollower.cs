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
		if(menuShowing){
			Vector3 vec = this.gameObject.GetComponent<Camera>().WorldToScreenPoint(tofollow.position);
			if(vec.x > 0 && vec.y >0){
				Debug.Log(vec.y);
				GUI.Box(new Rect(vec.x,Screen.height-vec.y,100,90), "Unit Menu");
			}
		}
	}
}

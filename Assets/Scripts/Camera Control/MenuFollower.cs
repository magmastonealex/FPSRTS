using UnityEngine;
using System.Collections;

public class MenuFollower : MonoBehaviour {
	public Transform tofollow;
	// Use this for initialization
	void Start () {
	
	}
	public void setTarget(Transform tran){
		tofollow = tran;
	}
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI () {
		Vector3 vec = this.gameObject.GetComponent<Camera>().WorldToScreenPoint(tofollow.position);
		GUI.Box(new Rect(vec.x,vec.y,100,90), "Unit Menu");
	}
}

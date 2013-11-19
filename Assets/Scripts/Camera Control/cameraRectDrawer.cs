using UnityEngine;
using System.Collections;

public class cameraRectDrawer : MonoBehaviour {
	public GUIStyle st;
	getCameraExtents ce;
	public Rect boundingBox;
	private Vector3 vectr;
	private Vector3 vecbr;
	private Vector3 vectl;
	private Vector3 vecbl;
	
	public GameObject tl;
	public GameObject tr;
	

	public GameObject bl;
	public GameObject br;
	// Use this for initialization
	void Start () {
		ce = this.gameObject.GetComponent<getCameraExtents>();
	}
	void LateUpdate(){
		
	}
	// Update is called once per framew
	void OnGUI () {
	GameObject[] objects = GameObject.FindGameObjectsWithTag("Unit");
		foreach(GameObject obj in objects){
			Vector3 obv = this.gameObject.GetComponent<Camera>().WorldToScreenPoint(obj.transform.position);
			GUI.Box(new Rect(obv.x, (Screen.height-obv.y), 10,10),"",st);
	}

	switchToCamera();
	drawWithVerts();
	switchToMap();
	drawWithVerts();
	}
	void switchToCamera(){
		vectr = this.gameObject.GetComponent<Camera>().WorldToScreenPoint(ce.cameraTopRight);
		vecbr = this.gameObject.GetComponent<Camera> ().WorldToScreenPoint(ce.cameraBottomRight);
		vectl = this.gameObject.GetComponent<Camera> ().WorldToScreenPoint(ce.cameraTopLeft);
		vecbl = this.gameObject.GetComponent<Camera> ().WorldToScreenPoint(ce.cameraBottomLeft);
	}
	void switchToMap(){
	     vectr = this.gameObject.GetComponent<Camera>().WorldToScreenPoint(tr.transform.position);
		vecbr = this.gameObject.GetComponent<Camera> ().WorldToScreenPoint(br.transform.position);
		vectl = this.gameObject.GetComponent<Camera> ().WorldToScreenPoint(tl.transform.position);
		vecbl = this.gameObject.GetComponent<Camera> ().WorldToScreenPoint(bl.transform.position);
	}
	void drawWithVerts(){
		vectr.x = (int)vectr.x;
		vectr.y = (int)vectr.y;
		vectl.x = (int)vectl.x;
		vectl.y = (int)vectl.y;
		vecbr.x = (int)vecbr.x;
		vecbr.y = (int)vecbr.y;
		vecbl.x = (int)vecbl.x;
		vecbl.y = (int)vecbl.y;
		Drawing.DrawLine(new Vector2(vectr.x, (Screen.height-vectr.y)),new Vector2(vectl.x, (Screen.height-vectl.y)));
		Drawing.DrawLine(new Vector2(vecbl.x, (Screen.height-vecbl.y)),new Vector2(vecbr.x, (Screen.height-vecbr.y)));
		Drawing.DrawLine(new Vector2(vectl.x, (Screen.height-vectl.y)),new Vector2(vecbl.x, (Screen.height-vecbl.y)));
		Drawing.DrawLine(new Vector2(vectr.x, (Screen.height-vectr.y)),new Vector2(vecbr.x, (Screen.height-vecbr.y)));
		Drawing.DrawLine(new Vector2(vectr.x, (Screen.height-vectr.y)),new Vector2(vecbr.x, (Screen.height-vecbr.y)));
	}
}

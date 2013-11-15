using UnityEngine;
using System.Collections;

public class wasdMove : MonoBehaviour {
	public double movePerTick=1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	transform.position += new Vector3((float)(Input.GetAxis("Horizontal")*movePerTick),(float)0.00,(float)(Input.GetAxis("Vertical")*movePerTick));
	
	}
}

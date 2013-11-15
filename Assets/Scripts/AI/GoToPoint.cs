using UnityEngine;
using System.Collections;

public class GoToPoint : MonoBehaviour {
	public Transform target;
	public bool canControl = true;
	//WARNINGWARNINGWARNING, if moveSpeed is too high, it can overshoot - not necessarily a bad thing, but something to keep in mind.
	public int moveSpeed;
	public int rotationSpeed;
	public string movementAnimation;
	private Transform myTransform;
	CharacterMotor motor;
	void Awake()
	{
		target = transform;
		myTransform = transform;
		motor = gameObject.GetComponent<CharacterMotor>();
	}
	
	void Update () {
	if(canControl == true){
	float dist = Vector3.Distance(myTransform.position, target.position);
 	if(dist > 5){
	myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
	Vector3 directionVector = target.position - myTransform.position;

		float directionLength = directionVector.magnitude;
		directionVector = directionVector / directionLength;

		// Make sure the length is no bigger than 1
		directionLength = Mathf.Min(moveSpeed, directionLength);
		
		// Make the input vector more sensitive towards the extremes and less sensitive in the middle
		// This makes it easier to control slow speeds when using analog sticks
		// Multiply the normalized direction vector by the modified length
		directionVector = directionVector * directionLength;

	motor.inputMoveDirection = directionVector;
	} else{
		motor.inputMoveDirection = Vector3.zero;
	}
	}
}
}
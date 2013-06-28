using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]

public class Walker : MonoBehaviour {
	
	public static Vector3 UP = new Vector3(0f,0f,1f);
	public static Vector3 DOWN = new Vector3(0f,0f,-1f);
	public static Vector3 LEFT = new Vector3(-1f,0f,0f);
	public static Vector3 RIGHT = new Vector3(1f,0f,0f);
	
	public Vector3 move;
	public float moveSpeed = 5f;
	protected CharacterController controller; 
		
	// Use this for initialization
	public virtual void Start () {
		controller = GetComponent<CharacterController>();
		move = UP;
	}
	
	// Update is called once per frame
	public virtual void Update () {
		move.Normalize();
		LookInMoveDirection();
		controller.SimpleMove(move * moveSpeed);
	}
	
	private void LookInMoveDirection(){
		Quaternion target = new Quaternion();
		if (move != Vector3.zero){
			target.SetLookRotation(move);
			transform.rotation = target;
		}
	}
}
	
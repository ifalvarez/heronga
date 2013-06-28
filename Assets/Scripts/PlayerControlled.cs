using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Walker))]
public class PlayerControlled : MonoBehaviour {
	
	private Walker walker;
	
	// Use this for initialization
	void Start () {
		walker = GetComponent<Walker>();
	}
	
	// Update is called once per frame
	void Update () {
		//choose direction
		if(Input.GetAxis("Horizontal") > 0){
			walker.move = Walker.RIGHT;
		}else if(Input.GetAxis("Horizontal") < 0){
			walker.move = Walker.LEFT;
		}else if(Input.GetAxis("Vertical") > 0){
			walker.move = Walker.UP;
		}else if(Input.GetAxis("Vertical") < 0){
			walker.move = Walker.DOWN;
		}
	}
	
	
}

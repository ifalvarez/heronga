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
		//Keyboard direction
		if(Input.GetAxis("Horizontal") > 0){
			walker.move = Walker.RIGHT;
		}else if(Input.GetAxis("Horizontal") < 0){
			walker.move = Walker.LEFT;
		}else if(Input.GetAxis("Vertical") > 0){
			walker.move = Walker.UP;
		}else if(Input.GetAxis("Vertical") < 0){
			walker.move = Walker.DOWN;
		}else{
			//Touch direction
			switch(TouchPlayerController.direction){
			case 0:
				walker.move = Walker.UP;
				break;
			case 1:
				walker.move = Walker.RIGHT;
				break;
			case 2:
				walker.move = Walker.DOWN;
				break;
			case 3:
				walker.move = Walker.LEFT;
				break;
			}
		}
	}
	
	
}

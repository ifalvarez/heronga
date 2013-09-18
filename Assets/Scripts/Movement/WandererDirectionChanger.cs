using UnityEngine;
using System.Collections;

public class WandererDirectionChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnControllerColliderHit(ControllerColliderHit other){
		if(other.gameObject.tag == "Wall"){
			Wanderer w = gameObject.GetComponent<Wanderer>();
			w.changeDirection();
		}
	}
}

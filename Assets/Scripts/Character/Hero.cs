using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour {
	
	public GameObject followTarget = null;
	protected Walker walker = null;
	
	// Use this for initialization
	void Start () {
		walker = GetComponent<Walker>();
	}
	
	// Update is called once per frame
	void Update () {
		if (followTarget != null){
			Follow(); 			
		}
		// Remove inclination
		transform.eulerAngles = new Vector3(0, transform.eulerAngles.y ,0);
	}
	
	public void Follow(Hero hero){
		followTarget = hero.gameObject;
	}
	
	private void Follow(){
		Vector3 targetPosition = followTarget.transform.position - 
			followTarget.transform.forward * 
			followTarget.GetComponent<CharacterController>().radius * 3;
		if (Vector3.Distance(transform.position, targetPosition) > 0.1){
			walker.move = targetPosition - transform.position;
		} else{
			walker.move = Vector3.zero;
		}
	}
}

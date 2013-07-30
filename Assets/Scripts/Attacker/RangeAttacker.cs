using UnityEngine;
using System.Collections;
	
[RequireComponent(typeof(SphereCollider))]
public class RangeAttacker : Attacker {
	//Makes this object automatically attack nearby targets	
	
	SphereCollider attackRange;
	public string[] tagsToTarget = {"Enemy"};
	
	// Use this for initialization
	public override void Start () {
		base.Start();
		attackRange = GetComponent<SphereCollider>();
		attackRange.radius = 5;
		attackRange.isTrigger = true;
	}
	
	void OnTriggerEnter(Collider other) {
		getTarget(other);
    }
	
	void OnTriggerStay(Collider other) {
		getTarget(other);
    }
	
	void OnTriggerExit(Collider other) {
		if (performer.target != null && performer.target.name == other.gameObject.name){
        	performer.target = null;
		}
    }
	
	void getTarget(Collider other){
		if (performer.target == null){
			foreach (string t in tagsToTarget){
				if(other.tag == t){
					performer.target = other.gameObject;
					break;
				}
			}
		}
	}
	
	public override void Update ()
	{
		base.Update ();
		if (performer.target != null){
			Attack();
		}
	}
}

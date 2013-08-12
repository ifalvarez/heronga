using UnityEngine;
using System.Collections;
	
[RequireComponent(typeof(SphereCollider))]
public class RangeAttacker : Attacker {
	//Makes this object automatically attack targets inside the collider	
	
	Collider attackRange;
	public string[] tagsToTarget = {"Enemy"};
	public GameObject target = null;
	
	// Use this for initialization
	public override void Start () {
		base.Start();
		attackRange = GetComponent<Collider>();
		attackRange.isTrigger = true;
	}
	
	public override void Update ()
	{
		base.Update ();
		if (target != null){
			Attack();
		}
	}
	
	void OnTriggerEnter(Collider other) {
		getTarget(other);
    }
	
	void OnTriggerStay(Collider other) {
		getTarget(other);
    }
	
	void OnTriggerExit(Collider other) {
		if (target != null && target.name == other.gameObject.name){
        	target = null;
		}
    }
	
	void getTarget(Collider other){
		if(target == null){
			foreach (string t in tagsToTarget){
				if(other.tag == t){
					target = other.gameObject;
					break;
				}
			}
		}
	}
}

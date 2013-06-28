using UnityEngine;
using System.Collections;

public class Skill : MonoBehaviour {

	protected float cooldown = 0f;
	
	// Use this for initialization
	virtual public void Start () {
	
	}
	
	// Update is called once per frame
	virtual public void Update () {
	
	}
	
	//Execute the skill. returns false if the skill was not performed
	public virtual bool Unleash(Performer performer){
		return false;
	}
	
	public virtual bool Unleash(Performer performer, GameObject target){
		return false;
	}
	
	public virtual bool Unleash(Performer performer, Vector3 targetVector){
		return false;
	}
}

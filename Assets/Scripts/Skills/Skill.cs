using UnityEngine;
using System.Collections;

public class Skill : MonoBehaviour {
	
	protected Performer performer = null;
	protected Attacker attacker = null;
	
	// Use this for initialization
	virtual public void Start () {
		attacker = GetComponent<Attacker>();
		performer = transform.parent.GetComponent<Performer>();
		if (performer == null){
			Debug.LogError("No performer in skill parent");
		}
	}
	
	// Update is called once per frame
	virtual public void Update () {
	
	}
	
	//Execute the skill. returns false if the skill was not performed
	public virtual bool Unleash(){
		return false;
	}
	public virtual bool Unleash(GameObject target){
		return false;
	}
	public virtual bool Unleash(Vector3 targetVector){
		return false;
	}
}

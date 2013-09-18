using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {
	
	public float cooldown = 1.0f;
	protected float nextAttackTime = 0.0f;
	protected Skill skill = null;
	public string[] tagsToTarget = null;
		
	virtual public void Start(){
		skill = GetComponent<Skill>();
	}
	
	// Update is called once per frame
	public virtual void Update () {
		
	}
	
	public virtual void Attack(){
		if (Time.time > nextAttackTime) {
			skill.Unleash();
			nextAttackTime = Time.time + cooldown;
		}
	}
}

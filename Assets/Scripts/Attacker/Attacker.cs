using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Performer))]
public class Attacker : MonoBehaviour {
	
	public float attackSpeed = 1f;
	protected float nextAttackDelay = 0f;
	protected Performer performer;
	public Skill skill = null;
	
	// Use this for initialization
	public virtual void Start () {
		performer = GetComponent<Performer>();
		if(performer == null)
			Debug.LogError("no performer");
		if(skill == null){
			skill = performer.skills[0];
		}
	}
	
	// Update is called once per frame
	public virtual void Update () {
		//Calculate next attack timing
		if (nextAttackDelay > 0){
			nextAttackDelay -= Time.deltaTime;
		}
	}
	
	public virtual void Attack(){
		if (nextAttackDelay <= 0) {
			skill.Unleash(performer);
			nextAttackDelay = attackSpeed;
		}
	}
}

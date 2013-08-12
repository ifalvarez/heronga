using UnityEngine;
using System.Collections;

public class Damageable : MonoBehaviour {
	
	public int hp = 100;
	protected Animator animator = null;
	protected int gettingHitState = Animator.StringToHash("Base Layer.Getting hit"); 
	protected int spellState = Animator.StringToHash("Base Layer.Spell");
	private AnimatorStateInfo currentStateInfo;
	
	// Use this for initialization
	void Start () {
		animator = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		currentStateInfo = animator.GetCurrentAnimatorStateInfo(0);
		if (hp <= 0){
			Die();
		}
		if (currentStateInfo.nameHash == gettingHitState){
			animator.SetBool("hit", false);
		}
		if (currentStateInfo.nameHash == spellState){
			animator.SetBool("spell", false);
		}
		
	}
	
	public void Damage(int amount){
		hp -= amount;
		animator.SetBool("hit", true);
	}
	
	virtual public void Die(){
		Destroy(gameObject);
	}
}

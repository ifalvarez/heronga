using UnityEngine;
using System.Collections;

public class Damageable : MonoBehaviour {
	
	public float maxHp = 100;
	public float hp;
	protected Animator animator = null;
	protected int gettingHitState = Animator.StringToHash("Base Layer.Getting hit"); 
	protected int spellState = Animator.StringToHash("Base Layer.Spell");
	private AnimatorStateInfo currentStateInfo;
	public HPBar hpBar;
	
	// Use this for initialization
	void Start () {
		animator = transform.parent.gameObject.GetComponentInChildren<Animator>();
		hp = maxHp;
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
		if (hpBar != null){
			hpBar.setPercentage(hp/maxHp);
		}
		animator.SetBool("hit", true);
	}
	
	virtual public void Die(){
		Destroy(transform.parent.gameObject);
	}
}

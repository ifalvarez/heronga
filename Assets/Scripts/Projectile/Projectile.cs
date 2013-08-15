using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	
	public float moveSpeed = 5;
	public int damage = 10;
	public float expireTime = 3;
	private GameObject target = null;
	
	// Use this for initialization
	public virtual void Start () {
		if (expireTime > 0){
			Expire(expireTime);
		}
		rigidbody.AddForce(transform.forward * moveSpeed, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	public virtual void Update () {
		//Destroy on expire
		if (expireTime > 0 && Time.time >= expireTime){
			Destroy(gameObject);
		}
	}
	
	void OnCollisionEnter(Collision other) {
		target = other.gameObject;
		OnHit();
	}
	
	public void OnHit(){
		DoDamage();
		DestroyProjectile();
	}
	
	public virtual void DoDamage(){
		Damageable damageable = target.GetComponent<Damageable>();
		if (damageable != null){
			damageable.Damage(damage);
		}
	}
	
	//Handle destroy and its animations
	virtual public void DestroyProjectile() {
		Destroy(gameObject);
	}
	
	public void Expire(float timeToExpire){
		expireTime = Time.time + timeToExpire;
	}
}

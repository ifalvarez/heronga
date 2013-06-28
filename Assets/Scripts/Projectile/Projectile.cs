using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	
	public float moveSpeed = 5;
	public int damage = 10;
	private float expireTime = 0;
	
	// Use this for initialization
	public virtual void Start () {
		if (expireTime > 0){
			Expire(expireTime);
		}
	}
	
	// Update is called once per frame
	public virtual void Update () {
		//Destroy on expire
		if (expireTime > 0 && Time.time >= expireTime){
			Destroy(gameObject);
		}
	}
	
	void OnCollisionEnter(Collision other) {
		CheckDamage(other);
		CheckDestroyProjectile(other);
	}
	
	public virtual void CheckDestroyProjectile(Collision other){
		Destroy(gameObject);
	}
	
	public virtual void CheckDamage(Collision other){
		Damageable damageable = other.gameObject.GetComponent<Damageable>();
		if (damageable != null){
			damageable.Damage(damage);
		}
	}
	
	public void Expire(float timeToExpire){
		expireTime = Time.time + timeToExpire;;
	}
}

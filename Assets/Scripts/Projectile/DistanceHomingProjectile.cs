using UnityEngine;
using System.Collections;

public class DistanceHomingProjectile : MonoBehaviour {
	public float moveSpeed = 5;
	public int damage = 10;
	private float expireTime = 0;
	Transform tip = null;
	
	public GameObject target = null;
	public GameObject targetAnchor = null;
	protected float targetRadius = 0.6f;
	private bool selfDestroying = false;
	
	public virtual void Start () {
		if (expireTime > 0){
			Expire(expireTime);
		}
		tip = transform.Find("Tip");
		targetAnchor = target.transform.Find("Anchors").Find("TargetAnchor").gameObject;
	}
	
	// Update is called once per frame
	virtual public void Update () {
		if (expireTime > 0 && Time.time >= expireTime){
			Destroy(gameObject);
		}
		if (selfDestroying){
			transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
		}else if (target != null){
			if (Vector3.Distance(tip.position, targetAnchor.transform.position) <= targetRadius){
				OnHit();
			}else{
				transform.LookAt(targetAnchor.transform.position);
				transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
			}
		}else{
			selfDestroying = true;
			Expire(1f);
		}
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
		expireTime = Time.time + timeToExpire;;
	}
}
